using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Data;

/// <summary>
/// Descripción breve de SQLHelper
/// </summary>
namespace Bascula.App_Code
{

    public class SQLHelper
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        public static string ObtenerMD5(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }


        //Conexion MySQL
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Seguridad  ; Uid=root; pwd=Ocarina17;");

            conectar.Open();
            return conectar;
        }

        //Mantenimiento de Usuarios
        public static DataTable getRoles()
        {
            DataTable dtReturn = new DataTable();
            MySqlCommand cmd = new MySqlCommand(String.Format("Select id_Rol, nombre_rol from roles where status_rol = 1"), ObtenerConexion());
            cmd.ExecuteNonQuery();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtReturn);
            return dtReturn;
        }

        public static DataTable getAreas()
        {
            DataTable dtReturn = new DataTable();
            MySqlCommand cmd = new MySqlCommand(String.Format("Select id_Area, nombre_area from areas where status_area = 1"), ObtenerConexion());
            cmd.ExecuteNonQuery();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtReturn);
            return dtReturn;
        }

        public static int saveUsers(usuariosClass pUsuarios)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios (usuario_user,nombre_user, apellido_user,status_user,contraseña_user,area_user,rol_user) " +
                                                                            "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                pUsuarios.Usuario, pUsuarios.Nombre, pUsuarios.Apellido, pUsuarios.Status, pUsuarios.Contrsasena, pUsuarios.AreaDesignada, pUsuarios.Rol), ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Mantenimiento de Productos
        public static int saveProducts(productoClass pProductos)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into productos (nombre_producto, descripcion_producto,peso_producto,status_producto) " +
                                                                            "values ('{0}','{1}','{2}','{3}')",
                pProductos.Nombre, pProductos.Descripcion, pProductos.Peso), ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Mantenimiento de Roles
        public static int saveRol(rolesClass pRoles)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into roles (nombre_rol, descripcion_rol,status_rol) " +
                                                                            "values ('{0}','{1}','{2}')",
                pRoles.Nombre, pRoles.Descripcion, pRoles.Status), ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Mantenimiento de Roles
        public static int saveAreas(areasClass pAreas)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into roles (nombre_area, descripcion_area,status_area ) " +
                                                                            "values ('{0}','{1}','{2}')",
                pAreas.Nombre, pAreas.Descripcion, pAreas.Status), ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}