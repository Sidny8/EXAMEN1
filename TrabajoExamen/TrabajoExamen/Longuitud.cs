/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 08/12/2025
 * Hora: 06:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of Longuitud.
	/// </summary>
	public partial class Longuitud : Form
	{
		double conversion;
		public Longuitud()
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
			if(!int.TryParse(txtvalor.Text, out num)){
                erpError.SetError(txtvalor,"Debe de poner un numerico");
                txtvalor.Clear();
                txtvalor.Focus();
                return false;
            }
            else{
                erpError.SetError(txtvalor,"");
                return true;
            }
		}
		
		void BtnconvertirClick(object sender, EventArgs e)
		{
			if(txtvalor.Text!="" && cmba.Text!= "" && cmbde.Text!=""){
   			 if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Centímetros")
   			 {
      			  conversion = int.Parse(txtvalor.Text) * 1;
      			  lblresultado.Text = conversion.ToString();
   			 }
	   		 else if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Metros")
		    {
 	  		    conversion = int.Parse(txtvalor.Text) * 0.01;
	   			lblresultado.Text = conversion.ToString();
	   		}
		  	else if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Kilómetros")
	  		{
	      	  conversion = int.Parse(txtvalor.Text) * 0.00001;
        	  lblresultado.Text = conversion.ToString();
   	 		}
    		else if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Millas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 0.000006213711;
        		lblresultado.Text = conversion.ToString();
  			 }
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Centímetros")
    		{
        		conversion = int.Parse(txtvalor.Text) * 100;
        		lblresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Metros")
    		{
        		conversion = int.Parse(txtvalor.Text) * 1;
        		lblresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Kilómetros")
   			{
        		conversion = int.Parse(txtvalor.Text) * 0.001;
        		lblresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Millas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 0.000621371;
        		lblresultado.Text = conversion.ToString();
    		}
  			else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Kilómetros")
   			{
      		   conversion = int.Parse(txtvalor.Text) * 1;
       		   lblresultado.Text = conversion.ToString();
   			 }
    		else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Centímetros")
    		{
       		  conversion = int.Parse(txtvalor.Text) * 100000;
       		  lblresultado.Text = conversion.ToString();
  			}
    		else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Metros")
    		{
       		  conversion = int.Parse(txtvalor.Text) * 1000;
       		  lblresultado.Text = conversion.ToString();
   		    }
    		else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Millas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 0.621371;
        		lblresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Millas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 1;
        		lblresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Centímetros")
    		{
        		conversion = int.Parse(txtvalor.Text) * 160934;
        		lblresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Metros")
    		{
        		conversion = int.Parse(txtvalor.Text) * 1609.34;
        		lblresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Kilómetros")
    		{
        		conversion = int.Parse(txtvalor.Text) * 1.60934;
        		lblresultado.Text = conversion.ToString();
    		}
			}else{
				MessageBox.Show("Escoja las opciones");
			}
}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void TxtvalorTextChanged(object sender, EventArgs e)
		{
			if(txtvalor.Text!=""){
				if(NumeroA()==false){
					return;
				}
			}
		}
}
}
