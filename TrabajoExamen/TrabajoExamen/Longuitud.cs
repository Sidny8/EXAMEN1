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
		
		void BtnconvertirClick(object sender, EventArgs e)
		{
   			 if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Centímetros")
   			 {
      			  conversion = int.Parse(txtvalor.Text) * 1;
      			  txtresultado.Text = conversion.ToString();
   			 }
	   		 else if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Metros")
		    {
 	  		    conversion = int.Parse(txtvalor.Text) * 0.01;
	   			txtresultado.Text = conversion.ToString();
	   		}
		  	else if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Kilómetros")
	  		{
	      	  conversion = int.Parse(txtvalor.Text) * 0.00001;
        	  txtresultado.Text = conversion.ToString();
   	 		}
    		else if (cmbde.SelectedItem.ToString() == "Centímetros" && cmba.SelectedItem.ToString() == "Millas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 0.000006213711;
        		txtresultado.Text = conversion.ToString();
  			 }
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Centímetros")
    		{
        		conversion = int.Parse(txtvalor.Text) * 100;
        		txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Metros")
    		{
        		conversion = int.Parse(txtvalor.Text) * 1;
        		txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Kilómetros")
   			{
        		conversion = int.Parse(txtvalor.Text) * 0.001;
        		txtresultado.Text = conversion.ToString();
    		}
    		else if (cmbde.SelectedItem.ToString() == "Metros" && cmba.SelectedItem.ToString() == "Millas")
    		{
        		conversion = int.Parse(txtvalor.Text) * 0.000621371;
        		txtresultado.Text = conversion.ToString();
    		}
  			else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Kilómetros")
   			{
      		   conversion = int.Parse(txtvalor.Text) * 1;
       		   txtresultado.Text = conversion.ToString();
   			 }
    		else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Centímetros")
    		{
       		  conversion = int.Parse(txtvalor.Text) * 100000;
       		  txtresultado.Text = conversion.ToString();
  			}
    		else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Metros")
    		{
       		  conversion = int.Parse(txtvalor.Text) * 1000;
       		  txtresultado.Text = conversion.ToString();
    }
    else if (cmbde.SelectedItem.ToString() == "Kilómetros" && cmba.SelectedItem.ToString() == "Millas")
    {
        conversion = int.Parse(txtvalor.Text) * 0.621371;
        txtresultado.Text = conversion.ToString();
    }
    else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Millas")
    {
        conversion = int.Parse(txtvalor.Text) * 1;
        txtresultado.Text = conversion.ToString();
    }
    else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Centímetros")
    {
        conversion = int.Parse(txtvalor.Text) * 160934;
        txtresultado.Text = conversion.ToString();
    }
    else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Metros")
    {
        conversion = int.Parse(txtvalor.Text) * 1609.34;
        txtresultado.Text = conversion.ToString();
    }
    else if (cmbde.SelectedItem.ToString() == "Millas" && cmba.SelectedItem.ToString() == "Kilómetros")
    {
        conversion = int.Parse(txtvalor.Text) * 1.60934;
        txtresultado.Text = conversion.ToString();
    }
}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
}
}
