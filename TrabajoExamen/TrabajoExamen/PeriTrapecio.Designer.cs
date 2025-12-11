/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 01:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class PeriTrapecio
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
			this.lblPerimetro = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtLadoB = new System.Windows.Forms.TextBox();
			this.txtLadoA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLadoC = new System.Windows.Forms.TextBox();
			this.txtLadoD = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPerimetro
			// 
			this.lblPerimetro.Location = new System.Drawing.Point(244, 269);
			this.lblPerimetro.Name = "lblPerimetro";
			this.lblPerimetro.Size = new System.Drawing.Size(100, 23);
			this.lblPerimetro.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(221, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "El Perimetro del Trapecio es:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(244, 136);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 97);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(45, 246);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 16;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(45, 201);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 15;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(45, 160);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 14;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtLadoB
			// 
			this.txtLadoB.Location = new System.Drawing.Point(134, 57);
			this.txtLadoB.Name = "txtLadoB";
			this.txtLadoB.Size = new System.Drawing.Size(100, 20);
			this.txtLadoB.TabIndex = 13;
			// 
			// txtLadoA
			// 
			this.txtLadoA.Location = new System.Drawing.Point(134, 30);
			this.txtLadoA.Name = "txtLadoA";
			this.txtLadoA.Size = new System.Drawing.Size(100, 20);
			this.txtLadoA.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(55, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "LadoB:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(55, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "LadoA:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(55, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "LadoC:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(55, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 21;
			this.label5.Text = "LadoD:";
			// 
			// txtLadoC
			// 
			this.txtLadoC.Location = new System.Drawing.Point(134, 83);
			this.txtLadoC.Name = "txtLadoC";
			this.txtLadoC.Size = new System.Drawing.Size(100, 20);
			this.txtLadoC.TabIndex = 22;
			// 
			// txtLadoD
			// 
			this.txtLadoD.Location = new System.Drawing.Point(134, 111);
			this.txtLadoD.Name = "txtLadoD";
			this.txtLadoD.Size = new System.Drawing.Size(100, 20);
			this.txtLadoD.TabIndex = 23;
			// 
			// PeriTrapecio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(402, 320);
			this.Controls.Add(this.txtLadoD);
			this.Controls.Add(this.txtLadoC);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblPerimetro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtLadoB);
			this.Controls.Add(this.txtLadoA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PeriTrapecio";
			this.Text = "PeriTrapecio";
			this.Load += new System.EventHandler(this.PeriTrapecioLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtLadoD;
		private System.Windows.Forms.TextBox txtLadoC;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLadoA;
		private System.Windows.Forms.TextBox txtLadoB;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblPerimetro;
	}
}
