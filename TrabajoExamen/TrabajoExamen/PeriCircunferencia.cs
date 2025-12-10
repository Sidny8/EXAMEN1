/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 01:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of PeriCircunferencia.
	/// </summary>
	public partial class PeriCircunferencia : Form
	{
		public PeriCircunferencia()
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
			double Diametro, perimetro;
			Diametro=Convert.ToDouble(txtDiametro.Text);
			
			perimetro= 3.1416*Diametro;
			
			lblPerimetro.Text=perimetro.ToString();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtDiametro.Text=string.Empty;
			lblPerimetro.Text=string.Empty;
			txtDiametro.Focus();
		}
	}
}
