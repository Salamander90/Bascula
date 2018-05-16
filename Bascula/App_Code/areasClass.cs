using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de areasClass
/// </summary>
namespace Bascula.App_Code
{
    public class areasClass
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Status { get; set; }


        public areasClass() { }

        public areasClass(int pId, String pNombre, String pDescripcion, int pStatus)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.Status = pStatus;
        }
    }
}