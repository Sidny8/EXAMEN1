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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLadoA = new System.Windows.Forms.TextBox();
			this.txtLadoB = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblArea = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lado A:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lado B:";
			// 
			// txtLadoA
			// 
			this.txtLadoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtLadoA.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLadoA.Location = new System.Drawing.Point(135, 78);
			this.txtLadoA.Name = "txtLadoA";
			this.txtLadoA.Size = new System.Drawing.Size(100, 21);
			this.txtLadoA.TabIndex = 2;
			this.txtLadoA.TextChanged += new System.EventHandler(this.TxtLadoATextChanged);
			// 
			// txtLadoB
			// 
			this.txtLadoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtLadoB.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLadoB.Location = new System.Drawing.Point(135, 117);
			this.txtLadoB.Name = "txtLadoB";
			this.txtLadoB.Size = new System.Drawing.Size(100, 21);
			this.txtLadoB.TabIndex = 3;
			this.txtLadoB.TextChanged += new System.EventHandler(this.TxtLadoBTextChanged);
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCalcular.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(14, 183);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(87, 23);
			this.btnCalcular.TabIndex = 4;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnLimpiar.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(14, 223);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(185, 158);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 88);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Sitka Banner", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(171, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "La Área del cuadrado es:";
			// 
			// lblArea
			// 
			this.lblArea.Location = new System.Drawing.Point(185, 283);
			this.lblArea.Name = "lblArea";
			this.lblArea.Size = new System.Drawing.Size(100, 23);
			this.lblArea.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(46, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(277, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Área de un Cuadrado";
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// AreaCuadrado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(353, 340);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblArea);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtLadoB);
			this.Controls.Add(this.txtLadoA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AreaCuadrado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AreaCuadrado";
			this.Load += new System.EventHandler(this.AreaCuadradoLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtLadoB;
		private System.Windows.Forms.TextBox txtLadoA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
