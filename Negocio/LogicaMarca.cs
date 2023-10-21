﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using Dominio;

namespace Negocio
{
    public class LogicaMarca
    {
        public List<Marca> MarcaList()
        { 
            List<Marca> marcas = new List<Marca>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsutar("select id, descripcion from Marcas;");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                { 
                Marca marca = new Marca();

                    marca.Id = (int)accesoDatos.Lector["Id"];
                    marca.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    marcas.Add(marca);  
                
                }
                return marcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                accesoDatos.CerrarConection();
            }
        
        }

        public void MarcaAdd(Marca Nuevo)
        {

            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setConsutar("insert into Marcas(Descripcion)values(@Descripcion);");
                accesoDatos.setearParametro("@Descripcion", Nuevo.Descripcion);
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConection();

            }
        }
    }
}
