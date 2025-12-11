/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 10/12/2025
 * Time: 01:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class Finnobacci
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
			this.txtNum = new System.Windows.Forms.TextBox();
			this.lblRes = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNum
			// 
			this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtNum.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtNum.Location = new System.Drawing.Point(112, 47);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(40, 21);
			this.txtNum.TabIndex = 0;
			// 
			// lblRes
			// 
			this.lblRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblRes.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.lblRes.Location = new System.Drawing.Point(58, 147);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(174, 23);
			this.lblRes.TabIndex = 1;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCalcular.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnCalcular.Location = new System.Drawing.Point(158, 226);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(100, 23);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnLimpiar.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnLimpiar.Location = new System.Drawing.Point(44, 226);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(89, 23);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 10F);
			this.label1.Location = new System.Drawing.Point(18, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "dame la cantidad de números:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 10F);
			this.label2.Location = new System.Drawing.Point(79, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "la sucesión es:";
			// 
			// Finnobacci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.txtNum);
			this.Name = "Finnobacci";
			this.Text = "Finnobacci";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRes;
		private System.Windows.Forms.TextBox txtNum;
	}
}
