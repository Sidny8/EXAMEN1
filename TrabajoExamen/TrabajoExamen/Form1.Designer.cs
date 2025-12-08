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
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.detallesToolStripMenuItem,
									this.postresToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.postresToolStripMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
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
			this.postresToolStripMenuItem.Name = "postresToolStripMenuItem";
			this.postresToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.postresToolStripMenuItem.Text = "Postres";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
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
		private System.Windows.Forms.ToolStripMenuItem postresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
