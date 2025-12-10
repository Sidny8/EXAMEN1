/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 02:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class VoluCubo
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
			this.lblVolumen = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtLado = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblVolumen
			// 
			this.lblVolumen.Location = new System.Drawing.Point(191, 238);
			this.lblVolumen.Name = "lblVolumen";
			this.lblVolumen.Size = new System.Drawing.Size(100, 23);
			this.lblVolumen.TabIndex = 55;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(173, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 23);
			this.label3.TabIndex = 54;
			this.label3.Text = "El Volumen del Cubo es:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(182, 96);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(109, 102);
			this.pictureBox1.TabIndex = 53;
			this.pictureBox1.TabStop = false;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(22, 188);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 52;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(22, 149);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 51;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(22, 109);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 50;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtLado
			// 
			this.txtLado.Location = new System.Drawing.Point(153, 39);
			this.txtLado.Name = "txtLado";
			this.txtLado.Size = new System.Drawing.Size(100, 20);
			this.txtLado.TabIndex = 49;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(47, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 48;
			this.label1.Text = "Lado:";
			// 
			// VoluCubo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 301);
			this.Controls.Add(this.lblVolumen);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtLado);
			this.Controls.Add(this.label1);
			this.Name = "VoluCubo";
			this.Text = "VoluCubo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLado;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblVolumen;
	}
}
