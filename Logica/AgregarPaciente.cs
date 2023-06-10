using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgregarPaciente
    {
        private ConexionBD.BasesDatos Conexion = new ConexionBD.BasesDatos();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;


        // atributos paciente
        private string nombre;
        private int edad;
        private int telefono;
        private string direccion;
        private int id;

        //mtodo get paciente

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id { get => id; set => id = value; }

        public DataTable ListarPacientes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarPacientes";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public string InsertarPacientes(string nombre, string edad, string telefono, string direccion)
        {
            string mensaje;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "AgregarPaciente";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@edad", edad);
                Comando.Parameters.AddWithValue("@telefono", telefono);
                Comando.Parameters.AddWithValue("@direccion", direccion);
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
                mensaje = "Datos enviados a la base de datos";
            }
            catch(Exception ex)
            {
                mensaje = "Error" + ex.ToString();
            }
            return mensaje;
        }

        public void EliminarPaciente()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "delete pacientes where Id=" + id;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }

        public string EditaPacientes()
        {
            string mensaje;
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "update pacientes set Nombre='" + nombre + "',Edad=" + edad + ",Telefono=" + telefono + ",direccion='" + direccion + "' WHERE Id=" + id;
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
