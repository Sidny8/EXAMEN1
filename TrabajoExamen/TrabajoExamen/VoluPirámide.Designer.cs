/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 02:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class VoluPirámide
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
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.txtAreaBase = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblVolumen
			// 
			this.lblVolumen.Location = new System.Drawing.Point(188, 266);
			this.lblVolumen.Name = "lblVolumen";
			this.lblVolumen.Size = new System.Drawing.Size(100, 23);
			this.lblVolumen.TabIndex = 39;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Sitka Text", 10F);
			this.label3.Location = new System.Drawing.Point(126, 231);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 23);
			this.label3.TabIndex = 38;
			this.label3.Text = "El Volumen de la piramide es:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.pictureBox1.Location = new System.Drawing.Point(188, 140);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 88);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnRegresar.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnRegresar.Location = new System.Drawing.Point(12, 262);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(93, 23);
			this.btnRegresar.TabIndex = 36;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnLimpiar.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnLimpiar.Location = new System.Drawing.Point(12, 227);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(93, 23);
			this.btnLimpiar.TabIndex = 35;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCalcular.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnCalcular.Location = new System.Drawing.Point(12, 189);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(93, 23);
			this.btnCalcular.TabIndex = 34;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtAltura
			// 
			this.txtAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtAltura.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtAltura.Location = new System.Drawing.Point(139, 109);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 21);
			this.txtAltura.TabIndex = 33;
			// 
			// txtAreaBase
			// 
			this.txtAreaBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtAreaBase.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtAreaBase.Location = new System.Drawing.Point(139, 68);
			this.txtAreaBase.Name = "txtAreaBase";
			this.txtAreaBase.Size = new System.Drawing.Size(100, 21);
			this.txtAreaBase.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 10F);
			this.label2.Location = new System.Drawing.Point(33, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 31;
			this.label2.Text = "Altura:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 10F);
			this.label1.Location = new System.Drawing.Point(6, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 23);
			this.label1.TabIndex = 30;
			this.label1.Text = "Dame el Area de la Base:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Stencil", 14F);
			this.label4.Location = new System.Drawing.Point(62, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(226, 23);
			this.label4.TabIndex = 40;
			this.label4.Text = "volúmen de pirámide";
			// 
			// VoluPirámide
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(361, 312);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblVolumen);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtAreaBase);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "VoluPirámide";
			this.Text = "VoluPirámide";
			this.Load += new System.EventHandler(this.VoluPirámideLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAreaBase;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblVolumen;
	}
}
