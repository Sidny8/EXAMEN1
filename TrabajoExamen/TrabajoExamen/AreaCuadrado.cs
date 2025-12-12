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
		
		private bool NumeroA(){
			int num;
			if(!int.TryParse(txtLadoA.Text, out num)){
                erpError.SetError(txtLadoA,"Debe de poner un numerico");
                txtLadoA.Clear();
                txtLadoA.Focus();
                return false;
            }
            else{
                erpError.SetError(txtLadoA,"");
                return true;
            }
		}
		private bool NumeroB(){
			int num2;
			if(!int.TryParse(txtLadoB.Text, out num2)){
                erpError.SetError(txtLadoB,"Debe de poner un numerico");
                txtLadoB.Clear();
                txtLadoB.Focus();
                return false;
            }
            else{
                erpError.SetError(txtLadoB,"");
                return true;
            }
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{	
			if(txtLadoA.Text != "" && txtLadoB.Text!= ""){
				double LadoA, LadoB, area;
				LadoA=Convert.ToDouble(txtLadoA.Text);
				LadoB=Convert.ToDouble(txtLadoB.Text);
				area= LadoA*LadoB;
				lblArea.Text=area.ToString();
			}else{
				MessageBox.Show("Rellene los datos");
			}
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
		
		void TxtLadoATextChanged(object sender, EventArgs e)
		{
			if(txtLadoA.Text!=""){
				if(NumeroA()==false){
					return;
				}
			}
		}
		
		void TxtLadoBTextChanged(object sender, EventArgs e)
		{
			if(txtLadoB.Text!=""){
				if(NumeroB()==false){
					return;
				}
			}
		}
	}
}
