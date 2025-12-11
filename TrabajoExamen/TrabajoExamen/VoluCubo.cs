/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 02:38 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of VoluCubo.
	/// </summary>
	public partial class VoluCubo : Form
	{
		public VoluCubo()
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
			double Lado, volumen;
			Lado=Convert.ToDouble(txtLado.Text);
			
			volumen= Lado*Lado*Lado;
			
			lblVolumen.Text=volumen.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtLado.Text=string.Empty;
			lblVolumen.Text=string.Empty;
			txtLado.Focus();
		}
		
		void VoluCuboLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.cubo;
		}
	}
}
