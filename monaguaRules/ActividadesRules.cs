using monaguaRules.Entities;
using monaguaRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monaguaRules
{
    public  class ActividadesRules
    {
        public Actividades Agregar(string nombre, string descripcioCorta,string descripcion,decimal precio,decimal duracion, int idcategoria,int idprestador,string fotos,string video,string ubicacion, string mapa,decimal? precioOferta,bool mascotas,bool personasCapacidadRed,bool dietas,string idiomas,string dificultad,string incluye, string noincluye,int diasCancelacion, int idlocalidad,int idprovincia)
        {
            validar(nombre,descripcioCorta,descripcion,precio,duracion,idcategoria,idprestador);
            Actividades ac = new Actividades();
            ac.Activa = true;
            ac.Nombre = nombre;
            ac.DescripcionCorta = descripcioCorta;
            ac.Descripcion = descripcion;
            ac.Precio = precio;
            ac.Duracion = duracion;
            ac.IdCategoria = idcategoria;
            ac.IdPrestador = idprestador;
            ac.Fotos = fotos;
            ac.Video = video;
            ac.Ubicacion = ubicacion;
            ac.Mapa = mapa;
            if (precioOferta.HasValue)
            {
                ac.PrecioOferta = precioOferta.Value;
            }
            ac.Mascotas = mascotas;
            ac.PersonasCapacidadRed = personasCapacidadRed;
            ac.DietasEspeciales = dietas;
            ac.Idiomas = idiomas;
            ac.Dificultad = dificultad;
            ac.QueIncluye = incluye;
            ac.QueNoIncluye = noincluye;
            ac.DiasCancelacion = diasCancelacion;
           
            ac.IdLocalidad = idlocalidad;
            ac.IdProvincia = idprovincia;
            
            ActividadesMapper.Instance().Insert(ac);
            return ac;
        }

        public void Modificar(int idactividad,string nombre, string descripcioCorta, string descripcion, decimal precio, decimal duracion, int idcategoria, int idprestador, string fotos, string video, string ubicacion, string mapa, decimal? precioOferta, bool mascotas, bool personasCapacidadRed, bool dietas, string idiomas, string dificultad, string incluye, string noincluye, int diasCancelacion,int idlocalidad,int idprovincia)
        {
            validar(nombre, descripcioCorta, descripcion, precio, duracion, idcategoria, idprestador);
            Actividades ac = ActividadesMapper.Instance().GetOne(idactividad);
            if (ac == null)
            {
                throw new Exception("No se encuentra la actividad");
            }
            
            ac.Nombre = nombre;
            ac.DescripcionCorta = descripcioCorta;
            ac.Descripcion = descripcion;
            ac.Precio = precio;
            ac.Duracion = duracion;
            ac.IdCategoria = idcategoria;
            ac.IdPrestador = idprestador;
            ac.Fotos = fotos;
            ac.Video = video;
            ac.Ubicacion = ubicacion;
            ac.Mapa = mapa;
            if (precioOferta.HasValue)
            {
                ac.PrecioOferta = precioOferta.Value;
            }
            ac.Mascotas = mascotas;
            ac.PersonasCapacidadRed = personasCapacidadRed;
            ac.DietasEspeciales = dietas;
            ac.Idiomas = idiomas;
            ac.Dificultad = dificultad;
            ac.QueIncluye = incluye;
            ac.QueNoIncluye = noincluye;
            ac.DiasCancelacion = diasCancelacion;
            
            ac.IdLocalidad = idlocalidad;
            ac.IdProvincia = idprovincia;
            ActividadesMapper.Instance().Save(ac);
            
        }

        public void Borrar(int idactividad )
        {
            
            Actividades ac = ActividadesMapper.Instance().GetOne(idactividad);
            if (ac == null)
            {
                throw new Exception("No se encuentra la actividad");
            }
            ac.Activa = false;
            

            ActividadesMapper.Instance().Save(ac);

        }

        public void Activar(int idactividad )
        {
            
            Actividades ac = ActividadesMapper.Instance().GetOne(idactividad);
            if (ac == null)
            {
                throw new Exception("No se encuentra la actividad");
            }
            ac.Activa = true;


            ActividadesMapper.Instance().Save(ac);

        }
        public void validar(string nombre, string descripcioCorta, string descripcion,decimal precio, decimal duracion, int idcategoria, int idprestador)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el nombre");
            }
            if (string.IsNullOrEmpty(descripcioCorta))
            {
                throw new Exception("Ingrese una breve descripción");
            }
            if (string.IsNullOrEmpty(descripcion))
            {
                throw new Exception("Ingrese una descripción");
            }
            if (precio <= 0)
            {
                throw new Exception("Ingrese un precio válido");
            }
            if (duracion <= 0)
            {
                throw new Exception("Ingrese una duracion valida, debe ser expresada en horas");
            }
            if (CategoriasMapper.Instance().GetOne(idcategoria) == null)
            {
                throw new Exception("Ingrese una categoria válida");
            }
            if (PrestadoresMapper.Instance().GetOne(idprestador) == null)
            {
                throw new Exception("Ingrese un prestador de servicio válido");
            }
        }

        public void AgregarHorario(int idactividad,int idtiporepeticion,DateTime fechaInicio,DateTime horadesde, DateTime horahasta,DateTime? fechaFin,int? capacidad)
        {
            validarHora(idactividad,idtiporepeticion,fechaInicio,horadesde,horahasta);
            ActividadesHorarios ah = new ActividadesHorarios();
            ah.Activa = true;
            ah.IdActividad = idactividad;
            ah.IdTipoRepeticion = idtiporepeticion;
            ah.FechaInicio = fechaInicio;
            ah.HoraDesde = horadesde;
            ah.HoraHasta = horahasta;
            if (fechaFin.HasValue)
            {
                ah.FechaFin = fechaFin.Value;
            }
            if (capacidad.HasValue)
            {
                ah.Capacidad = capacidad.Value;
            }
            ActividadesHorariosMapper.Instance().Insert(ah);


        }

        public void BorrarHorario(int idhorario)
        {

            ActividadesHorarios ah = ActividadesHorariosMapper.Instance().GetOne(idhorario);
            if (ah == null)
            {
                throw new Exception("No se encuentra el horario");
            }
            ah.Activa = false;
            
            ActividadesHorariosMapper.Instance().Save(ah);


        }

        public void BorrarUnHorario(int idhorario,DateTime fecha)
        {

            ActividadesHorariosExcepcion ahe = new ActividadesHorariosExcepcion();
            ahe.IdHorario = idhorario;
            ahe.Eliminar = true;
            ahe.Fecha = fecha;
            ActividadesHorariosExcepcionMapper.Instance().Insert(ahe);

        }

        public void BorrarSiguientes(int idhorario,DateTime fechahasta)
        {
            ActividadesHorarios ah = ActividadesHorariosMapper.Instance().GetOne(idhorario);
            if (ah == null)
            {
                throw new Exception("No se encuentra el horario");
            }
            ah.FechaFin = fechahasta;
            ActividadesHorariosMapper.Instance().Save(ah);


        }


        public void ModificarHorario(int idhorario,int idtiporepeticion,int? capacidad,DateTime fechaInicio,DateTime horadesde, DateTime horahasta)
        {

            ActividadesHorarios ah = ActividadesHorariosMapper.Instance().GetOne(idhorario);
            if (ah == null)
            {
                throw new Exception("No se encuentra el horario");
            }
            validarHora(ah.IdActividad, idtiporepeticion, fechaInicio, horadesde, horahasta);
            ah.IdTipoRepeticion = idtiporepeticion;
            ah.FechaInicio = fechaInicio;
            ah.HoraDesde = horadesde;
            ah.HoraHasta = horahasta;
            if (capacidad.HasValue)
            {
                ah.Capacidad = capacidad.Value;
            }
            ActividadesHorariosMapper.Instance().Save(ah);


        }

        public void ModificarUnHorario(int idhorario,int? capacidad, DateTime fecha, DateTime horadesde, DateTime horahasta)
        {

            ActividadesHorariosExcepcion ahe = new ActividadesHorariosExcepcion();
            ahe.IdHorario = idhorario;
            ahe.HoraDesde = horadesde;
            ahe.HoraHasta = horahasta;
            ahe.Fecha = fecha;
            if (capacidad.HasValue)
            {
                ahe.Capacidad = capacidad;
            }

            ahe.Eliminar = false;
            ActividadesHorariosExcepcionMapper.Instance().Insert(ahe);

        }

        public void ModificarSiguientes(int idhorario, DateTime fechahasta, int idtiporepeticion,int? capacidad, DateTime fechaInicio, DateTime horadesde, DateTime horahasta)
        {
            ActividadesHorarios ah = ActividadesHorariosMapper.Instance().GetOne(idhorario);
            if (ah == null)
            {
                throw new Exception("No se encuentra el horario");
            }
            ah.FechaFin = fechahasta;
            ActividadesHorariosMapper.Instance().Save(ah);

            validarHora(ah.IdActividad, idtiporepeticion, fechaInicio, horadesde, horahasta);

            ActividadesHorarios newah =new ActividadesHorarios();
            newah.IdTipoRepeticion = idtiporepeticion;
            newah.FechaInicio = fechaInicio;
            newah.HoraDesde = horadesde;
            newah.HoraHasta = horahasta;
            if (capacidad.HasValue)
            {
                newah.Capacidad = capacidad.Value;
            }
            newah.Activa = true;
            newah.IdActividad = ah.IdActividad;

            ActividadesHorariosMapper.Instance().Insert(newah);
        }

        public void validarHora(int idactividad, int idtiporepeticion, DateTime fechaInicio, DateTime horadesde, DateTime horahasta)
        {
            if (ActividadesMapper.Instance().GetOne(idactividad) == null)
            {
                throw new Exception("No se encuentra la actividad");
            }

            if (TipoRepeticionesMapper.Instance().GetOne(idtiporepeticion) == null)
            {
                throw new Exception("No se encuentra el tipo de repetición");
            }

            if (fechaInicio.Date < DateTime.Now.Date)
            {
                throw new Exception("No se puede cargar un horario menor a hoy");
            }
            if (horadesde > horahasta)
            {
                throw new Exception("La hora desde no puede ser mayor a la hora hasta");
            }

        }

        public List<ActividadesHorarios> ConfiguraHorarios(int idactividad,bool validacompras)
        {
            
            List<ActividadesHorarios> horarios = new List<ActividadesHorarios>();
            ActividadesHorariosList lista = ActividadesHorariosMapper.Instance().GetByActividades(idactividad);
            Random r = new Random();
            foreach (var item in lista.Where(h => h.Activa))
            {
                if (item.IdTipoRepeticion == 1)
                {
                    ActividadesHorarios h = new ActividadesHorarios();
                    h.FechaInicio = new DateTime(item.FechaInicio.Year, item.FechaInicio.Month, item.FechaInicio.Day, item.HoraDesde.Hour, item.HoraDesde.Minute, item.HoraDesde.Second);
                    h.FechaFin = new DateTime(item.FechaInicio.Year, item.FechaInicio.Month, item.FechaInicio.Day, item.HoraHasta.Hour, item.HoraHasta.Minute, item.HoraHasta.Second);
                    h.id = item.IdHorario;
                    h.Capacidad = item.Capacidad;
                    h.HoraDesde = item.HoraDesde;
                    h.HoraHasta=item.HoraHasta;
                    h.IdTipoRepeticion = item.IdTipoRepeticion;
                    h.TipoRepeticionesEntity = item.TipoRepeticionesEntity;
                    h.ActividadesEntity = item.ActividadesEntity;
                    h.idCalendar = r.Next(1, 1000000); ;
                    horarios.Add(h);
                }

                if (item.IdTipoRepeticion == 2)
                {
                    DateTime inicio = item.FechaInicio;
                    DateTime fin;
                    if (inicio < DateTime.Now) { 
                        inicio = DateTime.Now; 
                    }
                   
                    if (item.FechaFin.HasValue) { 
                        fin = item.FechaFin.Value; 
                    } else {
                        fin = inicio.AddMonths(int.Parse(ConfiguracionMapper.Instance().GetByClave("MesesFuturasCompras").Valor));
                    }

                    while (inicio<fin)   
                    {
                        ActividadesHorarios h = new ActividadesHorarios();
                        h.FechaInicio = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraDesde.Hour, item.HoraDesde.Minute, item.HoraDesde.Second);
                        
                        h.FechaFin = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraHasta.Hour, item.HoraHasta.Minute, item.HoraHasta.Second);

                        h.id = item.IdHorario;
                        h.Capacidad = item.Capacidad;
                        h.HoraDesde = item.HoraDesde;
                        h.HoraHasta = item.HoraHasta;
                        h.IdTipoRepeticion = item.IdTipoRepeticion;
                        h.TipoRepeticionesEntity = item.TipoRepeticionesEntity;
                        h.ActividadesEntity = item.ActividadesEntity;
                        h.idCalendar = r.Next(1, 1000000);
                        inicio =inicio.AddDays(1);
                        horarios.Add(h);
                    }
                    
                }

                if (item.IdTipoRepeticion == 3)
                {
                    DateTime inicio = item.FechaInicio;
                    DayOfWeek dia = item.FechaInicio.DayOfWeek;
                    if (inicio < DateTime.Now)
                    {
                        inicio = this.GetNextWeekday(DateTime.Now, dia);
                    }
                    DateTime fin;
                   
                    if (item.FechaFin.HasValue)
                    {
                        fin = item.FechaFin.Value;
                    }
                    else
                    {
                        fin = inicio.AddMonths(int.Parse(ConfiguracionMapper.Instance().GetByClave("MesesFuturasCompras").Valor));
                    }

                    while (inicio < fin)
                    {
                        ActividadesHorarios h = new ActividadesHorarios();
                        h.FechaInicio = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraDesde.Hour, item.HoraDesde.Minute, item.HoraDesde.Second);

                        h.FechaFin = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraHasta.Hour, item.HoraHasta.Minute, item.HoraHasta.Second);
                        h.id = item.IdHorario;
                        h.Capacidad = item.Capacidad;
                        h.HoraDesde = item.HoraDesde;
                        h.HoraHasta = item.HoraHasta;
                        h.IdTipoRepeticion = item.IdTipoRepeticion;
                        h.TipoRepeticionesEntity = item.TipoRepeticionesEntity;
                        h.ActividadesEntity = item.ActividadesEntity;
                        h.idCalendar = r.Next(1, 1000000);
                        horarios.Add(h);
                        inicio=inicio.AddDays(7);
                    }

                }

                if (item.IdTipoRepeticion == 5)
                {
                    DateTime inicio = item.FechaInicio;
                    DayOfWeek dia = item.FechaInicio.DayOfWeek;
                    if (inicio < DateTime.Now)
                    {
                        inicio = DateTime.Now;
                    }
                    DateTime fin;

                    if (item.FechaFin.HasValue)
                    {
                        fin = item.FechaFin.Value;
                    }
                    else
                    {
                        fin = inicio.AddMonths(int.Parse(ConfiguracionMapper.Instance().GetByClave("MesesFuturasCompras").Valor));
                    }

                    while (inicio < fin)
                    {
                        if(inicio.DayOfWeek!=DayOfWeek.Saturday && inicio.DayOfWeek != DayOfWeek.Sunday)
                        {
                            ActividadesHorarios h = new ActividadesHorarios();
                            h.FechaInicio = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraDesde.Hour, item.HoraDesde.Minute, item.HoraDesde.Second);

                            h.FechaFin = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraHasta.Hour, item.HoraHasta.Minute, item.HoraHasta.Second);
                            h.id = item.IdHorario;
                            h.Capacidad = item.Capacidad;
                            h.HoraDesde = item.HoraDesde;
                            h.HoraHasta = item.HoraHasta;
                            h.IdTipoRepeticion = item.IdTipoRepeticion;
                            h.TipoRepeticionesEntity = item.TipoRepeticionesEntity;
                            h.ActividadesEntity = item.ActividadesEntity;
                            h.idCalendar = r.Next(1, 1000000);
                            horarios.Add(h);
                        }
                        
                        inicio=inicio.AddDays(1);
                    }

                }


                if (item.IdTipoRepeticion == 6)
                {
                    DateTime inicio = item.FechaInicio;
                    DayOfWeek dia = item.FechaInicio.DayOfWeek;
                    if (inicio < DateTime.Now)
                    {
                        inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, inicio.Day);
                    }
                    DateTime fin;

                    if (item.FechaFin.HasValue)
                    {
                        fin = item.FechaFin.Value;
                    }
                    else
                    {
                        fin = inicio.AddMonths(int.Parse(ConfiguracionMapper.Instance().GetByClave("MesesFuturasCompras").Valor));
                    }

                    while (inicio < fin)
                    {

                        ActividadesHorarios h = new ActividadesHorarios();
                        h.FechaInicio = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraDesde.Hour, item.HoraDesde.Minute, item.HoraDesde.Second);

                        h.FechaFin = new DateTime(inicio.Year, inicio.Month, inicio.Day, item.HoraHasta.Hour, item.HoraHasta.Minute, item.HoraHasta.Second);
                        h.id = item.IdHorario;
                        h.Capacidad = item.Capacidad;
                        h.HoraDesde = item.HoraDesde;
                        h.HoraHasta = item.HoraHasta;
                        h.IdTipoRepeticion = item.IdTipoRepeticion;
                        h.TipoRepeticionesEntity = item.TipoRepeticionesEntity;
                        h.ActividadesEntity = item.ActividadesEntity;
                       
                        h.idCalendar = r.Next(1, 1000000);
                        horarios.Add(h);
                       

                        inicio=inicio.AddMonths(1);
                    }

                }
            }

            List<int> pos = new List<int>();
            int i = 0;
            foreach (var item in horarios)
            {
                ActividadesHorariosExcepcionList hexList = ActividadesHorariosExcepcionMapper.Instance().GetByActividadesHorarios(item.id);
                if (hexList.Count > 0)
                {
                    var ex = hexList.FindLast(e => e.Fecha.Value.Date == item.FechaInicio.Date);
                    if (ex != null)
                    {
                        if (!ex.Eliminar)
                        {
                            item.FechaInicio = ex.HoraDesde.Value;
                            item.FechaFin = ex.HoraHasta.Value;
                            item.HoraDesde = ex.HoraDesde.Value;
                            item.HoraHasta = ex.HoraHasta.Value;
                            item.Capacidad = ex.Capacidad;
                        }
                        else
                        {
                            pos.Add(i);
                        }
                        
                        
                    }
                }
                i++;
            }

            if (validacompras)
            {
                ComprasDetalleList compras = ComprasDetalleMapper.Instance().GetComprasByActividad(idactividad);
                foreach (var cd in compras)
                {
                    var index = horarios.FindIndex(h => h.FechaInicio == cd.FechaHora);
                    if (index != -1)
                    {
                        if (cd.Cantidad >= horarios[index].Capacidad)
                        {
                            horarios.Remove(horarios[index]);
                        }
                        else
                        {
                            horarios[index].Capacidad = horarios[index].Capacidad - cd.Cantidad;
                        }
                    }
                }
            }   

            if (pos.Count > 0)
            {
                foreach (var quitar in pos)
                {
                    horarios.RemoveAt(quitar);
                }
                
            }

            return horarios;
        }
        public  DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }
    }
}
