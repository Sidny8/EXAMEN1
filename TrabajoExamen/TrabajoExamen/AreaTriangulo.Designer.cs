/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 01:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class AreaTriangulo
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
			this.lblArea = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.txtBase = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblArea
			// 
			this.lblArea.Location = new System.Drawing.Point(181, 229);
			this.lblArea.Name = "lblArea";
			this.lblArea.Size = new System.Drawing.Size(100, 23);
			this.lblArea.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(166, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 23);
			this.label3.TabIndex = 28;
			this.label3.Text = "La Área del Triangulo es:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(181, 101);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 88);
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(12, 201);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 26;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(12, 166);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 25;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(12, 126);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 24;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(138, 57);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 20);
			this.txtAltura.TabIndex = 23;
			// 
			// txtBase
			// 
			this.txtBase.Location = new System.Drawing.Point(138, 21);
			this.txtBase.Name = "txtBase";
			this.txtBase.Size = new System.Drawing.Size(100, 20);
			this.txtBase.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 21;
			this.label2.Text = "Altura:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 20;
			this.label1.Text = "Base:";
			// 
			// AreaTriangulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 270);
			this.Controls.Add(this.lblArea);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtBase);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AreaTriangulo";
			this.Text = "AreaTriangulo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBase;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblArea;
	}
}
