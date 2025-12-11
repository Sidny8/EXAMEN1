/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 11/12/2025
 * Hora: 03:52 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of AcercaDe__.
	/// </summary>
	public partial class AcercaDe__ : Form
	{
		public AcercaDe__()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AcercaDe__Load(object sender, EventArgs e)
		{
			pictureBox1.Image= Resource1.untitled_0__1_;
			pictureBox2.Image = Resource1.sam;
			pictureBox3.Image = Resource1.cindy;
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 menu = new Form1();
			menu.Show();
			this.Hide();
		}
	}
}
