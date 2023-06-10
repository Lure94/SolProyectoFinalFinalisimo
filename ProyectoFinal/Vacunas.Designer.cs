namespace ProyectoFinal
{
    partial class Vacunas
    {
        Logica.AgregarVacuna logVac = new Logica.AgregarVacuna();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNombre = new TextBox();
            txtDosis = new TextBox();
            Fecha = new DateTimePicker();
            txtEdadPac = new TextBox();
            txtDesc = new TextBox();
            txtEfecSec = new TextBox();
            TablaVacuna = new DataGridView();
            groupBox1 = new GroupBox();
            btnMostrar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtTipo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TablaVacuna).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Fondo3_Image;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(933, 519);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Imagen5_Image;
            pictureBox2.Location = new Point(0, 43);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Imagen6_Image;
            pictureBox3.Location = new Point(0, 204);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 157);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox9);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 40);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(380, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 24);
            label1.TabIndex = 21;
            label1.Text = "VACUNAS";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pictureBox7_Image;
            pictureBox7.ImeMode = ImeMode.NoControl;
            pictureBox7.Location = new Point(792, -1);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(47, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.pictureBox4_Image;
            pictureBox8.ImeMode = ImeMode.NoControl;
            pictureBox8.Location = new Point(840, -1);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 40);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 19;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.pictureBox3_Image;
            pictureBox9.ImeMode = ImeMode.NoControl;
            pictureBox9.Location = new Point(887, 0);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(47, 40);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 20;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Imagen7_Image;
            pictureBox4.Location = new Point(0, 361);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(189, 158);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 20;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(229, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 21;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(229, 129);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 22;
            label4.Text = "Dosis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(229, 163);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(185, 18);
            label5.TabIndex = 23;
            label5.Text = "fecha de Vencimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(229, 197);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 18);
            label6.TabIndex = 24;
            label6.Text = "Edad del paciente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(229, 230);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(144, 18);
            label7.TabIndex = 25;
            label7.Text = "Descripcion Vac:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(229, 263);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(177, 18);
            label8.TabIndex = 26;
            label8.Text = "Efectos secundarios:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(531, 65);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(294, 23);
            txtNombre.TabIndex = 27;
            // 
            // txtDosis
            // 
            txtDosis.Location = new Point(531, 130);
            txtDosis.Margin = new Padding(4, 3, 4, 3);
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new Size(294, 23);
            txtDosis.TabIndex = 28;
            // 
            // Fecha
            // 
            Fecha.Location = new Point(531, 163);
            Fecha.Margin = new Padding(4, 3, 4, 3);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(294, 23);
            Fecha.TabIndex = 30;
            // 
            // txtEdadPac
            // 
            txtEdadPac.Location = new Point(531, 198);
            txtEdadPac.Margin = new Padding(4, 3, 4, 3);
            txtEdadPac.Name = "txtEdadPac";
            txtEdadPac.Size = new Size(294, 23);
            txtEdadPac.TabIndex = 31;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(531, 230);
            txtDesc.Margin = new Padding(4, 3, 4, 3);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(294, 23);
            txtDesc.TabIndex = 32;
            // 
            // txtEfecSec
            // 
            txtEfecSec.Location = new Point(531, 264);
            txtEfecSec.Margin = new Padding(4, 3, 4, 3);
            txtEfecSec.Name = "txtEfecSec";
            txtEfecSec.Size = new Size(294, 23);
            txtEfecSec.TabIndex = 33;
            // 
            // TablaVacuna
            // 
            TablaVacuna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaVacuna.Location = new Point(232, 323);
            TablaVacuna.Margin = new Padding(4, 3, 4, 3);
            TablaVacuna.Name = "TablaVacuna";
            TablaVacuna.Size = new Size(594, 111);
            TablaVacuna.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMostrar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(this.btnGuardar);
            groupBox1.Location = new Point(232, 441);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(594, 74);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Botones";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(434, 22);
            btnMostrar.Margin = new Padding(4, 3, 4, 3);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(153, 27);
            btnMostrar.TabIndex = 31;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(300, 24);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 27);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(145, 24);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(146, 27);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new Point(8, 24);
            this.btnGuardar.Margin = new Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(130, 27);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += this.btnGuardar_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(531, 97);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(294, 23);
            txtTipo.TabIndex = 32;
            // 
            // Vacunas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(txtTipo);
            Controls.Add(groupBox1);
            Controls.Add(TablaVacuna);
            Controls.Add(txtEfecSec);
            Controls.Add(txtDesc);
            Controls.Add(txtEdadPac);
            Controls.Add(Fecha);
            Controls.Add(txtDosis);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Vacunas";
            Text = "Vacunas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)TablaVacuna).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtDosis;
        private DateTimePicker Fecha;
        private TextBox txtEdadPac;
        private TextBox txtDesc;
        private TextBox txtEfecSec;
        private DataGridView TablaVacuna;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn expiracion;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn efectos;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnMostrar;
        private TextBox txtTipo;
    }
}