using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AgregarEmpleado
    {
        private ConexionBD.BasesDatos Conexion = new ConexionBD.BasesDatos();
        private SqlCommand ComandoEmp = new SqlCommand();
        private SqlDataReader LeerFilasEmp;

        //Atributo empleados
        private int idE;
        private string nombreE;
        private string cargo;
        private string area_trabajo;
        private string sexo;

        // metod get empleado
        public int IdE { get => idE; set => idE = value; }
        public string NombreE { get => nombreE; set => nombreE = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Area_trabajo { get => area_trabajo; set => area_trabajo = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public DataTable ListarEmpleados()
        {
            DataTable TablaEmp = new DataTable();
            ComandoEmp.Connection = Conexion.AbrirConexion();
            ComandoEmp.CommandText = "ListarEmpleados";
            ComandoEmp.CommandType = CommandType.StoredProcedure;
            LeerFilasEmp = ComandoEmp.ExecuteReader();
            TablaEmp.Load(LeerFilasEmp);
            LeerFilasEmp.Close();
            Conexion.CerrarConexion();
            return TablaEmp;
        }

        public string InsertarEmpleado(string nombre, string cargo, string area, string sexo)
        {
            string mensaje;
            try
            {
                ComandoEmp.Connection = Conexion.AbrirConexion();
                ComandoEmp.CommandText = "AgregarEmpleado";
                ComandoEmp.CommandType = CommandType.StoredProcedure;
                ComandoEmp.Parameters.AddWithValue("@nombre", nombre);
                ComandoEmp.Parameters.AddWithValue("@cargo", cargo);
                ComandoEmp.Parameters.AddWithValue("@area", area);
                ComandoEmp.Parameters.AddWithValue("@sexo", sexo);
                ComandoEmp.ExecuteNonQuery();
                ComandoEmp.Parameters.Clear();
                Conexion.CerrarConexion();
                mensaje = "Datos enviados a la base de datos";
            }
            catch (Exception ex)
            {
                mensaje = "Error" + ex.ToString();
            }
            return mensaje;
        }

        public string EditarEmpleado()
        {
            string mensaje;
            try
            {
                ComandoEmp.Connection = Conexion.AbrirConexion();
                ComandoEmp.CommandText = "update empleados set Nombre='" + nombreE + "',Cargo='" + cargo + "',Area_trabajo='" + area_trabajo + "',sexo='" + sexo + "' WHERE Id=" + idE;
                ComandoEmp.CommandType = CommandType.Text;
                ComandoEmp.ExecuteNonQuery();
                Conexion.CerrarConexion();
                mensaje = "Datos editados correctamente";
            }
            catch (Exception ex)
            {
                mensaje="Error: " + ex.ToString();
            }
            return mensaje;
        }

        public void EliminarEmpleado()
        {
            ComandoEmp.Connection = Conexion.AbrirConexion();
            ComandoEmp.CommandText = "delete empleados where Id=" + idE;
            ComandoEmp.CommandType = CommandType.Text;
            ComandoEmp.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
    }
}
