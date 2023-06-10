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
    public partial class Pacientes : Form
    {
        public Pacientes()
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
            pictureBox8.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == null && txtEdad.Text == null && txtTelefono.Text == null && txtDireccion.Text == null)
            {
                MessageBox.Show("Debe digitar los campos");
            }
            else
            {
                MessageBox.Show(log.InsertarPacientes(txtNombre.Text, txtEdad.Text, txtTelefono.Text, txtDireccion.Text));
                TablaPacientes.DataSource = log.ListarPacientes();
                Limpiar_form();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaPacientes.SelectedRows.Count > 0)
            {
                log.Id = Convert.ToInt32(TablaPacientes.CurrentRow.Cells[0].Value);
                log.EliminarPaciente();
                TablaPacientes.DataSource = log.ListarPacientes();
                MessageBox.Show("Se elimino satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            TablaPacientes.DataSource = log.ListarPacientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaPacientes.SelectedRows.Count > 0)
            {
                string id = TablaPacientes.CurrentRow.Cells["ID"].Value.ToString();
                txtNombre.Text = TablaPacientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = TablaPacientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEdad.Text = TablaPacientes.CurrentRow.Cells["Edad"].Value.ToString();
                txtDireccion.Text = TablaPacientes.CurrentRow.Cells["direccion"].Value.ToString();

                log.Id = Convert.ToInt32(id);
                log.Nombre = txtNombre.Text;
                log.Edad = Convert.ToInt32(txtEdad.Text);
                log.Telefono = Convert.ToInt32(txtTelefono.Text);
                log.Direccion = txtDireccion.Text;

                MessageBox.Show(log.EditaPacientes());
                TablaPacientes.DataSource = log.ListarPacientes();
                Limpiar_form();
            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
            
    }

        private void Limpiar_form()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }


    }
}
