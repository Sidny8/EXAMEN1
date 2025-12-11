/*
 * Creado por SharpDevelop.
 * Usuario: cindy
 * Fecha: 10/12/2025
 * Hora: 10:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of ClaseDePostres1.
	/// </summary>
	public class ClaseDePostres1
	{
		public int clave{get;set;}
		public string Producto{get; set;}
		public double Precio{get;set;}
		public int Cantidad{get;set;}
		public double Total{get; set;}
		
		
		
		public List<ClaseDePostres1> ObtenerPostres()
		{
   			 MySqlConnection cn = new MySqlConnection();
    		/// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
   			cn.ConnectionString = cn.ConnectionString = "server=localhost; database=Examen; user=root; pwd=root";
    		cn.Open();

   			List<ClaseDePostres1> adm = new List<ClaseDePostres1>();
   			 string strSQL = "select * from Productos";
   			 MySqlCommand comando = new MySqlCommand(strSQL, cn);
   			 MySqlDataReader dr = comando.ExecuteReader();
   			 while (dr.Read())
   			 {
       			ClaseDePostres1 x = new ClaseDePostres1();
       			x.clave = dr.GetInt32("clave");
        		x.Producto = dr.GetString("productos");
        		x.Precio = dr.GetDouble("precio");
        		x.Cantidad = dr.GetInt32("cantidad");
        		x.Total = dr.GetDouble("total");
        		adm.Add(x);
   		 		}
    			comando.Dispose();

   		 		cn.Close();
   	 			cn.Dispose();
    			return adm;
		}
		
		
		public ClaseDePostres1()
		{
		}
	}
}
