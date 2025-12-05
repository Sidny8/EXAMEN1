/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 05/12/2025
 * Time: 02:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class Postres
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.cboProducto = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCant = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lvProductos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSubT = new System.Windows.Forms.TextBox();
			this.txtDes = new System.Windows.Forms.TextBox();
			this.txtImpN = new System.Windows.Forms.TextBox();
			this.txtImpP = new System.Windows.Forms.TextBox();
			this.txtCam = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(43, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 42);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(116, 12);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "SALADO";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(6, 12);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "DULCE";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Seleccionar producto:";
			// 
			// cboProducto
			// 
			this.cboProducto.FormattingEnabled = true;
			this.cboProducto.Location = new System.Drawing.Point(159, 83);
			this.cboProducto.Name = "cboProducto";
			this.cboProducto.Size = new System.Drawing.Size(121, 21);
			this.cboProducto.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Precio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cantidad";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(277, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "total";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(13, 136);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 6;
			// 
			// txtCant
			// 
			this.txtCant.Location = new System.Drawing.Point(119, 136);
			this.txtCant.Name = "txtCant";
			this.txtCant.Size = new System.Drawing.Size(100, 20);
			this.txtCant.TabIndex = 7;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(225, 136);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 8;
			// 
			// lvProductos
			// 
			this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.lvProductos.GridLines = true;
			this.lvProductos.Location = new System.Drawing.Point(13, 179);
			this.lvProductos.Name = "lvProductos";
			this.lvProductos.Size = new System.Drawing.Size(312, 98);
			this.lvProductos.TabIndex = 9;
			this.lvProductos.UseCompatibleStateImageBehavior = false;
			this.lvProductos.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Producto";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Precio";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cantidad";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Total";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 292);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "label5";
			// 
			// txtSubT
			// 
			this.txtSubT.Location = new System.Drawing.Point(49, 292);
			this.txtSubT.Name = "txtSubT";
			this.txtSubT.Size = new System.Drawing.Size(100, 20);
			this.txtSubT.TabIndex = 11;
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(171, 292);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(100, 20);
			this.txtDes.TabIndex = 12;
			// 
			// txtImpN
			// 
			this.txtImpN.Location = new System.Drawing.Point(291, 292);
			this.txtImpN.Name = "txtImpN";
			this.txtImpN.Size = new System.Drawing.Size(47, 20);
			this.txtImpN.TabIndex = 13;
			// 
			// txtImpP
			// 
			this.txtImpP.Location = new System.Drawing.Point(291, 319);
			this.txtImpP.Name = "txtImpP";
			this.txtImpP.Size = new System.Drawing.Size(47, 20);
			this.txtImpP.TabIndex = 14;
			// 
			// txtCam
			// 
			this.txtCam.Location = new System.Drawing.Point(291, 345);
			this.txtCam.Name = "txtCam";
			this.txtCam.Size = new System.Drawing.Size(47, 20);
			this.txtCam.TabIndex = 15;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(31, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(112, 336);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Borrar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(194, 336);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Imprimir";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(345, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(107, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Agregar Producto";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(345, 118);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(107, 23);
			this.button5.TabIndex = 20;
			this.button5.Text = "Eliminar Producto";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// Postres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 371);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtCam);
			this.Controls.Add(this.txtImpP);
			this.Controls.Add(this.txtImpN);
			this.Controls.Add(this.txtDes);
			this.Controls.Add(this.txtSubT);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvProductos);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCant);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboProducto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Postres";
			this.Text = "POSTRES (PASTELERIA)";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtCam;
		private System.Windows.Forms.TextBox txtImpP;
		private System.Windows.Forms.TextBox txtImpN;
		private System.Windows.Forms.TextBox txtDes;
		private System.Windows.Forms.TextBox txtSubT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvProductos;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCant;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboProducto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
