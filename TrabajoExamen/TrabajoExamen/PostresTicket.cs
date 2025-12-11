/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 05/12/2025
 * Time: 03:24 p. m.
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
	/// Description of PostresTicket.
	/// </summary>
	public partial class PostresTicket : Form
	{
		
		public double descPK;
		public double subPK;
		public double totPK;
		public double pagPK;
		public double camPK;
		public ListViewItem filaPK = new ListViewItem();
		List<ClaseDePostres1> pko = new List<ClaseDePostres1>();
		
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
		
			public void ListPK(){
			pko.Clear();
			pko = new ClaseDePostres1().ObtenerPostres();
   			 for (int i = 0; i < pko.Count; i++)
    		{
   			 	ListViewItem fila = new ListViewItem(pko[i].Producto.ToString());
   			 	fila.SubItems.Add(pko[i].Precio.ToString());
   			 	fila.SubItems.Add(pko[i].Cantidad.ToString());
   			 	fila.SubItems.Add(pko[i].Total.ToString());
   			 	listView1.Items.Add(fila);
   			 } return ;
		
		}
		
		void PostresTicketLoad(object sender, EventArgs e)
		{
			pictureBox1.Image = Resource1.ticket;
			lblDescuento.Text= descPK.ToString();
			lblSub.Text= subPK.ToString();
			lblTotal.Text= totPK.ToString();
			lblFecha.Text= DateTime.Now.ToString("dd/MM/yyyy");
			lblPago.Text= pagPK.ToString();
			lblCambio.Text= camPK.ToString();
			ListPK();
		}
		
		void BtnRgresarClick(object sender, EventArgs e)
		{
			Postres post = new Postres();
			post.Show();
			this.Hide();
		}
	}
}
