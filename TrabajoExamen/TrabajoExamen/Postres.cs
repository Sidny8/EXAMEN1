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
using MySql.Data.MySqlClient;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of Postres.
	/// </summary>
	public partial class Postres : Form{
		
		double precio, des=0, sub, tot, impP, preciot=0;	
		int cant;
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
			txtCant.Text="";
			cboProducto.Text="";
			txtPrecio.Clear();
		}
		 
		//Metodos de Validaciones
		//Metodo de cbo de productos, ver si hay algo escogido
		private bool Producto(){
			if(string.IsNullOrEmpty(cboProducto.Text)){
                erpError.SetError(cboProducto,"Debe seleccionar un producto");
                return false;
            }
            else{
                erpError.SetError(cboProducto,"");
                return true;
			}
		}
		//Metodo para escribir la cantidad
		private bool Cant(){
			int cants;
            if(!int.TryParse(txtCant.Text, out cants) || txtCant.Text == ""){
                erpError.SetError(txtCant,"Debe de poner una cantidad numerica entera");
                txtCant.Clear();
                txtCant.Focus();
                return false;
            }
            else{
                erpError.SetError(txtCant,"");
                return true;
            }
		}
		//Metodo para validar los descuentos
		private bool Des(){
            double dest;
            if(!double.TryParse(txtDes.Text, out dest) || txtDes.Text == ""){
                erpError.SetError(txtDes,"Debe de poner un descuento aunque sea 0");
                txtDes.Clear();
                txtDes.Focus();
                return false;
            }
            else{
                erpError.SetError(txtDes,"");
                return true;
            }
		}
		private bool Pago(){
			double pagst;
            if(!double.TryParse(txtImpP.Text, out pagst) || txtImpP.Text == ""){
                erpError.SetError(txtImpP,"Debe de poner un descuento aunque sea 0");
                txtImpP.Clear();
                txtImpP.Focus();
                return false;
            }
            else{
                erpError.SetError(txtImpP,"");
                return true;
            }
		}
		
		//Metodo de la conexion, para agregar
		public bool AgregarProducto(string produc, double precio, int cantimy, double totalmy)
        {
            /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=Examen; user=root;pwd=;";
            cn.Open();
            /// AGREGAR EL REGISTRO A LA BASE DE DATOS
            string strSQL = "insert into Productos (productos, precio, cantidad, total)" +
                " values (@productos, @precio, @cantidad, @total)";
            MySqlCommand comando = new MySqlCommand(strSQL, cn);
            comando.Parameters.AddWithValue("Productos", produc);
            comando.Parameters.AddWithValue("Precio", precio);
            comando.Parameters.AddWithValue("Cantidad",cantimy);
            comando.Parameters.AddWithValue("Total", totalmy);
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto agregado");
            /// FINALIZAMOS LA CONEXION CERRAMOS TODO

            comando.Dispose();
            cn.Close();
            cn.Dispose();
            return true;
        }

		//Teletrasportador a ticket
		void Button3Click(object sender, EventArgs e)
		{
			//Validacion de cosas:
			if(Des()==false){
				return;
			}
			
			PostresTicket pk = new PostresTicket();
			pk.filaPK= new ListViewItem(produc);
			pk.filaPK.SubItems.Add(precio.ToString());
			pk.filaPK.SubItems.Add(cant.ToString());
			pk.filaPK.SubItems.Add(tot.ToString());
			
			pk.descPK= Convert.ToDouble(txtDes.Text);
			pk.totPK= Convert.ToDouble(lblimpP.Text);
			pk.subPK= Convert.ToDouble(lblSub.Text);
			pk.Show();
			this.Hide();
		}
		
		//Boton para agregar producto
		void Button4Click(object sender, EventArgs e)
		{
			//Validaciones:
			if(Producto()==false){
				return;
			}
			if(Cant()==false){
				return;
			}
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
		
		//Tipos de pastel (DULCE/SALADO)
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			radioButton2.ForeColor= Color.Red;
			radioButton1.ForeColor=Color.Green;
			cboProducto.Items.Clear();
			//cboProducto.DataSource = itemsA;
			cont1 = 1;
			cboProducto.Items.AddRange(opciones);
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			radioButton1.ForeColor= Color.Red;
			radioButton2.ForeColor= Color.Green;
			cboProducto.Items.Clear();
			cont1 = 2;
			cboProducto.Items.AddRange(opciones1);
		}
		
		//En teoria, iniciacion de negativos a los radios.
		//No funciona :v
		void PostresLoad(object sender, EventArgs e)
		{
			pictureBox1.Image = Resource1.pasteleria;
			radioButton1.Checked=false;
			radioButton2.Checked=false;
		}
		
		//Seleccion del producto y su cambio al uisar los arrgelos como base para agregar los precios
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
		
		//El sacar los calculos despues de decir o miestras dices la cantidad
		void TxtCantTextChanged(object sender, EventArgs e)
		{
			if(txtCant.Text != "" && Cant()!= false){
				precio= Convert.ToDouble(txtPrecio.Text);
				cant= Convert.ToInt32(txtCant.Text);
				lblTotal.Text= Convert.ToString(precio*cant);
			}
		}
		
		//El descuento
		void TxtDesTextChanged(object sender, EventArgs e)
		{
			if(txtDes.Text != "" && Des()!=false){
				des = Convert.ToDouble(txtDes.Text);
				tot = preciot - des;
				lblimpP.Text= tot.ToString();
			}
		}
		
		//Para pagar
		void TxtImpPTextChanged(object sender, EventArgs e)
		{
			if(txtImpP.Text!="" && Pago()!=false){
				impP = Convert.ToDouble(txtImpP.Text);
				lblCambio.Text= Convert.ToString(impP - tot);
			}
		}
		
		//Eliminacion de datos
		void Button2Click(object sender, EventArgs e)
		{	
			Limpiar();
			lblCambio.Text="";
			lblimpP.Text="";
			lblSub.Text="";
			lblTotal.Text="";
			txtDes.Text="";
			txtImpP.Text="";
		}
		
		void CboProductoSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			AgregarProducto(produc,precio,cant,tot);
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			
		}
		
}
}