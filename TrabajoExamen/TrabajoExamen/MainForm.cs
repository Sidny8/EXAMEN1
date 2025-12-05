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
			if(txtUser.Text == "USUARIO")
			{
			txtUserio.Text ="";
			txtUserio.ForeColor=Color.Black;
			}
		}
		
		void TxtContraseñaLeave(object sender, EventArgs e)
		{
			if(txtUsuario.Text == "USUARIO")
			{
			txtUsario.Text ="";
			txtUsuario.ForeColor=Color.Black;
			}
		}
		
		void BtnAccederClick(object sender, EventArgs e)
		{
			if(txtContraseña.Text==123 && txtUsuario.Text =="Admin"){
				MessageBox.Show("Digamos que cambiio")
			}
		}
	}
}
