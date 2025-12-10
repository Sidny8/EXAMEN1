/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 08/12/2025
 * Time: 06:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class AreaCuadrado
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
			this.txtLadoA = new System.Windows.Forms.TextBox();
			this.txtLadoB = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblArea = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(26, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "LadoA:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "LadoB:";
			// 
			// txtLadoA
			// 
			this.txtLadoA.Location = new System.Drawing.Point(133, 24);
			this.txtLadoA.Name = "txtLadoA";
			this.txtLadoA.Size = new System.Drawing.Size(100, 20);
			this.txtLadoA.TabIndex = 2;
			// 
			// txtLadoB
			// 
			this.txtLadoB.Location = new System.Drawing.Point(133, 63);
			this.txtLadoB.Name = "txtLadoB";
			this.txtLadoB.Size = new System.Drawing.Size(100, 20);
			this.txtLadoB.TabIndex = 3;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(12, 129);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(12, 169);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(12, 211);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 6;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(183, 104);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 88);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(169, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "La Área del cuadrado es:";
			// 
			// lblArea
			// 
			this.lblArea.Location = new System.Drawing.Point(183, 229);
			this.lblArea.Name = "lblArea";
			this.lblArea.Size = new System.Drawing.Size(100, 23);
			this.lblArea.TabIndex = 9;
			// 
			// AreaCuadrado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 261);
			this.Controls.Add(this.lblArea);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtLadoB);
			this.Controls.Add(this.txtLadoA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AreaCuadrado";
			this.Text = "AreaCuadrado";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtLadoB;
		private System.Windows.Forms.TextBox txtLadoA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
