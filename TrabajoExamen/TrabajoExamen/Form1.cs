/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 06/12/2025
 * Hora: 11:01 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		Factorial ftl = new Factorial();
		Finnobacci Fnb = new Finnobacci();
		AreaCuadrado Cuadado = new AreaCuadrado();
		AreaRectangulo Rectangulo = new AreaRectangulo();
		AreaTriangulo Triangulo = new AreaTriangulo();
		PeriCircunferencia Circu = new PeriCircunferencia();
		PeriTrapecio Trapecio = new PeriTrapecio();
		VoluEsfera Esfera = new VoluEsfera();
		VoluCubo Cubo = new VoluCubo();
		VoluPirámide Pira = new VoluPirámide();
		Longuitud Long = new Longuitud();
		Conversiones_de_Temperaturas temp = new Conversiones_de_Temperaturas();
		ConversionTiempo Time = new ConversionTiempo();
		ConversionMasa Masa = new ConversionMasa();
		Calificacion Cali = new Calificacion();
		Postres Pos = new Postres();
		DetallesEmpleado Empleado = new DetallesEmpleado();
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PerímetroToolStripMenuItemClick(object sender, EventArgs e)
		{
			ftl.Show();
			ftl.MdiParent=this;
			ftl.Show();
			this.Fnb.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void FibonnaciToolStripMenuItemClick(object sender, EventArgs e)
		{
			Fnb.MdiParent=this;
			Fnb.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void CuadrádoToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cuadado.MdiParent=this;
			Cuadado.Show();
			this.Fnb.Hide();
			this.ftl.Hide();
			this.Rectangulo.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void RectánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			Rectangulo.MdiParent=this;
			Rectangulo.Show();
			this.Cuadado.Hide();
			this.Fnb.Hide();
			this.ftl.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void TriánguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			Triangulo.MdiParent=this;
			Triangulo.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Circu.MdiParent=this;
			Circu.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			Trapecio.MdiParent=this;
			Trapecio.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Esfera.MdiParent=this;
			Esfera.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cubo.MdiParent=this;
			Cubo.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void PirámideToolStripMenuItemClick(object sender, EventArgs e)
		{
			Pira.MdiParent=this;
			Pira.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void LongToolStripMenuItemClick(object sender, EventArgs e)
		{
			Long.MdiParent=this;
			Long.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void TemperaturasToolStripMenuItemClick(object sender, EventArgs e)
		{
			temp.MdiParent=this;
			temp.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void TiempoToolStripMenuItemClick(object sender, EventArgs e)
		{
			Time.MdiParent=this;
			Time.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void MasaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Masa.MdiParent=this;
			Masa.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void BoletaDeCalificacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cali.MdiParent=this;
			Cali.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Pos.Hide();
			this.Empleado.Hide();
		}
		
		void PostresToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Pos.MdiParent=this;
			Pos.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Empleado.Hide();
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Empleado.MdiParent=this;
			Empleado.Show();
			this.ftl.Hide();
			this.Cuadado.Hide();
			this.Rectangulo.Hide();
			this.Fnb.Hide();
			this.Triangulo.Hide();
			this.Circu.Hide();
			this.Trapecio.Hide();
			this.Esfera.Hide();
			this.Cubo.Hide();
			this.Pira.Hide();
			this.Long.Hide();
			this.temp.Hide();
			this.Time.Hide();
			this.Masa.Hide();
			this.Cali.Hide();
			this.Pos.Hide();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			 if(MessageBox.Show("¿Estas seguro de querer salir de la aplicación?", "Confirmar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
                { 
			 	Application.Exit();
                } 
                 
            
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			AcercaDe__ info = new AcercaDe__();
			info.Show();
			this.Hide();
		}
	}
}
