/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 06/12/2025
 * Hora: 11:01 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace TrabajoExamen
{
	partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.postresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perímetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fibonnaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.áreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadrádoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.triánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perímetroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pirámideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boletaDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.postresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.detallesToolStripMenuItem,
									this.postresToolStripMenuItem,
									this.áreaToolStripMenuItem,
									this.perímetroToolStripMenuItem1,
									this.volumenToolStripMenuItem,
									this.conversionesToolStripMenuItem,
									this.boletaDeCalificacionesToolStripMenuItem,
									this.toolStripMenuItem1,
									this.postresToolStripMenuItem1,
									this.empleadosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.postresToolStripMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(801, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// detallesToolStripMenuItem
			// 
			this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
			this.detallesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.detallesToolStripMenuItem.Text = "Detalles";
			// 
			// postresToolStripMenuItem
			// 
			this.postresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.perímetroToolStripMenuItem,
									this.fibonnaciToolStripMenuItem});
			this.postresToolStripMenuItem.Name = "postresToolStripMenuItem";
			this.postresToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.postresToolStripMenuItem.Text = "Aplicaciones";
			// 
			// perímetroToolStripMenuItem
			// 
			this.perímetroToolStripMenuItem.Name = "perímetroToolStripMenuItem";
			this.perímetroToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.perímetroToolStripMenuItem.Text = "Factorial";
			this.perímetroToolStripMenuItem.Click += new System.EventHandler(this.PerímetroToolStripMenuItemClick);
			// 
			// fibonnaciToolStripMenuItem
			// 
			this.fibonnaciToolStripMenuItem.Name = "fibonnaciToolStripMenuItem";
			this.fibonnaciToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.fibonnaciToolStripMenuItem.Text = "Fibonnaci";
			this.fibonnaciToolStripMenuItem.Click += new System.EventHandler(this.FibonnaciToolStripMenuItemClick);
			// 
			// áreaToolStripMenuItem
			// 
			this.áreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadrádoToolStripMenuItem,
									this.rectánguloToolStripMenuItem,
									this.triánguloToolStripMenuItem});
			this.áreaToolStripMenuItem.Name = "áreaToolStripMenuItem";
			this.áreaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.áreaToolStripMenuItem.Text = "Área";
			// 
			// cuadrádoToolStripMenuItem
			// 
			this.cuadrádoToolStripMenuItem.Name = "cuadrádoToolStripMenuItem";
			this.cuadrádoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.cuadrádoToolStripMenuItem.Text = "Cuadrado";
			this.cuadrádoToolStripMenuItem.Click += new System.EventHandler(this.CuadrádoToolStripMenuItemClick);
			// 
			// rectánguloToolStripMenuItem
			// 
			this.rectánguloToolStripMenuItem.Name = "rectánguloToolStripMenuItem";
			this.rectánguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.rectánguloToolStripMenuItem.Text = "Rectángulo";
			this.rectánguloToolStripMenuItem.Click += new System.EventHandler(this.RectánguloToolStripMenuItemClick);
			// 
			// triánguloToolStripMenuItem
			// 
			this.triánguloToolStripMenuItem.Name = "triánguloToolStripMenuItem";
			this.triánguloToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.triánguloToolStripMenuItem.Text = "Triángulo";
			this.triánguloToolStripMenuItem.Click += new System.EventHandler(this.TriánguloToolStripMenuItemClick);
			// 
			// perímetroToolStripMenuItem1
			// 
			this.perímetroToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circunferenciaToolStripMenuItem,
									this.trapecioToolStripMenuItem});
			this.perímetroToolStripMenuItem1.Name = "perímetroToolStripMenuItem1";
			this.perímetroToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
			this.perímetroToolStripMenuItem1.Text = "Perímetro";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
			this.circunferenciaToolStripMenuItem.Click += new System.EventHandler(this.CircunferenciaToolStripMenuItemClick);
			// 
			// trapecioToolStripMenuItem
			// 
			this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
			this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.trapecioToolStripMenuItem.Text = "Trapecio";
			this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.TrapecioToolStripMenuItemClick);
			// 
			// volumenToolStripMenuItem
			// 
			this.volumenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.esferaToolStripMenuItem,
									this.cuboToolStripMenuItem,
									this.pirámideToolStripMenuItem});
			this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
			this.volumenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.volumenToolStripMenuItem.Text = "Volumen";
			// 
			// esferaToolStripMenuItem
			// 
			this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
			this.esferaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.esferaToolStripMenuItem.Text = "Esfera";
			this.esferaToolStripMenuItem.Click += new System.EventHandler(this.EsferaToolStripMenuItemClick);
			// 
			// cuboToolStripMenuItem
			// 
			this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
			this.cuboToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.cuboToolStripMenuItem.Text = "Cubo";
			this.cuboToolStripMenuItem.Click += new System.EventHandler(this.CuboToolStripMenuItemClick);
			// 
			// pirámideToolStripMenuItem
			// 
			this.pirámideToolStripMenuItem.Name = "pirámideToolStripMenuItem";
			this.pirámideToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.pirámideToolStripMenuItem.Text = "Pirámide";
			this.pirámideToolStripMenuItem.Click += new System.EventHandler(this.PirámideToolStripMenuItemClick);
			// 
			// conversionesToolStripMenuItem
			// 
			this.conversionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.longToolStripMenuItem,
									this.temperaturasToolStripMenuItem,
									this.tiempoToolStripMenuItem,
									this.masaToolStripMenuItem});
			this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
			this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.conversionesToolStripMenuItem.Text = "Conversiones";
			// 
			// longToolStripMenuItem
			// 
			this.longToolStripMenuItem.Name = "longToolStripMenuItem";
			this.longToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.longToolStripMenuItem.Text = "Longitud";
			this.longToolStripMenuItem.Click += new System.EventHandler(this.LongToolStripMenuItemClick);
			// 
			// temperaturasToolStripMenuItem
			// 
			this.temperaturasToolStripMenuItem.Name = "temperaturasToolStripMenuItem";
			this.temperaturasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.temperaturasToolStripMenuItem.Text = "Temperatura";
			this.temperaturasToolStripMenuItem.Click += new System.EventHandler(this.TemperaturasToolStripMenuItemClick);
			// 
			// tiempoToolStripMenuItem
			// 
			this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
			this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.tiempoToolStripMenuItem.Text = "Tiempo";
			this.tiempoToolStripMenuItem.Click += new System.EventHandler(this.TiempoToolStripMenuItemClick);
			// 
			// masaToolStripMenuItem
			// 
			this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
			this.masaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.masaToolStripMenuItem.Text = "Masa";
			this.masaToolStripMenuItem.Click += new System.EventHandler(this.MasaToolStripMenuItemClick);
			// 
			// boletaDeCalificacionesToolStripMenuItem
			// 
			this.boletaDeCalificacionesToolStripMenuItem.Name = "boletaDeCalificacionesToolStripMenuItem";
			this.boletaDeCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
			this.boletaDeCalificacionesToolStripMenuItem.Text = "Boleta de Calificaciones";
			this.boletaDeCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.BoletaDeCalificacionesToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
			// 
			// postresToolStripMenuItem1
			// 
			this.postresToolStripMenuItem1.Name = "postresToolStripMenuItem1";
			this.postresToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
			this.postresToolStripMenuItem1.Text = "Postres";
			this.postresToolStripMenuItem1.Click += new System.EventHandler(this.PostresToolStripMenuItem1Click);
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItemClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 261);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem postresToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem boletaDeCalificacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperaturasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem longToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pirámideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perímetroToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem triánguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectánguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadrádoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fibonnaciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem áreaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perímetroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem postresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
