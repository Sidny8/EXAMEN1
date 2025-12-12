/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 04/12/2025
 * Time: 06:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int intentos = 1;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtContraseñaEnter(object sender, EventArgs e)
		{
			if(txtContraseña.Text == "")
			{
				txtContraseña.Text ="";
				txtContraseña.ForeColor=Color.Black;
				txtContraseña.UseSystemPasswordChar=true;
			}
		}
		
		void TxtContraseñaLeave(object sender, EventArgs e)
		{
			if(txtContraseña.Text == "")
			{
				txtContraseña.Text ="";
				txtContraseña.ForeColor=Color.DimGray;
				txtContraseña.UseSystemPasswordChar=false;
			}
		}
		
		void BtnAccederClick(object sender, EventArgs e)
		{
			if(txtContraseña.Text== "123" && txtUsuario.Text =="Admin"){
				Form1 Menu = new Form1();
				Menu.Show();
				this.Hide();
			}else{
				MessageBox.Show("Usuario o contraseña imcorrectos","Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
				intentos+=1;
				txtUsuario.Clear();
				txtContraseña.Clear();
				if(intentos > 3)
				{
				MessageBox.Show("Has Agotado tus 3 intentos","No puedes acceder",MessageBoxButtons.OK, MessageBoxIcon.Question);
				Application.Exit();
				}
			}
		}
		
		void TxtUsuarioEnter(object sender, EventArgs e)
		{
			if(txtUsuario.Text == "USUARIO")
			{
				txtUsuario.Text ="";
				txtUsuario.ForeColor=Color.Black;
			}
		}
		
		void TxtUsuarioLeave(object sender, EventArgs e)
		{
			if(txtUsuario.Text == "USUARIO")
			{
				txtUsuario.Text ="";
				txtUsuario.ForeColor=Color.DimGray;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			pictureBox1.Image=Resource1.login;
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
