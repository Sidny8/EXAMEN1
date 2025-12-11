/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 09/12/2025
 * Hora: 09:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of ConversionTiempo.
	/// </summary>
	public partial class ConversionTiempo : Form
	{
		double conversion;
		public ConversionTiempo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnconvertirClick(object sender, EventArgs e)
		{
			 if (cmbde.SelectedItem.ToString() == "Segundos" && cmba.SelectedItem.ToString() == "Segundos")
   			 {
      			  conversion = int.Parse(txtvalor.Text) * 1;
      			  txtresultado.Text = conversion.ToString();
   			 }
	   		 else if (cmbde.SelectedItem.ToString() == "Segundos" && cmba.SelectedItem.ToString() == "Minutos")
		    {
 	  		    conversion = int.Parse(txtvalor.Text) * 0.0166667;
	   			txtresultado.Text = conversion.ToString();
	   		}
		  	else if (cmbde.SelectedItem.ToString() == "Segundos" && cmba.SelectedItem.ToString() == "Horas")
	  		{
	      	  conversion = int.Parse(txtvalor.Text) * 0.00027777833333;
        	  txtresultado.Text = conversion.ToString();
   	 		}
    		else if (cmbde.SelectedItem.ToString() == "Minutos" && cmba.SelectedItem.ToString() == "Minutos")
    		{
        		conversion = int.Parse(txtvalor.Text) * 1;
        		txtresultado.Text = conversion.ToString();
  			 }
    		else if (cmbde.SelectedItem.ToString() == "Minutos" && cmba.SelectedItem.ToString() == "Segundos")
    		{
        		conversion = int.Parse(txtvalor.Text) * 60;
        		txtresultado.Text = conversion.ToString();
    		}	
			else if (cmbde.SelectedItem.ToString() == "Minutos" && cmba.SelectedItem.ToString() == "Horas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 0.0166667;
        		txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Horas" && cmba.SelectedItem.ToString() == "Horas")
   			{
        		conversion = int.Parse(txtvalor.Text) * 1;
        		txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Horas" && cmba.SelectedItem.ToString() == "Segundos")
    		{
        		conversion = int.Parse(txtvalor.Text) * 3600;
        		txtresultado.Text = conversion.ToString();
    		}
  			else if (cmbde.SelectedItem.ToString() == "Horas" && cmba.SelectedItem.ToString() == "Minutos")
   			{
      		   conversion = int.Parse(txtvalor.Text) * 60;
       		   txtresultado.Text = conversion.ToString();
   			 }    		
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
