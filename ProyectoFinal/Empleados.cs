using ConexionBD;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Empleados : Form
    {

        string sex;
        public Empleados()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox4.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbtnMas.Checked)
            {
                sex = "M";
            }
            else
            {
                sex = "F";
            }

            if (txtNombre.Text == null && txtCargo.Text == null && txtArea.Text == null)
            {
                MessageBox.Show("Debe digitar los campos");
            }
            else
            {
                MessageBox.Show(logEmp.InsertarEmpleado(txtNombre.Text, txtCargo.Text, txtArea.Text, sex));
                TablaEmpleados.DataSource = logEmp.ListarEmpleados();
                Limpiar_form();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaEmpleados.SelectedRows.Count > 0)
            {
                string id = TablaEmpleados.CurrentRow.Cells["ID"].Value.ToString();
                txtNombre.Text = TablaEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCargo.Text = TablaEmpleados.CurrentRow.Cells["Cargo"].Value.ToString();
                txtArea.Text = TablaEmpleados.CurrentRow.Cells["Area_Trabajo"].Value.ToString();

                logEmp.IdE = Convert.ToInt32(id);
                logEmp.NombreE = txtNombre.Text;
                logEmp.Cargo = txtCargo.Text;
                logEmp.Area_trabajo = txtArea.Text;
                logEmp.Sexo = sex;

                MessageBox.Show(logEmp.EditarEmpleado());
                TablaEmpleados.DataSource = logEmp.ListarEmpleados();
                Limpiar_form();
            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaEmpleados.SelectedRows.Count > 0)
            {
                logEmp.IdE = Convert.ToInt32(TablaEmpleados.CurrentRow.Cells[0].Value);
                logEmp.EliminarEmpleado();
                TablaEmpleados.DataSource = logEmp.ListarEmpleados();
                MessageBox.Show("Se elimino satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            TablaEmpleados.DataSource = logEmp.ListarEmpleados();
        }

        private void Limpiar_form()
        {
            txtNombre.Clear();
            txtCargo.Clear();
            txtArea.Clear();
        }

       
    }
}
