using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de rolesClass
/// </summary>
namespace Bascula.App_Code
{
    public class rolesClass
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Status { get; set; }


        public rolesClass() { }

        public rolesClass(int pId, String pNombre, String pDescripcion, int pStatus)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.Status = pStatus;
        }
    }
}