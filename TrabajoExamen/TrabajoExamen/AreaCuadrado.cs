/*
 * Created by SharpDevelop.
 * User: CC2_PC39
 * Date: 08/12/2025
 * Time: 06:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of AreaCuadrado.
	/// </summary>
	public partial class AreaCuadrado : Form
	{
		public AreaCuadrado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double LadoA, LadoB, area;
			LadoA=Convert.ToDouble(txtLadoA.Text);
			LadoB=Convert.ToDouble(txtLadoB.Text);
			
			area= LadoA*LadoB;
			
			lblArea.Text=area.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtLadoA.Text=string.Empty;
			txtLadoB.Text=string.Empty;
			lblArea.Text=string.Empty;
			txtLadoA.Focus();
		}
		
		void AreaCuadradoLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.cuadrado; 
		}
	}
}
