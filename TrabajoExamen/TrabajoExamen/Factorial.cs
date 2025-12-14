/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 10/12/2025
 * Time: 01:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of Factorial.
	/// </summary>
	public partial class Factorial : Form
	{   int num, mul=1;
		public Factorial()
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
			if(!int.TryParse(txtNum.Text, out num)){
                erpError.SetError(txtNum,"Debe de poner un numerico");
                txtNum.Clear();
                txtNum.Focus();
                return false;
            }
            else{
                erpError.SetError(txtNum,"");
                return true;
            }
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{	mul = 1;
			if(txtNum.Text!="" && txtNum.Text!="0"){
				num = int.Parse(txtNum.Text);
				for(int a = 1; a <= num; a++){
						mul *= a; 
				}
				lblRes.Text = mul.ToString();
				
			}else{
				MessageBox.Show("Diga un numero antes");
			}
			
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void TxtNumTextChanged(object sender, EventArgs e)
		{
			if(txtNum.Text!=""){
				if(NumeroA()==false){
					return;
				}
			}
		}
	}
}
