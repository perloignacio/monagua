using API.Clases;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;
using MimeKit;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("compras")]
    public class ComprasController : ApiController
    {
        [Route("validar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult validar([FromBody] ComprasDetalle obj)
        {
            try
            {
                ActividadesRules acRules=new ActividadesRules();
                List<ActividadesHorarios> lista = acRules.ConfiguraHorarios(obj.IdActividad,true);
                ActividadesHorarios ac;
                ac=lista.Find(h=>h.FechaInicio==obj.FechaHora);
                if (ac == null)
                {
                    var error = new { estado = "Error", mensaje = "No se encuentra el horario" };
                    return Ok(error);
                }
                if (!ac.ActividadesEntity.Activa )
                {
                    var error = new { estado = "Error", mensaje = "La actividad no se encuentra activa" };
                    return Ok(error);
                }
                if (obj.Cantidad > ac.Capacidad)
                {
                    var error = new { estado = "Error", mensaje = "No disponemos de ese cupo, el maximo es " + ac.Capacidad };
                    return Ok(error);
                }

                if (obj.Cantidad ==0)
                {
                    var error = new { estado = "Error", mensaje = "Debe indicar la cantidad de personas"};
                    return Ok(error);
                }

                var ok = new { estado = "OK", mensaje = "" };
                return Ok(ok);





            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("AgregarEditar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar([FromBody] Compras obj)
        {
            try
            {
                ComprasRules cRules =new ComprasRules();
                if (obj.IdObjeto == 0)
                {
                    return Ok(cRules.AgregarCarrito(obj));
                }
                else
                {
                    return Ok(cRules.Actualizar(obj));
                }
                

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("GetLinkMercadoPago")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult GetLinkMercadoPago(Compras c)
        {
            var identity = Thread.CurrentPrincipal.Identity;
            Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));


            ComprasRules cRules = new ComprasRules();

            MercadoPagoConfig.AccessToken = ConfiguracionMapper.Instance().GetByClave("Acces_Token").Valor;
           
            decimal acu = 0;
            decimal desc = 0;
            decimal total = 0;
            c.Detalle.ForEach(d =>
            {
                decimal precio = d.ActividadesEntity.PrecioOferta.HasValue ? d.ActividadesEntity.PrecioOferta.Value : d.ActividadesEntity.Precio;
                d.MontoActividad = precio;
                acu += d.Cantidad * precio;
            });
            if (c.DescuentosEntity != null)
            {
                desc = c.DescuentosEntity.Monto != null ? c.DescuentosEntity.Monto.Value : ((c.DescuentosEntity.Porcentaje.Value * acu) / 100);
            }
            if (c.Reserva)
            {
                total = (acu - desc) / 2;
            }
            else
            {
                total = (acu - desc);
            }

            c.MontoDescuento = desc;
            cRules.Actualizar(c);

            var request = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
                {
                    new PreferenceItemRequest
                    {
                        Title = "Compra - Monagua ",
                        Quantity = 1,
                        CurrencyId = "ARS",
                        UnitPrice = total,
                    },
                },
            };
            request.ExternalReference = c.IdObjeto.ToString();
            PreferenceBackUrlsRequest b = new PreferenceBackUrlsRequest();
            string dominio = ConfiguracionMapper.Instance().GetByClave("Dominio").Valor;
            b.Failure = dominio + "error";
            b.Pending = dominio + "error";
            b.Success = dominio + "gracias";
            request.BackUrls = b;
            request.AutoReturn = "approved";
            PreferencePaymentTypeRequest p = new PreferencePaymentTypeRequest();
            p.Id = "ticket";

            List<PreferencePaymentTypeRequest> pl = new List<PreferencePaymentTypeRequest>();
            pl.Add(p);
            request.PaymentMethods = new PreferencePaymentMethodsRequest();
            request.PaymentMethods.ExcludedPaymentTypes = pl;

            string webhook = ConfiguracionMapper.Instance().GetByClave("WebHook").Valor;
            request.NotificationUrl = webhook;
            var client = new PreferenceClient();
            Preference preference = client.Create(request);
            return Ok(preference.InitPoint);
            
        }

       

        [Route("Finalizar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Finalizar(string id, string topic)
        {
            try
            {
                if (topic == "payment")
                {
                    MercadoPagoConfig.AccessToken = ConfiguracionMapper.Instance().GetByClave("Acces_Token").Valor;
                    MercadoPago.Resource.Payment.Payment pay = new MercadoPago.Resource.Payment.Payment();
                    var client = new MercadoPago.Client.Payment.PaymentClient();
                    pay = client.Get(long.Parse(id));
                    if(pay.Status== "approved")
                    {
                        int idcompra = int.Parse(pay.ExternalReference);
                        ComprasRules cRules = new ComprasRules();
                        Compras obj = new Compras();
                        obj = cRules.Finalizar(idcompra,id);
                        obj.Detalle= ComprasDetalleMapper.Instance().GetByCompras(idcompra);
                        this.MailCompra(obj);
                    }
                    

                    

                }
                return Ok(true);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            

        }

        [Route("FinalizarManual")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult FinalizarManual(Compras c)
        {
            try
            {
                int idcompra = c.IdObjeto;
                ComprasRules cRules = new ComprasRules();
                Compras obj = new Compras();
                obj = cRules.Finalizar(idcompra, "idfinalizarmanual");
                obj.Detalle = ComprasDetalleMapper.Instance().GetByCompras(idcompra);
                this.MailCompra(obj);

                return Ok(true);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            

        }

        private void MailCompra(Compras compra)
        {

            decimal acu = 0;
            decimal desc = 0;
            decimal total = 0;

            compra.Detalle.ForEach(d =>
            {
                decimal precio = d.ActividadesEntity.PrecioOferta.HasValue ? d.ActividadesEntity.PrecioOferta.Value : d.ActividadesEntity.Precio;
                acu += d.Cantidad * precio;
            });

            if (compra.DescuentosEntity != null)
            {
                desc = compra.DescuentosEntity.Monto != null ? compra.DescuentosEntity.Monto.Value : ((compra.DescuentosEntity.Porcentaje.Value * acu) / 100);
            }

            if (compra.Reserva)
            {
                total = (acu - desc) / 2;
            }
            else
            {
                total = (acu - desc);
            }

            if (!string.IsNullOrEmpty(compra.ClientesEntity.Email))
            {

                string body = String.Empty;
                var path = HttpContext.Current.Server.MapPath("~/Plantillas/compra.html");
                var fileStream = System.IO.File.OpenRead(path);
                StreamReader reader = new StreamReader(fileStream);
                body = reader.ReadToEnd();
                body = body.Replace("{ubicacionlogo}", ConfiguracionMapper.Instance().GetByClave("UbicacionLogo").Valor);
                body = body.Replace("{nombre}", compra.ClientesEntity.Nombre);
                string items = "";
                foreach (ComprasDetalle detalle in compra.Detalle)
                {
                    decimal precio = detalle.ActividadesEntity.PrecioOferta.HasValue ? detalle.ActividadesEntity.PrecioOferta.Value : detalle.ActividadesEntity.Precio;
                    items += "<tr><td width='260' style='padding:0px 20px;vertical-align: top' valign='top'><p style='margin-bottom: 0px;font-size: 16px;margin-bottom: 5px;'><b>" + detalle.ActividadesEntity.Nombre + "</b></p>" +
                       "<p style='font-size: 12px'>Cantidad: <b style='font-size: 14px;'>" + detalle.Cantidad + "</b></p>" +
                      "<p style='font-size: 12px'> Fecha : <b style='font-size: 14px;'>" + detalle.FechaHora.ToString("dd/MM/yyyy hh:mm") + "</b></p>" +
                   "</td><td width='195'  valign='top' style='text-align: right;'><p style='font-size: 18px;'><b>$ " + (detalle.Cantidad * precio).ToString() + ".-</b></p></td></tr><tr><td colspan='3' style=''><div style='border-bottom: 1px solid #303030;margin:20px 0px;'></div></td></tr>";



                }

                body = body.Replace("{resumen}", items);
                body = body.Replace("{obs}", compra.Comentarios);
                body = body.Replace("{envio}", "");
                body = body.Replace("{pago}", "");

                body = body.Replace("{total}", total.ToString("0.00"));
                body = body.Replace("{email_compra}", ConfiguracionMapper.Instance().GetByClave("email_compra").Valor);

                MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                BodyBuilder cuerpo = new BodyBuilder();

                cuerpo.HtmlBody = body;
                message.Subject = "Felicitaciones por tu compra";
                message.Body = cuerpo.ToMessageBody();
                message.From.Add(new MailboxAddress("", "hola@monagua.com.ar"));
                message.To.Add(new MailboxAddress("", compra.ClientesEntity.Email));
                EnviaMail.Envia(message);

            }


            foreach (ComprasDetalle det in compra.Detalle)
            {

                if (!string.IsNullOrEmpty(det.ActividadesEntity.PrestadoresEntity.Email))
                {

                    string body = String.Empty;
                    var path = HttpContext.Current.Server.MapPath("~/Plantillas/compraPrestador.html");
                    var fileStream = System.IO.File.OpenRead(path);
                    StreamReader reader = new StreamReader(fileStream);
                    body = reader.ReadToEnd();
                    body = body.Replace("{ubicacionlogo}", ConfiguracionMapper.Instance().GetByClave("UbicacionLogo").Valor);
                    body = body.Replace("{razon}", det.ActividadesEntity.PrestadoresEntity.RazonSocial);
                    body = body.Replace("{nombre}", compra.ClientesEntity.Nombre);
                    body = body.Replace("{apellido}", compra.ClientesEntity.Apellido);
                    body = body.Replace("{email}", compra.ClientesEntity.Email);
                    body = body.Replace("{telefono}", compra.ClientesEntity.Telefono);


                    
                    string items = "";
                   
                    decimal precio = det.ActividadesEntity.PrecioOferta.HasValue ? det.ActividadesEntity.PrecioOferta.Value : det.ActividadesEntity.Precio;
                    items += "<tr><td width='260' style='padding:0px 20px;vertical-align: top' valign='top'><p style='margin-bottom: 0px;font-size: 16px;margin-bottom: 5px;'><b>" + det.ActividadesEntity.Nombre + "</b></p>" +
                        "<p style='font-size: 12px'>Cantidad: <b style='font-size: 14px;'>" + det.Cantidad + "</b></p>"+
                       "<p style='font-size: 12px'> Fecha : <b style='font-size: 14px;'>" + det.FechaHora.ToString("dd/MM/yyyy hh:mm") + "</b></p>"+
                    "</td><td width='195'  valign='top' style='text-align: right;'><p style='font-size: 18px;'><b>$ " + (det.Cantidad * precio).ToString() + ".-</b></p></td></tr><tr><td colspan='3' style=''><div style='border-bottom: 1px solid #303030;margin:20px 0px;'></div></td></tr>";

                    string strvaris = "";
                    strvaris += 
                    items = items.Replace("{variacion}", strvaris);






                    body = body.Replace("{resumen}", items);
                    body = body.Replace("{obs}", compra.Comentarios);
                    body = body.Replace("{envio}", "");
                    body = body.Replace("{pago}", "");

                    body = body.Replace("{total}", (det.Cantidad*precio).ToString("0.00"));



                    MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                    BodyBuilder cuerpo = new BodyBuilder();





                    cuerpo.HtmlBody = body;
                    message.Subject = "Compra " + compra.ClientesEntity.Apellido;
                    message.Body = cuerpo.ToMessageBody();
                    message.From.Add(new MailboxAddress("", "hola@monagua.com.ar"));
                    message.To.Add(new MailboxAddress("", det.ActividadesEntity.PrestadoresEntity.Email));
                    EnviaMail.Envia(message);

                }


                if (!string.IsNullOrEmpty(ConfiguracionMapper.Instance().GetByClave("EmailCompra").Valor))
                {

                    string body = String.Empty;
                    var path = HttpContext.Current.Server.MapPath("~/Plantillas/compraAdmin.html");
                    var fileStream = System.IO.File.OpenRead(path);
                    StreamReader reader = new StreamReader(fileStream);
                    body = reader.ReadToEnd();
                    body = body.Replace("{ubicacionlogo}", ConfiguracionMapper.Instance().GetByClave("UbicacionLogo").Valor);
                    body = body.Replace("{nombre}", compra.ClientesEntity.Nombre);
                    body = body.Replace("{apellido}", compra.ClientesEntity.Apellido);
                    body = body.Replace("{email}", compra.ClientesEntity.Email);
                    body = body.Replace("{telefono}", compra.ClientesEntity.Telefono);

                    string items = "";
                    foreach (ComprasDetalle detalle in compra.Detalle)
                    {
                        decimal precio = detalle.ActividadesEntity.PrecioOferta.HasValue ? detalle.ActividadesEntity.PrecioOferta.Value : detalle.ActividadesEntity.Precio;
                        items += "<tr><td width='260' style='padding:0px 20px;vertical-align: top' valign='top'><p style='margin-bottom: 0px;font-size: 16px;margin-bottom: 5px;'><b>" + detalle.ActividadesEntity.Nombre + "</b></p>" +
                           "<p style='font-size: 12px'>Cantidad: <b style='font-size: 14px;'>" + detalle.Cantidad + "</b></p>" +
                          "<p style='font-size: 12px'> Fecha : <b style='font-size: 14px;'>" + detalle.FechaHora.ToString("dd/MM/yyyy hh:mm") + "</b></p>" +
                        "</td><td width='195'  valign='top' style='text-align: right;'><p style='font-size: 18px;'><b>$ " + (detalle.Cantidad * precio).ToString() + ".-</b></p></td></tr><tr><td colspan='3' style=''><div style='border-bottom: 1px solid #303030;margin:20px 0px;'></div></td></tr>";

                       



                    }

                    body = body.Replace("{resumen}", items);
                    body = body.Replace("{obs}", compra.Comentarios);
                    body = body.Replace("{envio}", "");
                    body = body.Replace("{pago}", "");

                    body = body.Replace("{total}", total.ToString("0.00"));
                    

                    MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                    BodyBuilder cuerpo = new BodyBuilder();

                    cuerpo.HtmlBody = body;
                    message.Subject = "Compra " + compra.ClientesEntity.Apellido;
                    message.Body = cuerpo.ToMessageBody();
                    message.From.Add(new MailboxAddress("", "hola@monagua.com.ar"));
                    message.To.Add(new MailboxAddress("", compra.ClientesEntity.Email));
                    EnviaMail.Envia(message);

                }
            }
        }


        [Route("GetCompras")]
        [HttpGet]
        
        public IHttpActionResult GetCompras()
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                if (u.ClientesEntity != null)
                {
                    return Ok(ComprasMapper.Instance().GetcomprasByCliente(u.IdCliente.Value));
                }
                else
                {
                    return Ok(ComprasMapper.Instance().GetByPrestador(u.IdPrestador.Value));
                }
                


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        


    }
}
