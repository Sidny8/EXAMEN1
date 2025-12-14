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
			int num;
			if(!int.TryParse(txtLadoB.Text, out num)){
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
		
		private bool NumeroC(){
			int num;
			if(!int.TryParse(txtLadoC.Text, out num)){
                erpError.SetError(txtLadoC,"Debe de poner un numerico");
                txtLadoC.Clear();
                txtLadoC.Focus();
                return false;
            }
            else{
                erpError.SetError(txtLadoC,"");
                return true;
            }
		}
		
		private bool NumeroD(){
			int num;
			if(!int.TryParse(txtLadoD.Text, out num)){
                erpError.SetError(txtLadoD,"Debe de poner un numerico");
                txtLadoD.Clear();
                txtLadoD.Focus();
                return false;
            }
            else{
                erpError.SetError(txtLadoD,"");
                return true;
            }
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if(txtLadoA.Text!="" && txtLadoB.Text!="" && txtLadoC.Text!="" && txtLadoD.Text!=""){
				double LadoA, LadoB, LadoC, LadoD, perimetro;
				LadoA=Convert.ToDouble(txtLadoA.Text);
				LadoB=Convert.ToDouble(txtLadoB.Text);
				LadoC=Convert.ToDouble(txtLadoC.Text);
				LadoD=Convert.ToDouble(txtLadoD.Text);
			
				perimetro= LadoA + LadoB + LadoC + LadoD;
			
				lblPerimetro.Text=perimetro.ToString();
			}else{
				MessageBox.Show("Complete todos los datos");
			}
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
		
		void TxtLadoCTextChanged(object sender, EventArgs e)
		{
			if(txtLadoC.Text!=""){
				if(NumeroC()==false){
					return;
				}
			}
		}
		
		void TxtLadoDTextChanged(object sender, EventArgs e)
		{
			if(txtLadoD.Text!=""){
				if(NumeroD()==false){
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
