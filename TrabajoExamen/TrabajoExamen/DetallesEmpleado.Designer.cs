/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 05/12/2025
 * Time: 03:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class DetallesEmpleado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cboPuesto = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNaci = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboSex = new System.Windows.Forms.ComboBox();
			this.btnActuallizar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo del empleado:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(132, 28);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(241, 20);
			this.txtCodigo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre del empleado:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(133, 70);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(240, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(403, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(122, 123);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Puesto:";
			// 
			// cboPuesto
			// 
			this.cboPuesto.FormattingEnabled = true;
			this.cboPuesto.Items.AddRange(new object[] {
									"Administrativo",
									"Gerente",
									"Servicios",
									"Conserje",
									"Junior"});
			this.cboPuesto.Location = new System.Drawing.Point(132, 109);
			this.cboPuesto.Name = "cboPuesto";
			this.cboPuesto.Size = new System.Drawing.Size(128, 21);
			this.cboPuesto.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Fecha de nacimiento";
			// 
			// txtNaci
			// 
			this.txtNaci.Location = new System.Drawing.Point(132, 149);
			this.txtNaci.Name = "txtNaci";
			this.txtNaci.Size = new System.Drawing.Size(128, 20);
			this.txtNaci.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Sexo:";
			// 
			// cboSex
			// 
			this.cboSex.FormattingEnabled = true;
			this.cboSex.Items.AddRange(new object[] {
									"Femenino",
									"Masculino",
									"No Binarie",
									"Prefiero No Decir"});
			this.cboSex.Location = new System.Drawing.Point(74, 184);
			this.cboSex.Name = "cboSex";
			this.cboSex.Size = new System.Drawing.Size(121, 21);
			this.cboSex.TabIndex = 10;
			// 
			// btnActuallizar
			// 
			this.btnActuallizar.Location = new System.Drawing.Point(381, 144);
			this.btnActuallizar.Name = "btnActuallizar";
			this.btnActuallizar.Size = new System.Drawing.Size(75, 23);
			this.btnActuallizar.TabIndex = 11;
			this.btnActuallizar.Text = "Actualizar";
			this.btnActuallizar.UseVisualStyleBackColor = true;
			this.btnActuallizar.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Location = new System.Drawing.Point(484, 144);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(75, 23);
			this.btnQuitar.TabIndex = 12;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.Button2Click);
			// 
			// dgvDatos
			// 
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Location = new System.Drawing.Point(13, 218);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.Size = new System.Drawing.Size(546, 97);
			this.dgvDatos.TabIndex = 13;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(298, 323);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 14;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(387, 323);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 15;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(478, 321);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 16;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(245, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Estado:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(351, 177);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 35);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(98, 6);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Cotizado";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(7, 5);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Regular";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// DetallesEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 358);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvDatos);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnActuallizar);
			this.Controls.Add(this.cboSex);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtNaci);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cboPuesto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label1);
			this.Name = "DetallesEmpleado";
			this.Text = "DetallesEmpleado";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnActuallizar;
		private System.Windows.Forms.ComboBox cboSex;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNaci;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboPuesto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
	}
}
