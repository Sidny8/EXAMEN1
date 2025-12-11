/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 10/12/2025
 * Time: 01:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of Finnobacci.
	/// </summary>
	public partial class Finnobacci : Form
	{
		public Finnobacci()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int a = 0, b = 1, temp, n;
			n= int.Parse(txtNum.Text);
			if (n > 0) 
				lblRes.Text += "0, ";
        	if (n > 1) 
        		lblRes.Text += "1, ";
        	
       		for(int i = 2; i < n; i++)
        	{
            	temp = a + b;
            	lblRes.Text += temp.ToString();
            	lblRes.Text += ", ";
            	a = b;
            	b = temp;
        	}
    }
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtNum.Clear();
			lblRes.Text="";
		}
	}}
