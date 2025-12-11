/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 01:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of PeriTriángulo.
	/// </summary>
	public partial class PeriTrapecio : Form
	{
		public PeriTrapecio()
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
			double LadoA, LadoB, LadoC, LadoD, perimetro;
			LadoA=Convert.ToDouble(txtLadoA.Text);
			LadoB=Convert.ToDouble(txtLadoB.Text);
			LadoC=Convert.ToDouble(txtLadoC.Text);
			LadoD=Convert.ToDouble(txtLadoD.Text);
			
			perimetro= LadoA + LadoB + LadoC + LadoD;
			
			lblPerimetro.Text=perimetro.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtLadoA.Text=string.Empty;
			txtLadoB.Text=string.Empty;
			txtLadoC.Text=string.Empty;
			txtLadoD.Text=string.Empty;
			lblPerimetro.Text=string.Empty;
			txtLadoA.Focus();
		}
		
		void PeriTrapecioLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.trapecio;
		}
	}
}
