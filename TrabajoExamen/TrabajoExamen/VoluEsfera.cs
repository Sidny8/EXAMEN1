/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 02:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of VoluEsfera.
	/// </summary>
	public partial class VoluEsfera : Form
	{
		public VoluEsfera()
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
			double Radio, volumen;
			Radio=Convert.ToDouble(txtRadio.Text);
			
			volumen= (4 * 3.1416 * Radio*Radio*Radio) / 3;
			
			lblVolumen.Text=volumen.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtRadio.Text=string.Empty;
			lblVolumen.Text=string.Empty;
			txtRadio.Focus();
		}
		
		void VoluEsferaLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.esfera;
		}
	}
}
