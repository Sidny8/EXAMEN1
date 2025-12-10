/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 05/12/2025
 * Time: 03:45 p. m.
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
	/// Description of DetallesEmpleado.
	/// </summary>
	public partial class DetallesEmpleado : Form
	{
		string estado;
		List<ClaseDeDetalles> milista =new List<ClaseDeDetalles>();
		public DetallesEmpleado()
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
			txtCodigo.Clear();
			txtNaci.Clear();
			txtNombre.Clear();
			cboPuesto.SelectedIndex=-1;
			cboSex.SelectedIndex=-1;
			radioButton1.Checked=false;
			radioButton2.Checked=false;
		}
		
		//Metodos para la validacion de los datos que se van a pedir
		//Metodo del Nombre
		private bool ValidarNombre(){
			if(string.IsNullOrEmpty(txtNombre.Text)){
				erpError.SetError(txtNombre,"Debe ingresar un nombre");
				return false;
			}else{
				erpError.SetError(txtNombre,"");
				return true;
			}
		}
		//Metodo de validacion de puesto
		private bool ValidarPuesto(){
            if(string.IsNullOrEmpty(cboPuesto.Text)){
                erpError.SetError(cboPuesto,"Debe seleccionar un puesto");
                return false;
            }
            else{
                erpError.SetError(cboPuesto,"");
                return true;
            }
		}
		//Metodo para Validar el Codigo
		 private bool ValidarCodigo(){
            int edad;
            if(!int.TryParse(txtCodigo.Text, out edad) || txtCodigo.Text == ""){
                erpError.SetError(txtCodigo,"Debe de poner un codigo");
                txtCodigo.Clear();
                txtCodigo.Focus();
                return false;
            }
            else{
                erpError.SetError(txtCodigo,"");
                return true;
            }
		}
		//Metodo de validacion la fecha
		private bool ValidarFecha(){
			int fecha;
			if(!int.TryParse(txtNaci.Text,out fecha) || txtNaci.Text==""){
				erpError.SetError(txtCodigo,"Debe de poner una fecha");
                txtNaci.Clear();
                txtNaci.Focus();
                return false;
			}else{
				erpError.SetError(txtNaci,"");
				return true;
			}
		}
		//Metodo para la validacion del Sexo del empleado
		private bool ValidarSexo(){
			if(string.IsNullOrEmpty(cboSex.Text)){
				erpError.SetError(cboSex,"Debe seleccionar un Sexo");
                return false;
			}else{
				erpError.SetError(cboSex,"");
				return true;
			}
		}
		//Metodo de validacion del estado
		private bool ValidarEstado(){
			if(radioButton1.Checked || radioButton2.Checked){
				erpError.SetError(groupBox1,"");
				return true;
			}else{
				erpError.SetError(groupBox1,"Escoja el estado en el que se encuentra el empleado");
				return false;
			}
		}
		//Metodo para comrpobar si hay otro codigo igual a otro empelado
		private bool Existe(int Codigo){
			foreach(ClaseDeDetalles Empleado in milista){
				if(Empleado.Codigo == Codigo){
					return true;
				}
			}
			return false;
		}
		//Metodo para la conexion
		public bool AgregarProducto(int codigo, string nombre, string puesto, int fecha, string sexo, string estado)
        {
            /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=Examen; user=root;pwd=root;";
            cn.Open();
            /// AGREGAR EL REGISTRO A LA BASE DE DATOS
            string strSQL = "insert into Empleados (codigo, nombre, puesto, fecha, sexo, estado)" +
                " values (@codigo, @nombre, @puesto, @fecha, @sexo, @estado)";
            MySqlCommand comando = new MySqlCommand(strSQL, cn);
            comando.Parameters.AddWithValue("Codigo", codigo);
            comando.Parameters.AddWithValue("Nombre", nombre);
            comando.Parameters.AddWithValue("Puesto",puesto);
            comando.Parameters.AddWithValue("Fecha", fecha);
            comando.Parameters.AddWithValue("Sexo", sexo);
            comando.Parameters.AddWithValue("Estado", estado);
            
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto agregado");
            /// FINALIZAMOS LA CONEXION CERRAMOS TODO

            comando.Dispose();
            cn.Close();
            cn.Dispose();
            return true;
        }
		
		//Metodo para la eliminacion
		public bool Eliminacion(int codigot)
        {
            /// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=Examen; user=root;pwd=root;";
            cn.Open();
            /// ELIMINAR EL REGISTRO A LA BASE DE DATOS

            string strSQL = "delete from Empleados(codigo, nombre, puesto, fecha, sexo, estado)" +
                "where codigo = codigot;";
            MySqlCommand comando = new MySqlCommand(strSQL, cn);
            comando.Parameters.AddWithValue("Codigo", codigot);
            
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto eliminado");
            /// FINALIZAMOS LA CONEXION CERRAMOS TODO

            comando.Dispose();
            cn.Close();
            cn.Dispose();
            return true;
        }

		
		void Button2Click(object sender, EventArgs e)
		{
			pictureBox1.Visible=false;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			pictureBox1.Visible=true;
			OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            
            if(openFileDialog.ShowDialog() == DialogResult.OK){
                string imagePath = openFileDialog.FileName;
               pictureBox1.Image = Image.FromFile(imagePath);
            }
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			//Registrar si ya esta ese mismo codigo en otro empelado
			if(Existe(int.Parse(txtCodigo.Text))){
				erpError.SetError(txtCodigo,"Ya esta ese codigo resgitrado");
				Limpiar();
				txtCodigo.Focus();
				return;
			}
			//Ver cual Estado escogio
			if(radioButton1.Checked){
				estado="Regular";
			}
			if(radioButton2.Checked){
				estado="Cotizado";
			}
			//Validacion de todos los datos
			if(ValidarCodigo()==false){
				return;
			}
			if(ValidarEstado()==false){
				return;
			}
			if(ValidarFecha()==false){
				return;
			}
			if(ValidarNombre()==false){
				return;
			}
			if(ValidarPuesto()==false){
				return;
			}
			if(ValidarSexo()==false){
			return;
			}
			//Crear una "amortiguador" para ir agregando las columnas
			ClaseDeDetalles Empleado = new ClaseDeDetalles();
			
			//Añadimiento de cada columna y su valor
			Empleado.Codigo = int.Parse(txtCodigo.Text);
			Empleado.Nombre=txtNombre.Text;
            Empleado.Puesto =cboPuesto.SelectedItem.ToString();
            Empleado.Fecha=int.Parse(txtNaci.Text);
            Empleado.Sexo=cboSex.SelectedItem.ToString();
          	Empleado.Estado=estado;

          	//Hacer la union de las listas
            milista.Add(Empleado);
            dgvDatos.DataSource=null;
            dgvDatos.DataSource =milista;
            
            AgregarProducto(int.Parse(txtCodigo.Text),txtCodigo.Text,cboPuesto.SelectedItem.ToString(),int.Parse(txtNaci.Text),
                            cboSex.SelectedItem.ToString(), estado);
            
            Limpiar();

            txtCodigo.Focus();

		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			Limpiar();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(txtCodigo.Text==""){

				erpError.SetError(txtCodigo,"Debe de escribir el codigo");
				Limpiar();
				txtNombre.Focus();
				//tsbEliminar.Enabled=false;
				return;
			}else{
				erpError.SetError(txtCodigo,"");
				DialogResult Respuesta = MessageBox.Show("Estas seguro?","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
				if(Respuesta == DialogResult.Yes){
					foreach(ClaseDeDetalles Empleado in milista){
						if(Empleado.Codigo==int.Parse(txtCodigo.Text)){
								milista.Remove(Empleado);
								Eliminacion(int.Parse(txtCodigo.Text));
								break;
						}
					}
					Limpiar();
					dgvDatos.DataSource=null;
					dgvDatos.DataSource=milista;
				}	
			}
		}
	}
}
