/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 01:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of AreaTriangulo.
	/// </summary>
	public partial class AreaTriangulo : Form
	{
		public AreaTriangulo()
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
			double Base, Altura, area;
			Base=Convert.ToDouble(txtBase.Text);
			Altura=Convert.ToDouble(txtAltura.Text);
			
			area=(Base*Altura) / 2;
			
			lblArea.Text=area.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtBase.Text=string.Empty;
			txtAltura.Text=string.Empty;
			lblArea.Text=string.Empty;
			txtBase.Focus();
		}
		
		void AreaTrianguloLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.triangulo;
		}
	}
}
