/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 05/12/2025
 * Time: 02:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of Postres.
	/// </summary>
	public partial class Postres : Form{
		
		double precio, des=0, sub, tot, impP, Cambio=0, preciot=0;	
		int cant, cont=1;
		
	string produc;
	string[] opciones = { "Pastel Tres Leches", "Pastel de chocolate", "Pastel de queso", "Pastel de frutas", "Pastel Red Velvet" };
	string[] opciones1 = { "Quiches", "Muffins", "Arroz con Leche", "Waffles", "Enyucado"  };
	int[] example = { 55, 110, 220, 440, 880 };
	int[] example1 = { 56, 111, 221, 441, 881 };
	int cont1 = 0;
	int val = 0;
	
		public Postres()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//Metodo de limpieza
		private void Limpiar(){
			txtCant.Text="0";
			cboProducto.Text="";
			txtPrecio.Clear();
		}

		void Button3Click(object sender, EventArgs e)
		{
			PostresTicket pk = new PostresTicket();
			pk.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			produc=cboProducto.Text;
			precio= Convert.ToDouble(txtPrecio.Text);
			cant= Convert.ToInt32(txtCant.Text);
			sub = cant*precio;
			
			
			//Agregacion de elementos a la tabla
			ListViewItem fila=new ListViewItem(produc);
			fila.SubItems.Add(precio.ToString());
			fila.SubItems.Add(cant.ToString());
			fila.SubItems.Add(sub.ToString());
			lvProductos.Items.Add(fila);
			
			//Agregacion a los lbl o txt
			
			preciot += sub;
			lblSub.Text= preciot.ToString();
			lblTotal.Text= sub.ToString();
			
			Limpiar();
			//
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			cboProducto.Items.Clear();
			//cboProducto.DataSource = itemsA;
			cont1 = 1;
			cboProducto.Items.AddRange(opciones);
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			cboProducto.Items.Clear();
			cont1 = 2;
			cboProducto.Items.AddRange(opciones1);
		}
		
		void PostresLoad(object sender, EventArgs e)
		{
			radioButton1.Checked=false;
			radioButton2.Checked=false;
		}
		
		void CboProductoSelectionChangeCommitted(object sender, EventArgs e)
		{
			val = cboProducto.SelectedIndex;
			if(cont1 == 1){
				txtPrecio.Text = example[val].ToString();
			}
			
			if(cont1 == 2){
				txtPrecio.Text = example1[val].ToString();
			}
		}
		
		void TxtCantTextChanged(object sender, EventArgs e)
		{
			precio= Convert.ToDouble(txtPrecio.Text);
			cant= Convert.ToInt32(txtCant.Text);
			if((precio * cant) >= 200 && cont<3){
				des= (precio * cant) * 0.10;
			}
			if(cont >=3 && (precio * cant) < 200){
				des= (precio * cant) * 0.07;
			}
			if(cont >= 3 && (precio*cant) >= 200){
				des= (precio * cant) * 0.15;
			}
			lblTotal.Text= Convert.ToString(precio*cant);
		}
		
		void TxtDesTextChanged(object sender, EventArgs e)
		{
			des = Convert.ToDouble(txtDes.Text);
			tot = preciot - des;
			lblimpP.Text= tot.ToString();
		}
		
		void TxtImpPTextChanged(object sender, EventArgs e)
		{
			impP = Convert.ToDouble(txtImpP.Text);
			lblCambio.Text= Convert.ToString(impP - tot);
		}
	}
}
