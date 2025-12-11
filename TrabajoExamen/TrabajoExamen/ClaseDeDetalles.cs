/*
 * Creado por SharpDevelop.
 * Usuario: cindy
 * Fecha: 06/12/2025
 * Hora: 03:19 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace TrabajoExamen
{
	/// <summary>
	/// Description of ClaseDeDetalles.
	/// </summary>
	public class ClaseDeDetalles
	{
		public int Codigo{get; set;}
		public string Nombre{get;set;}
		public string Puesto{get;set;}
		public string Fecha{get; set;}
		public string Sexo{get;set;}
		public string Estado{get;set;}
		
		//Metodo de recolectar todos los datos
		public List<ClaseDeDetalles> ObtenerEmpleados()
		{
   			 MySqlConnection cn = new MySqlConnection();
    		/// CREAR LA CONEXIÓN, CONFIGURAR Y ABRIRLA
   			cn.ConnectionString = cn.ConnectionString = "server=localhost; database=Examen; user=root; pwd=root";
    		cn.Open();

   			List<ClaseDeDetalles> adm = new List<ClaseDeDetalles>();
   			 string strSQL = "select * from Empleados";
   			 MySqlCommand comando = new MySqlCommand(strSQL, cn);
   			 MySqlDataReader dr = comando.ExecuteReader();
   			 while (dr.Read())
   			 {
       			ClaseDeDetalles x = new ClaseDeDetalles();
        		x.Codigo = dr.GetInt32("codigo");
        		x.Nombre = dr.GetString("nombre");
        		x.Puesto = dr.GetString("puesto");
        		x.Fecha = dr.GetString("fecha");
        		x.Sexo = dr.GetString("sexo");
        		x.Estado = dr.GetString("estado");
        		adm.Add(x);
   		 		}
    			comando.Dispose();

   		 		cn.Close();
   	 			cn.Dispose();
    			return adm;
			}
		public ClaseDeDetalles()
		{
		}
	}
}
