/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 05/12/2025
 * Time: 03:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrabajoExamen
{
	partial class PostresTicket
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
			this.lblFecha = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblSub = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblDescuento = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnRgresar = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fecha";
			// 
			// lblFecha
			// 
			this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFecha.Location = new System.Drawing.Point(68, 52);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(121, 23);
			this.lblFecha.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 260);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Subtotal:";
			// 
			// lblSub
			// 
			this.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSub.Location = new System.Drawing.Point(113, 260);
			this.lblSub.Name = "lblSub";
			this.lblSub.Size = new System.Drawing.Size(99, 23);
			this.lblSub.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Descuento:";
			// 
			// lblDescuento
			// 
			this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescuento.Location = new System.Drawing.Point(113, 226);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.Size = new System.Drawing.Size(95, 23);
			this.lblDescuento.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 299);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Total:";
			// 
			// lblTotal
			// 
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotal.Location = new System.Drawing.Point(113, 299);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(100, 23);
			this.lblTotal.TabIndex = 7;
			// 
			// btnRgresar
			// 
			this.btnRgresar.Location = new System.Drawing.Point(283, 311);
			this.btnRgresar.Name = "btnRgresar";
			this.btnRgresar.Size = new System.Drawing.Size(75, 23);
			this.btnRgresar.TabIndex = 8;
			this.btnRgresar.Text = "Regresar";
			this.btnRgresar.UseVisualStyleBackColor = true;
			this.btnRgresar.Click += new System.EventHandler(this.BtnRgresarClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(22, 96);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(324, 117);
			this.listView1.TabIndex = 9;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Producto";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Precio";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cantidad";
			this.columnHeader3.Width = 56;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Total";
			this.columnHeader4.Width = 48;
			// 
			// PostresTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 346);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnRgresar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblDescuento);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblSub);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.label1);
			this.Name = "PostresTicket";
			this.Text = "PostresTicket";
			this.Load += new System.EventHandler(this.PostresTicketLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnRgresar;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblDescuento;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSub;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label label1;
	}
}
