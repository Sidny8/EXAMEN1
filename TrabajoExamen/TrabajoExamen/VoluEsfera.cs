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
		
		private bool NumeroA(){
			int num;
			if(!int.TryParse(txtRadio.Text, out num)){
                erpError.SetError(txtRadio,"Debe de poner un numerico");
                txtRadio.Clear();
                txtRadio.Focus();
                return false;
            }
            else{
                erpError.SetError(txtRadio,"");
                return true;
            }
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if(txtRadio.Text!=""){
				double Radio, volumen;
				Radio=Convert.ToDouble(txtRadio.Text);
				volumen= (4 * 3.1416 * Radio*Radio*Radio) / 3;
				lblVolumen.Text=volumen.ToString();
			}else{
				MessageBox.Show("Diga el dato requerido");
			}
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
		
		void TxtRadioTextChanged(object sender, EventArgs e)
		{
			if(txtRadio.Text!=""){
				if(NumeroA()==false){
					return;
				}
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
