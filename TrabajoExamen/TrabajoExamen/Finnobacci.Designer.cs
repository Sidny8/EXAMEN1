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
			this.components = new System.ComponentModel.Container();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.lblRes = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNum
			// 
			this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtNum.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.txtNum.Location = new System.Drawing.Point(248, 121);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(40, 21);
			this.txtNum.TabIndex = 0;
			this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNum.TextChanged += new System.EventHandler(this.TxtNumTextChanged);
			// 
			// lblRes
			// 
			this.lblRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblRes.Font = new System.Drawing.Font("Sitka Text", 8F);
			this.lblRes.Location = new System.Drawing.Point(49, 205);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(471, 31);
			this.lblRes.TabIndex = 1;
			this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCalcular.Font = new System.Drawing.Font("Stencil", 10F);
			this.btnCalcular.Location = new System.Drawing.Point(420, 284);
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
			this.btnLimpiar.Location = new System.Drawing.Point(49, 284);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(89, 23);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "QUITAR";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 10F);
			this.label1.Location = new System.Drawing.Point(148, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "dame la cantidad de números:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 10F);
			this.label2.Location = new System.Drawing.Point(206, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "la sucesión es:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Snap ITC", 20F);
			this.label3.Location = new System.Drawing.Point(158, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 40);
			this.label3.TabIndex = 6;
			this.label3.Text = "Finnobacci";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// Finnobacci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(566, 336);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.txtNum);
			this.Name = "Finnobacci";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Finnobacci";
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRes;
		private System.Windows.Forms.TextBox txtNum;
	}
}
