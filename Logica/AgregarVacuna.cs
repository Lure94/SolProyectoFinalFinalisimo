using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgregarVacuna
    {
        private ConexionBD.BasesDatos Conexion = new ConexionBD.BasesDatos();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //atributos vacuna
        string nombre;
        string tipo;
        int dosis;
        string fecha;
        int edadPaciente;
        string descripcion;
        string efectosSec;
        int IdV;

        //properties
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Dosis { get => dosis; set => dosis = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int EdadPaciente { get => edadPaciente; set => edadPaciente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string EfectosSec { get => efectosSec; set => efectosSec = value; }
        public int IdV1 { get => IdV; set => IdV = value; }

        public DataTable ListarVacunas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarVacunas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public string InsertarVacunas(string nombre, string tipo, int dosis, string Fecha_ven, int edad, string descripcion, string efectos)
        {
            string mensaje;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarVacunas";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Nombre", nombre);
                Comando.Parameters.AddWithValue("@Tipo", tipo);
                Comando.Parameters.AddWithValue("@Dosis", dosis);
                Comando.Parameters.AddWithValue("@Fecha_ven", Fecha_ven);
                Comando.Parameters.AddWithValue("@Edad_paciente", edad);
                Comando.Parameters.AddWithValue("@descripcion", descripcion);
                Comando.Parameters.AddWithValue("@Efectos_secun", efectos);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
                mensaje = "Datos enviados a la base de datos";
            }
            catch (Exception ex)
            {
                mensaje = "Error" + ex.ToString();
            }
            return mensaje;
        }

        public void EliminarVacuna()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete vacunas where Id=" + IdV;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }

        public string EditarVacunas()
        {
            string mensaje;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "update vacunas set Nombre='" + nombre + "',Tipo=" + tipo + ",Dosis=" + dosis + ",Fecha_ven='" + fecha + ",Edad_paciente='"+ edadPaciente +",descripcion='"+ descripcion+ ",Efectos_secun='"+ efectosSec +"' WHERE Id=" + IdV;
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                Conexion.CerrarConexion();
                mensaje = "Datos editados con Exito";
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.ToString();
            }
            return mensaje;
        }

    }
}
