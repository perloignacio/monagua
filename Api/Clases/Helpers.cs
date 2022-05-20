using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Api.Clases
{
    public static class Helpers
    {
        public static List<string> SubeArchivos(string ubicacion,string fotosActuales,bool borrar,HttpFileCollection archivos)
        {
            List<string> fotos = new List<string>();
           
            if (!borrar)
            {
                fotos = fotosActuales.Split(',').ToList();
            }

            

            if (archivos.Count > 0)
            {
                for (int i = 0; i <= HttpContext.Current.Request.Files.Count - 1; i++)
                {
                    string extension = Path.GetExtension(archivos[i].FileName);
                    var postedFile = HttpContext.Current.Request.Files[i];
                    string fechahora = i.ToString() + "_" + DateTime.Now.ToString("ddmmyyyyhhssff") + extension;

                    var filePath = HttpContext.Current.Server.MapPath("~/assets/"+ubicacion+"/" + fechahora);
                    postedFile.SaveAs(filePath);
                    fotos.Add(fechahora);
                }
               
            }
            return fotos;
        }
    }
}