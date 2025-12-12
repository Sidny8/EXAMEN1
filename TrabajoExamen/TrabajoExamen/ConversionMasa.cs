/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 09/12/2025
 * Hora: 08:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of ConversionMasa.
	/// </summary>
	public partial class ConversionMasa : Form
	{
		double conversion;
		public ConversionMasa()
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
				if (cmbde.SelectedItem.ToString() == "Kilos" && cmba.SelectedItem.ToString() == "Kilos")
   			 	{
      			  conversion = int.Parse(txtvalor.Text) * 1;
      			  txtresultado.Text = conversion.ToString();
   			 }
	   		 else if (cmbde.SelectedItem.ToString() == "Kilos" && cmba.SelectedItem.ToString() == "Libras")
		    {
 	  		    conversion = int.Parse(txtvalor.Text) * 2.20462;
	   			txtresultado.Text = conversion.ToString();
	   		}
		  	else if (cmbde.SelectedItem.ToString() == "Kilos" && cmba.SelectedItem.ToString() == "Gramos")
	  		{
	      	  conversion = int.Parse(txtvalor.Text) * 1000;
        	  txtresultado.Text = conversion.ToString();
   	 		}
    		else if (cmbde.SelectedItem.ToString() == "Kilos" && cmba.SelectedItem.ToString() == "Toneladas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 0.001;
        		txtresultado.Text = conversion.ToString();
  			 }	
			else if (cmbde.SelectedItem.ToString() == "Libras" && cmba.SelectedItem.ToString() == "Libras")
    		{
        		conversion = int.Parse(txtvalor.Text) * 1;
        		txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Libras" && cmba.SelectedItem.ToString() == "Kilos")
   			{
        		conversion = int.Parse(txtvalor.Text) * 0.453592;
        		txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Libras" && cmba.SelectedItem.ToString() == "Gramos")
    		{
        		conversion = int.Parse(txtvalor.Text) * 453.592;
        		txtresultado.Text = conversion.ToString();
    		}
  			else if (cmbde.SelectedItem.ToString() == "Libras" && cmba.SelectedItem.ToString() == "Toneladas")
   			{
      		   conversion = int.Parse(txtvalor.Text) * 0.000453592;
       		   txtresultado.Text = conversion.ToString();
   			 }  
					else if (cmbde.SelectedItem.ToString() == "Gramos" && cmba.SelectedItem.ToString() == "Gramos")
    		{
       		  conversion = int.Parse(txtvalor.Text) * 1;
       		  txtresultado.Text = conversion.ToString();
  			}
    		else if (cmbde.SelectedItem.ToString() == "Gramos" && cmba.SelectedItem.ToString() == "Kilos")
    		{
       		  conversion = int.Parse(txtvalor.Text) * 0.001;
       		  txtresultado.Text = conversion.ToString();
   		 	}
    		else if (cmbde.SelectedItem.ToString() == "Gramos" && cmba.SelectedItem.ToString() == "Libras")
   			{
        	conversion = int.Parse(txtvalor.Text) * 0.00220462;
        	txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Gramos" && cmba.SelectedItem.ToString() == "Toneladas")
    		{
        	conversion = int.Parse(txtvalor.Text) * 0.000001;
        	txtresultado.Text = conversion.ToString();
    		}  
		    else if (cmbde.SelectedItem.ToString() == "Toneladas" && cmba.SelectedItem.ToString() == "Toneladas")
   			 {
        	conversion = int.Parse(txtvalor.Text) * 1;
        	txtresultado.Text = conversion.ToString();
   			}
    		else if (cmbde.SelectedItem.ToString() == "Toneladas" && cmba.SelectedItem.ToString() == "Kilos")
    		{
        	conversion = int.Parse(txtvalor.Text) * 1000;
        	txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Toneladas" && cmba.SelectedItem.ToString() == "Libras")
    		{
        	conversion = int.Parse(txtvalor.Text) * 2204.62;
        	txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Toneladas" && cmba.SelectedItem.ToString() == "Gramos")
    		{
        	conversion = int.Parse(txtvalor.Text) * 1000000;
        	txtresultado.Text = conversion.ToString();
    		}
    		}
			else{
    			MessageBox.Show("Escriba la cantidad y escoja las opciones");
			}
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			this.Hide();
		}
		
		void TxtvalorTextChanged(object sender, EventArgs e)
		{
			if(NumeroA()==false){
				return;
			}
		}
	}
}
