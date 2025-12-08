/*
 * Creado por SharpDevelop.
 * Usuario: Lenovo
 * Fecha: 08/12/2025
 * Hora: 02:34 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of Conversiones_de_Temperaturas.
	/// </summary>
	public partial class Conversiones_de_Temperaturas : Form
	{
		int b,a;
		double t;
		int cad;
		string tot;
		
		public Conversiones_de_Temperaturas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void RdbCaKCheckedChanged(object sender, EventArgs e)
		{
			try
	{
a=Convert.ToInt32(txtDesde.Text);
b=Convert.ToInt32(txtHasta.Text);
cad=lsbtemp.Items.Add(" Celsius Kelvin ");
if(a<b)
{}
else
	{
MessageBox.Show(" Error en los datos ", "CBTis 217");
	}
while(a<=b)
	{
for(int x=a; x<=a; x++)
	{
t=a+273.15;
tot=x.ToString() + " " + t.ToString();

	}
lsbtemp.Items.Add(tot);
a++;
	}
	}
catch(FormatException ms)
	{
//MessageBox.Show("Error en los datos de entrada","CBTis 217");
txtDesde.Text=" ";
txtHasta.Text=" ";
rdbCaK.Checked=false;
	}			
		}
		
		void RdbFaCCheckedChanged(object sender, EventArgs e)
		{
	try
	{
a=Convert.ToInt32(txtDesde.Text);
b=Convert.ToInt32(txtHasta.Text);
cad=lsbtemp.Items.Add(" Kelvin Farenheit ");
if(a<b)
	{}
else
	{
MessageBox.Show(" Error en los datos ", "CBTis 217");
	}
while(a<=b)
	{
for(int x=a; x<=a; x++)
	{
t=(a-32) * 5/9 ;
tot=x.ToString() + " " + t.ToString();
	}
lsbtemp.Items.Add(tot);
a++;
	}
	}
catch(FormatException ms)
	{
//MessageBox.Show("Error en los datos de entrada","CBTis 217");
txtDesde.Text=" ";
txtHasta.Text=" ";

rdbFaC.Checked=false;
	}			
		}
		
		void RdbKaFCheckedChanged(object sender, EventArgs e)
		{
				try
{
a=Convert.ToInt32(txtDesde.Text);
b=Convert.ToInt32(txtHasta.Text);
cad=lsbtemp.Items.Add(" Celsius Kelvin ");
if(a<b)
{}
else
{
MessageBox.Show(" Error en los datos ", "CBTis 217");
}
while(a<=b)
{
for(int x=a; x<=a; x++)
{
t=(a - 273.15) * 9/5+32;
tot=x.ToString() + " " + t.ToString();
}
lsbtemp.Items.Add(tot);
a++;
}
}
catch(FormatException ms)
{
//MessageBox.Show("Error en los datos de entrada","CBTis 217");
txtDesde.Text=" ";
txtHasta.Text=" ";
rdbKaF.Checked=false;
}			
		}
		
		void RdbKaCCheckedChanged(object sender, EventArgs e)
		{
try
{
a=Convert.ToInt32(txtDesde.Text);
b=Convert.ToInt32(txtHasta.Text);

cad=lsbtemp.Items.Add(" Kelvin Celsius ");
if(a<b)
{}
else
{
MessageBox.Show(" Error en los datos ", "CBTis 217");
}
while(a<=b)
{
for(int x=a; x<=a; x++)
{
t=a - 273.15;
tot=x.ToString() + " " + t.ToString();
}
lsbtemp.Items.Add(tot);
a++;
}
}
catch(FormatException ms)
{
//MessageBox.Show("Error en los datos de entrada","CBTis 217");
txtDesde.Text=" ";
txtHasta.Text=" ";
rdbKaC.Checked=false;
}			
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
try
{
a=Convert.ToInt32(txtDesde.Text);
b=Convert.ToInt32(txtHasta.Text);
cad=lsbtemp.Items.Add(" Celsius Farenheit ");
if(a<b)
{}
else
{
MessageBox.Show(" Error en los datos ", "CBTis 217");
}
while(a<=b)
{
for(int x=a; x<=a; x++)

{
t=(a * 9/5) + 32;
tot=x.ToString() + " " + t.ToString();
}
lsbtemp.Items.Add(tot);
a++;
}
}
catch(FormatException ms)
{
//MessageBox.Show("Error en los datos de entrada","CBTis 217");
txtDesde.Text=" ";
txtHasta.Text=" ";
rdbCaF.Checked=false;
}			
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
		try
	{
		a=Convert.ToInt32(txtDesde.Text);
		b=Convert.ToInt32(txtHasta.Text);
		cad=lsbtemp.Items.Add(" Farenheit Kelvin ");
		if(a<b)
		{}
		else
		{
		MessageBox.Show(" Error en los datos ", "CBTis 217");
		}
		while(a<=b)
		{
		for(int x=a; x<=a; x++)
		{
		t=(a - 32) * 5/9 + 273.15;
		tot=x.ToString() + " " + t.ToString();
		}
		lsbtemp.Items.Add(tot);
		a++;
		}
	}
		catch(FormatException ms)

		{
		//MessageBox.Show("Error en los datos de entrada","CBTis 217");
		txtDesde.Text=" ";
		txtHasta.Text=" ";
		rdbFaK.Checked=false;
	}			
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			this.Close();			
		}
		
		void BtnlimpiarClick(object sender, EventArgs e)
		{
					txtDesde.Text=" ";
					txtHasta.Text=" ";
					txtDesde.Focus();
					lsbtemp.Items.Clear();
					rdbCaF.Checked=false;
					rdbCaK.Checked=false;
					rdbFaC.Checked=false;
					rdbFaK.Checked=false;
					rdbKaC.Checked=false;
					rdbKaF.Checked=false;			
		}
	}
}
