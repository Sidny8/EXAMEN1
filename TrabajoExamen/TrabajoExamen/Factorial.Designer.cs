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
	partial class Factorial
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
			this.SuspendLayout();
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(110, 47);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(100, 20);
			this.txtNum.TabIndex = 0;
			// 
			// lblRes
			// 
			this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblRes.Location = new System.Drawing.Point(110, 131);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(100, 23);
			this.lblRes.TabIndex = 1;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(134, 195);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// Factorial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(276, 275);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.txtNum);
			this.Name = "Factorial";
			this.Text = "Factorial";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRes;
		private System.Windows.Forms.TextBox txtNum;
	}
}
