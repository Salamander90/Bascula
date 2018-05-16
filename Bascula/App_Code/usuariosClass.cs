using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuarios
/// </summary>
namespace Bascula.App_Code
{
    public class usuariosClass
    {
        public int Id { get; set; }
        public String Usuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Status { get; set; }
        public String Contrsasena { get; set; }
        public int Rol { get; set; }
        public int AreaDesignada { get; set; }

        public usuariosClass() { }

        public usuariosClass(int pId, String pUsuario, String pNombre, string pApellido, int pStatus, String pContrasena, int pRol, int pArea)
        {
            this.Id = pId;
            this.Usuario = pUsuario;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Status = pStatus;
            this.Contrsasena = pContrasena;
            this.Rol = pRol;
            this.AreaDesignada = pArea;
        }
    }
}