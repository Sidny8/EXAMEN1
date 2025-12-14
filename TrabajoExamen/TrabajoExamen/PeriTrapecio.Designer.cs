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
			this.components = new System.ComponentModel.Container();
			this.lblPerimetro = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
			this.label6 = new System.Windows.Forms.Label();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPerimetro
			// 
			this.lblPerimetro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblPerimetro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPerimetro.Location = new System.Drawing.Point(214, 245);
			this.lblPerimetro.Name = "lblPerimetro";
			this.lblPerimetro.Size = new System.Drawing.Size(128, 23);
			this.lblPerimetro.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Sitka Text", 10F);
			this.label3.Location = new System.Drawing.Point(182, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(208, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "El Perimetro del Trapecio es:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(252, 79);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 97);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnLimpiar.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnLimpiar.Location = new System.Drawing.Point(41, 224);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(98, 23);
			this.btnLimpiar.TabIndex = 15;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCalcular.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnCalcular.Location = new System.Drawing.Point(41, 195);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(98, 23);
			this.btnCalcular.TabIndex = 14;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtLadoB
			// 
			this.txtLadoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtLadoB.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtLadoB.Location = new System.Drawing.Point(130, 101);
			this.txtLadoB.Name = "txtLadoB";
			this.txtLadoB.Size = new System.Drawing.Size(100, 21);
			this.txtLadoB.TabIndex = 13;
			this.txtLadoB.TextChanged += new System.EventHandler(this.TxtLadoBTextChanged);
			// 
			// txtLadoA
			// 
			this.txtLadoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtLadoA.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtLadoA.Location = new System.Drawing.Point(130, 74);
			this.txtLadoA.Name = "txtLadoA";
			this.txtLadoA.Size = new System.Drawing.Size(100, 21);
			this.txtLadoA.TabIndex = 12;
			this.txtLadoA.TextChanged += new System.EventHandler(this.TxtLadoATextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 10F);
			this.label2.Location = new System.Drawing.Point(51, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Lado B:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 10F);
			this.label1.Location = new System.Drawing.Point(51, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Lado A:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Stencil", 10F);
			this.label4.Location = new System.Drawing.Point(51, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "Lado C:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Stencil", 10F);
			this.label5.Location = new System.Drawing.Point(51, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 21;
			this.label5.Text = "Lado D:";
			// 
			// txtLadoC
			// 
			this.txtLadoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtLadoC.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtLadoC.Location = new System.Drawing.Point(130, 127);
			this.txtLadoC.Name = "txtLadoC";
			this.txtLadoC.Size = new System.Drawing.Size(100, 21);
			this.txtLadoC.TabIndex = 22;
			this.txtLadoC.TextChanged += new System.EventHandler(this.TxtLadoCTextChanged);
			// 
			// txtLadoD
			// 
			this.txtLadoD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtLadoD.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtLadoD.Location = new System.Drawing.Point(130, 155);
			this.txtLadoD.Name = "txtLadoD";
			this.txtLadoD.Size = new System.Drawing.Size(100, 21);
			this.txtLadoD.TabIndex = 23;
			this.txtLadoD.TextChanged += new System.EventHandler(this.TxtLadoDTextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Snap ITC", 14F);
			this.label6.Location = new System.Drawing.Point(41, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(328, 23);
			this.label6.TabIndex = 24;
			this.label6.Text = "Perímetro del Trapecio";
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.Font = new System.Drawing.Font("Stencil", 10F);
			this.button1.Location = new System.Drawing.Point(41, 253);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 23);
			this.button1.TabIndex = 25;
			this.button1.Text = "quitar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// PeriTrapecio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(396, 300);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLadoD);
			this.Controls.Add(this.txtLadoC);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblPerimetro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtLadoB);
			this.Controls.Add(this.txtLadoA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "PeriTrapecio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PeriTrapecio";
			this.Load += new System.EventHandler(this.PeriTrapecioLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.Label label6;
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblPerimetro;
	}
}
