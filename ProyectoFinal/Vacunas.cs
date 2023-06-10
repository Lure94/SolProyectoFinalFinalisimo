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
    public partial class Vacunas : Form
    {
        public Vacunas()
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
            if (txtNombre.Text == null && txtTipo.Text == null && txtDesc.Text == null && txtDosis.Text == null && txtEdadPac.Text == null && txtEfecSec.Text == null)
            {
                MessageBox.Show("Debe digitar los campos");
            }
            else
            {
                MessageBox.Show(logVac.InsertarVacunas(txtNombre.Text, txtTipo.Text, int.Parse(txtDosis.Text), Fecha.Text, int.Parse(txtEdadPac.Text), txtDesc.Text, txtEfecSec.Text));
                TablaVacuna.DataSource = logVac.ListarVacunas();
                Limpiar_form();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaVacuna.SelectedRows.Count > 0)
            {
                string id = TablaVacuna.CurrentRow.Cells["ID"].Value.ToString();
                txtNombre.Text = TablaVacuna.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTipo.Text = TablaVacuna.CurrentRow.Cells["Tipo"].Value.ToString();
                txtDosis.Text = TablaVacuna.CurrentRow.Cells["Dosis"].Value.ToString();
                Fecha.Text = TablaVacuna.CurrentRow.Cells["Fecha_ven"].Value.ToString();
                txtEdadPac.Text = TablaVacuna.CurrentRow.Cells["Edad_paciente"].Value.ToString();
                txtDesc.Text = TablaVacuna.CurrentRow.Cells["descripcion"].Value.ToString();
                txtEfecSec.Text = TablaVacuna.CurrentRow.Cells["Efectos_secun"].Value.ToString();

                logVac.IdV1 = Convert.ToInt32(id);
                logVac.Nombre = txtNombre.Text;
                logVac.Tipo = txtTipo.Text;
                logVac.Dosis = Convert.ToInt32(txtDosis.Text);
                logVac.Fecha = Fecha.Text;
                logVac.EdadPaciente = Convert.ToInt32(txtEdadPac.Text);
                logVac.Descripcion = txtDesc.Text;
                logVac.EfectosSec = txtEfecSec.Text;

                MessageBox.Show(logVac.EditarVacunas());
                TablaVacuna.DataSource = logVac.ListarVacunas();
                Limpiar_form();
            }
            else
            {
                MessageBox.Show("debe seleccionar una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaVacuna.SelectedRows.Count > 0)
            {
                logVac.IdV1 = Convert.ToInt32(TablaVacuna.CurrentRow.Cells[0].Value);
                logVac.EliminarVacuna();
                TablaVacuna.DataSource = logVac.ListarVacunas();
                MessageBox.Show("Se elimino satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            TablaVacuna.DataSource = logVac.ListarVacunas();
        }

        private void Limpiar_form()
        {
            txtNombre.Clear();
            txtTipo.Clear();
            txtDesc.Clear();
            txtDosis.Clear();
            txtEdadPac.Clear();
            txtEfecSec.Clear();
        }
    }
}
