/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 09/12/2025
 * Hora: 09:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TrabajoExamen
{
	partial class ConversionTiempo
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
			this.cmbde = new System.Windows.Forms.ComboBox();
			this.cmba = new System.Windows.Forms.ComboBox();
			this.txtvalor = new System.Windows.Forms.TextBox();
			this.txtresultado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnconvertir = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Conversiones de Tiempo";
			// 
			// cmbde
			// 
			this.cmbde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmbde.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbde.FormattingEnabled = true;
			this.cmbde.Items.AddRange(new object[] {
									"",
									"Segundos",
									"Minutos",
									"Horas"});
			this.cmbde.Location = new System.Drawing.Point(12, 94);
			this.cmbde.Name = "cmbde";
			this.cmbde.Size = new System.Drawing.Size(121, 21);
			this.cmbde.TabIndex = 12;
			// 
			// cmba
			// 
			this.cmba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.cmba.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmba.FormattingEnabled = true;
			this.cmba.Items.AddRange(new object[] {
									"",
									"Segundos",
									"Minutos",
									"Horas"});
			this.cmba.Location = new System.Drawing.Point(164, 94);
			this.cmba.Name = "cmba";
			this.cmba.Size = new System.Drawing.Size(121, 21);
			this.cmba.TabIndex = 13;
			// 
			// txtvalor
			// 
			this.txtvalor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtvalor.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtvalor.Location = new System.Drawing.Point(12, 167);
			this.txtvalor.Name = "txtvalor";
			this.txtvalor.Size = new System.Drawing.Size(121, 21);
			this.txtvalor.TabIndex = 14;
			// 
			// txtresultado
			// 
			this.txtresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtresultado.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtresultado.Location = new System.Drawing.Point(164, 167);
			this.txtresultado.Name = "txtresultado";
			this.txtresultado.ReadOnly = true;
			this.txtresultado.Size = new System.Drawing.Size(121, 21);
			this.txtresultado.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(54, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "De:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(196, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "A:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "Valor a Calcular:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(185, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "Resultado:";
			// 
			// btnconvertir
			// 
			this.btnconvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnconvertir.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnconvertir.Location = new System.Drawing.Point(21, 214);
			this.btnconvertir.Name = "btnconvertir";
			this.btnconvertir.Size = new System.Drawing.Size(96, 26);
			this.btnconvertir.TabIndex = 20;
			this.btnconvertir.Text = "CONVERTIR";
			this.btnconvertir.UseVisualStyleBackColor = false;
			this.btnconvertir.Click += new System.EventHandler(this.BtnconvertirClick);
			// 
			// btnsalir
			// 
			this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnsalir.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsalir.Location = new System.Drawing.Point(185, 214);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(96, 26);
			this.btnsalir.TabIndex = 21;
			this.btnsalir.Text = "SALIR";
			this.btnsalir.UseVisualStyleBackColor = false;
			// 
			// ConversionTiempo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(297, 261);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btnconvertir);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtresultado);
			this.Controls.Add(this.txtvalor);
			this.Controls.Add(this.cmba);
			this.Controls.Add(this.cmbde);
			this.Controls.Add(this.label1);
			this.Name = "ConversionTiempo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ConversionTiempo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btnconvertir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtresultado;
		private System.Windows.Forms.TextBox txtvalor;
		private System.Windows.Forms.ComboBox cmba;
		private System.Windows.Forms.ComboBox cmbde;
		private System.Windows.Forms.Label label1;
	}
}
