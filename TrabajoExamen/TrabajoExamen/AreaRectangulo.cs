/*
 * Created by SharpDevelop.
 * User: CC1_PC17
 * Date: 10/12/2025
 * Time: 01:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of AreaRectangulo.
	/// </summary>
	public partial class AreaRectangulo : Form
	{
		public AreaRectangulo()
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
			if(!int.TryParse(txtAltura.Text, out num)){
                erpError.SetError(txtAltura,"Debe de poner un numerico");
                txtAltura.Clear();
                txtAltura.Focus();
                return false;
            }
            else{
                erpError.SetError(txtAltura,"");
                return true;
            }
		}
		private bool NumeroB(){
			int num2;
			if(!int.TryParse(txtBase.Text, out num2)){
                erpError.SetError(txtBase,"Debe de poner un numerico");
                txtBase.Clear();
                txtBase.Focus();
                return false;
            }
            else{
                erpError.SetError(txtBase,"");
                return true;
            }
		}
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if(txtAltura.Text != "" && txtBase.Text!= ""){
				double Base, Altura, area;
				Base=Convert.ToDouble(txtBase.Text);
				Altura=Convert.ToDouble(txtAltura.Text);
				area=Base*Altura;
				lblArea.Text=area.ToString();
			}else{
				MessageBox.Show("Rellene los datos");
			}
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtBase.Text=string.Empty;
			txtAltura.Text=string.Empty;
			lblArea.Text=string.Empty;
			txtBase.Focus();
		}
		
		void AreaRectanguloLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.rectangulo;
		}
		
		void TxtBaseTextChanged(object sender, EventArgs e)
		{
			if(txtBase.Text!=""){
				if(NumeroB()==false){
					return;
				}
			}
		}
		
		void TxtAlturaTextChanged(object sender, EventArgs e)
		{
			if(txtAltura.Text!=""){
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
