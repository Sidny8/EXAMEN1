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
			this.components = new System.ComponentModel.Container();
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
			this.lvProductos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.txtImpP = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblimpP = new System.Windows.Forms.Label();
			this.lblSub = new System.Windows.Forms.Label();
			this.lblCambio = new System.Windows.Forms.Label();
			this.txtDes = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
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
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
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
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
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
			this.cboProducto.Location = new System.Drawing.Point(142, 82);
			this.cboProducto.Name = "cboProducto";
			this.cboProducto.Size = new System.Drawing.Size(154, 21);
			this.cboProducto.TabIndex = 2;
			this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.CboProductoSelectedIndexChanged);
			this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.CboProductoSelectionChangeCommitted);
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
			this.label4.Location = new System.Drawing.Point(225, 109);
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
			this.txtCant.TextChanged += new System.EventHandler(this.TxtCantTextChanged);
			// 
			// lvProductos
			// 
			this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4});
			this.lvProductos.GridLines = true;
			this.lvProductos.Location = new System.Drawing.Point(31, 172);
			this.lvProductos.Name = "lvProductos";
			this.lvProductos.Size = new System.Drawing.Size(400, 114);
			this.lvProductos.TabIndex = 9;
			this.lvProductos.UseCompatibleStateImageBehavior = false;
			this.lvProductos.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Producto";
			this.columnHeader1.Width = 148;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Precio";
			this.columnHeader2.Width = 96;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cantidad";
			this.columnHeader3.Width = 94;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Total";
			this.columnHeader4.Width = 55;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 292);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "label5";
			// 
			// txtImpP
			// 
			this.txtImpP.Location = new System.Drawing.Point(383, 318);
			this.txtImpP.Name = "txtImpP";
			this.txtImpP.Size = new System.Drawing.Size(60, 20);
			this.txtImpP.TabIndex = 14;
			this.txtImpP.TextChanged += new System.EventHandler(this.TxtImpPTextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(31, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(112, 336);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Borrar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(194, 336);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Imprimir";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(345, 80);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(107, 23);
			this.btnAgregar.TabIndex = 19;
			this.btnAgregar.Text = "Agregar Producto";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.Button4Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(345, 118);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(107, 23);
			this.btnEliminar.TabIndex = 20;
			this.btnEliminar.Text = "Eliminar Producto";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// lblTotal
			// 
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotal.Location = new System.Drawing.Point(225, 133);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(100, 23);
			this.lblTotal.TabIndex = 21;
			// 
			// lblimpP
			// 
			this.lblimpP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblimpP.Location = new System.Drawing.Point(383, 291);
			this.lblimpP.Name = "lblimpP";
			this.lblimpP.Size = new System.Drawing.Size(60, 24);
			this.lblimpP.TabIndex = 22;
			// 
			// lblSub
			// 
			this.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSub.Location = new System.Drawing.Point(65, 291);
			this.lblSub.Name = "lblSub";
			this.lblSub.Size = new System.Drawing.Size(100, 23);
			this.lblSub.TabIndex = 23;
			// 
			// lblCambio
			// 
			this.lblCambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCambio.Location = new System.Drawing.Point(383, 341);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(60, 18);
			this.lblCambio.TabIndex = 25;
			// 
			// txtDes
			// 
			this.txtDes.Location = new System.Drawing.Point(194, 295);
			this.txtDes.Name = "txtDes";
			this.txtDes.Size = new System.Drawing.Size(100, 20);
			this.txtDes.TabIndex = 26;
			this.txtDes.TextChanged += new System.EventHandler(this.TxtDesTextChanged);
			// 
			// Postres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 371);
			this.Controls.Add(this.txtDes);
			this.Controls.Add(this.lblCambio);
			this.Controls.Add(this.lblSub);
			this.Controls.Add(this.lblimpP);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtImpP);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lvProductos);
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
			this.Load += new System.EventHandler(this.PostresLoad);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtDes;
		private System.Windows.Forms.Label lblCambio;
		private System.Windows.Forms.Label lblSub;
		private System.Windows.Forms.Label lblimpP;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtImpP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvProductos;
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
