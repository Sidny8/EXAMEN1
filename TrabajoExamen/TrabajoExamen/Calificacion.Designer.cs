/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 08/12/2025
 * Hora: 05:29 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TrabajoExamen
{
	partial class Calificacion
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
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.cboespecialidad = new System.Windows.Forms.ComboBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbosemestre = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cboasignatura = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtfecha = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnregistrar = new System.Windows.Forms.Button();
			this.btncancelar = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label10 = new System.Windows.Forms.Label();
			this.txtpromediogral = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(335, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "BOLETA DE CALIFICACIONES";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre del Alumno:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(164, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Especialidad:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(315, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Parcial 1";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(451, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Parcial 2";
			// 
			// txtnombre
			// 
			this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtnombre.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(30, 42);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(100, 21);
			this.txtnombre.TabIndex = 13;
			// 
			// cboespecialidad
			// 
			this.cboespecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.cboespecialidad.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboespecialidad.FormattingEnabled = true;
			this.cboespecialidad.Items.AddRange(new object[] {
									"Programación",
									"Soporte",
									"Administración ",
									"Alimentos",
									"Ciberseguridad ",
									"Ofimática",
									"Mecánica "});
			this.cboespecialidad.Location = new System.Drawing.Point(154, 43);
			this.cboespecialidad.Name = "cboespecialidad";
			this.cboespecialidad.Size = new System.Drawing.Size(121, 24);
			this.cboespecialidad.TabIndex = 19;
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txt1.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt1.Location = new System.Drawing.Point(315, 44);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 21);
			this.txt1.TabIndex = 20;
			this.txt1.TextChanged += new System.EventHandler(this.Txt1TextChanged);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txt2.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt2.Location = new System.Drawing.Point(435, 44);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 21);
			this.txt2.TabIndex = 21;
			this.txt2.TextChanged += new System.EventHandler(this.Txt2TextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(36, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "Semestre:";
			// 
			// cbosemestre
			// 
			this.cbosemestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.cbosemestre.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbosemestre.FormattingEnabled = true;
			this.cbosemestre.Items.AddRange(new object[] {
									"Primer Semestre",
									"Tercer Semestre",
									"Quinto Semestre"});
			this.cbosemestre.Location = new System.Drawing.Point(15, 113);
			this.cbosemestre.Name = "cbosemestre";
			this.cbosemestre.Size = new System.Drawing.Size(121, 24);
			this.cbosemestre.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(164, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(191, 23);
			this.label8.TabIndex = 24;
			this.label8.Text = "Asignatura o Submódulo:";
			// 
			// cboasignatura
			// 
			this.cboasignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.cboasignatura.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboasignatura.FormattingEnabled = true;
			this.cboasignatura.Items.AddRange(new object[] {
									"Pensamiento Matemático",
									"Lengua y Communicación ",
									"Ecosistemas interacciones energía y dinámica",
									"Humanidades",
									"Inglés",
									"Socioemocional",
									"Metodologías Ágiles",
									"Emplea frameworks para el desarrollo de software "});
			this.cboasignatura.Location = new System.Drawing.Point(193, 113);
			this.cboasignatura.Name = "cboasignatura";
			this.cboasignatura.Size = new System.Drawing.Size(121, 24);
			this.cboasignatura.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(385, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "Parcial 3";
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txt3.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt3.Location = new System.Drawing.Point(371, 112);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(100, 21);
			this.txt3.TabIndex = 27;
			this.txt3.TextChanged += new System.EventHandler(this.Txt3TextChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(96, 163);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 23);
			this.label9.TabIndex = 28;
			this.label9.Text = "Fecha Actual:";
			// 
			// txtfecha
			// 
			this.txtfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtfecha.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtfecha.Location = new System.Drawing.Point(227, 160);
			this.txtfecha.Name = "txtfecha";
			this.txtfecha.Size = new System.Drawing.Size(100, 23);
			this.txtfecha.TabIndex = 29;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtfecha);
			this.groupBox1.Controls.Add(this.txtnombre);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.cboespecialidad);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cboasignatura);
			this.groupBox1.Controls.Add(this.txt1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbosemestre);
			this.groupBox1.Controls.Add(this.txt2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(43, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(557, 199);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			// 
			// btnregistrar
			// 
			this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnregistrar.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnregistrar.Location = new System.Drawing.Point(381, 257);
			this.btnregistrar.Name = "btnregistrar";
			this.btnregistrar.Size = new System.Drawing.Size(106, 33);
			this.btnregistrar.TabIndex = 31;
			this.btnregistrar.Text = "REGISTRAR";
			this.btnregistrar.UseVisualStyleBackColor = false;
			this.btnregistrar.Click += new System.EventHandler(this.BtnregistrarClick);
			// 
			// btncancelar
			// 
			this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btncancelar.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancelar.Location = new System.Drawing.Point(505, 257);
			this.btncancelar.Name = "btncancelar";
			this.btncancelar.Size = new System.Drawing.Size(95, 33);
			this.btncancelar.TabIndex = 32;
			this.btncancelar.Text = "CANCELAR";
			this.btncancelar.UseVisualStyleBackColor = false;
			this.btncancelar.Click += new System.EventHandler(this.BtncancelarClick);
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listView1.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.Location = new System.Drawing.Point(28, 296);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(572, 165);
			this.listView1.TabIndex = 34;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Asignatura o Submódulo";
			this.columnHeader1.Width = 134;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial 1";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial 2";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial 3";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Promedio";
			this.columnHeader5.Width = 56;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aprob/Reprob";
			this.columnHeader6.Width = 94;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(307, 485);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(139, 23);
			this.label10.TabIndex = 35;
			this.label10.Text = "Promedio General:";
			// 
			// txtpromediogral
			// 
			this.txtpromediogral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.txtpromediogral.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpromediogral.Location = new System.Drawing.Point(461, 483);
			this.txtpromediogral.Name = "txtpromediogral";
			this.txtpromediogral.Size = new System.Drawing.Size(133, 21);
			this.txtpromediogral.TabIndex = 36;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(28, 467);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 41);
			this.button1.TabIndex = 37;
			this.button1.Text = "QUITAR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// Calificacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(645, 517);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtpromediogral);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btncancelar);
			this.Controls.Add(this.btnregistrar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "Calificacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calificacion";
			this.Load += new System.EventHandler(this.CalificacionLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtpromediogral;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btncancelar;
		private System.Windows.Forms.Button btnregistrar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtfecha;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboasignatura;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbosemestre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.ComboBox cboespecialidad;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
