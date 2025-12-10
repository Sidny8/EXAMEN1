/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 08/12/2025
 * Hora: 02:34 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TrabajoExamen
{
	partial class Conversiones_de_Temperaturas
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDesde = new System.Windows.Forms.TextBox();
			this.txtHasta = new System.Windows.Forms.TextBox();
			this.rdbCaK = new System.Windows.Forms.RadioButton();
			this.rdbFaC = new System.Windows.Forms.RadioButton();
			this.rdbKaF = new System.Windows.Forms.RadioButton();
			this.rdbKaC = new System.Windows.Forms.RadioButton();
			this.rdbCaF = new System.Windows.Forms.RadioButton();
			this.rdbFaK = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.lsbtemp = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(190, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Conversiones de Temperaturas";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(35, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Desde:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(162, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hasta:";
			// 
			// txtDesde
			// 
			this.txtDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtDesde.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesde.Location = new System.Drawing.Point(12, 107);
			this.txtDesde.Name = "txtDesde";
			this.txtDesde.Size = new System.Drawing.Size(100, 21);
			this.txtDesde.TabIndex = 3;
			// 
			// txtHasta
			// 
			this.txtHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtHasta.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHasta.Location = new System.Drawing.Point(134, 107);
			this.txtHasta.Name = "txtHasta";
			this.txtHasta.Size = new System.Drawing.Size(100, 21);
			this.txtHasta.TabIndex = 4;
			// 
			// rdbCaK
			// 
			this.rdbCaK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rdbCaK.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbCaK.Location = new System.Drawing.Point(0, 25);
			this.rdbCaK.Name = "rdbCaK";
			this.rdbCaK.Size = new System.Drawing.Size(153, 24);
			this.rdbCaK.TabIndex = 5;
			this.rdbCaK.TabStop = true;
			this.rdbCaK.Text = "Celsius a Kelvin:";
			this.rdbCaK.UseVisualStyleBackColor = false;
			this.rdbCaK.CheckedChanged += new System.EventHandler(this.RdbCaKCheckedChanged);
			// 
			// rdbFaC
			// 
			this.rdbFaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rdbFaC.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbFaC.Location = new System.Drawing.Point(0, 55);
			this.rdbFaC.Name = "rdbFaC";
			this.rdbFaC.Size = new System.Drawing.Size(153, 24);
			this.rdbFaC.TabIndex = 6;
			this.rdbFaC.TabStop = true;
			this.rdbFaC.Text = "Farenheit a Celsius";
			this.rdbFaC.UseVisualStyleBackColor = false;
			this.rdbFaC.CheckedChanged += new System.EventHandler(this.RdbFaCCheckedChanged);
			// 
			// rdbKaF
			// 
			this.rdbKaF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rdbKaF.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbKaF.Location = new System.Drawing.Point(0, 85);
			this.rdbKaF.Name = "rdbKaF";
			this.rdbKaF.Size = new System.Drawing.Size(153, 24);
			this.rdbKaF.TabIndex = 7;
			this.rdbKaF.TabStop = true;
			this.rdbKaF.Text = "Kelvin a Farenheit:";
			this.rdbKaF.UseVisualStyleBackColor = false;
			this.rdbKaF.CheckedChanged += new System.EventHandler(this.RdbKaFCheckedChanged);
			// 
			// rdbKaC
			// 
			this.rdbKaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rdbKaC.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbKaC.Location = new System.Drawing.Point(177, 25);
			this.rdbKaC.Name = "rdbKaC";
			this.rdbKaC.Size = new System.Drawing.Size(153, 24);
			this.rdbKaC.TabIndex = 8;
			this.rdbKaC.TabStop = true;
			this.rdbKaC.Text = "Kelvin a Celsius:";
			this.rdbKaC.UseVisualStyleBackColor = false;
			this.rdbKaC.CheckedChanged += new System.EventHandler(this.RdbKaCCheckedChanged);
			// 
			// rdbCaF
			// 
			this.rdbCaF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rdbCaF.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbCaF.Location = new System.Drawing.Point(177, 55);
			this.rdbCaF.Name = "rdbCaF";
			this.rdbCaF.Size = new System.Drawing.Size(153, 24);
			this.rdbCaF.TabIndex = 9;
			this.rdbCaF.TabStop = true;
			this.rdbCaF.Text = "Celsius a Farenheit";
			this.rdbCaF.UseVisualStyleBackColor = false;
			this.rdbCaF.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// rdbFaK
			// 
			this.rdbFaK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rdbFaK.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbFaK.Location = new System.Drawing.Point(177, 85);
			this.rdbFaK.Name = "rdbFaK";
			this.rdbFaK.Size = new System.Drawing.Size(153, 24);
			this.rdbFaK.TabIndex = 10;
			this.rdbFaK.TabStop = true;
			this.rdbFaK.Text = " Farenheit a Kelvin:";
			this.rdbFaK.UseVisualStyleBackColor = false;
			this.rdbFaK.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbCaK);
			this.groupBox1.Controls.Add(this.rdbFaK);
			this.groupBox1.Controls.Add(this.rdbFaC);
			this.groupBox1.Controls.Add(this.rdbCaF);
			this.groupBox1.Controls.Add(this.rdbKaF);
			this.groupBox1.Controls.Add(this.rdbKaC);
			this.groupBox1.Location = new System.Drawing.Point(52, 159);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(347, 151);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(496, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Listado:";
			// 
			// btnsalir
			// 
			this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnsalir.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsalir.Location = new System.Drawing.Point(647, 229);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(75, 39);
			this.btnsalir.TabIndex = 14;
			this.btnsalir.Text = "SALIR";
			this.btnsalir.UseVisualStyleBackColor = false;
			this.btnsalir.Click += new System.EventHandler(this.BtnsalirClick);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnlimpiar.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlimpiar.Location = new System.Drawing.Point(647, 159);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(75, 37);
			this.btnlimpiar.TabIndex = 15;
			this.btnlimpiar.Text = "Limpiar";
			this.btnlimpiar.UseVisualStyleBackColor = false;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// lsbtemp
			// 
			this.lsbtemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lsbtemp.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbtemp.FormattingEnabled = true;
			this.lsbtemp.Location = new System.Drawing.Point(438, 95);
			this.lsbtemp.Name = "lsbtemp";
			this.lsbtemp.Size = new System.Drawing.Size(175, 173);
			this.lsbtemp.TabIndex = 16;
			// 
			// Conversiones_de_Temperaturas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(742, 309);
			this.Controls.Add(this.lsbtemp);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtHasta);
			this.Controls.Add(this.txtDesde);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Conversiones_de_Temperaturas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Conversiones_de_Temperaturas";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox lsbtemp;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbFaK;
		private System.Windows.Forms.RadioButton rdbCaF;
		private System.Windows.Forms.RadioButton rdbKaC;
		private System.Windows.Forms.RadioButton rdbKaF;
		private System.Windows.Forms.RadioButton rdbFaC;
		private System.Windows.Forms.RadioButton rdbCaK;
		private System.Windows.Forms.TextBox txtHasta;
		private System.Windows.Forms.TextBox txtDesde;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
