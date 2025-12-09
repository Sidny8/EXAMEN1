/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 05/12/2025
 * Time: 03:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of PostresTicket.
	/// </summary>
	public partial class PostresTicket : Form
	{
		
		public double descPK;
		public double subPK;
		public double totPK;
		public PostresTicket()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PostresTicketLoad(object sender, EventArgs e)
		{
			lblDescuento.Text= descPK.ToString();
			lblSub.Text= subPK.ToString();
			lblTotal.Text= totPK.ToString();
			lblFecha.Text= DateTime.Now.ToString("dd/MM/yyyy");
		}
		
		void BtnRgresarClick(object sender, EventArgs e)
		{
			Postres post = new Postres();
			post.Show();
			this.Hide();
		}
	}
}
