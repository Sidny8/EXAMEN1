/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 02:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of VoluPirámide.
	/// </summary>
	public partial class VoluPirámide : Form
	{
		public VoluPirámide()
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
			double AreaBase, Altura, volumen;
			AreaBase=Convert.ToDouble(txtAreaBase.Text);
			Altura=Convert.ToDouble(txtAltura.Text);
			
			volumen=(AreaBase*Altura) / 3;
			
			lblVolumen.Text=volumen.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtAreaBase.Text=string.Empty;
			txtAltura.Text=string.Empty;
			lblVolumen.Text=string.Empty;
			txtAreaBase.Focus();
		}
		
		void VoluPirámideLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.piramide;
		}
	}
}
