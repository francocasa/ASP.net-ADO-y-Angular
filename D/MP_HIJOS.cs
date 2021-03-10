using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data
{

    public class MP_HIJOS
    {
        
        private Accesso accesso = new Accesso();


        public List<Business.HIJOS> Listar(int IdPersonal)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdPersonal", IdPersonal));


            DataTable tabla = accesso.Leer("ListarHijos", parameters);

            List<Business.HIJOS> hijos = new List<Business.HIJOS>();
            foreach (DataRow registro in tabla.Rows)
            {
                Business.HIJOS hijo = new Business.HIJOS();

                hijo.IdDerHab = int.Parse(registro["IdDerhab"].ToString());
                hijo.IdPersonal = int.Parse(registro["IdPersonal"].ToString());
                hijo.ApPaterno = registro["ApPaterno"].ToString();
                hijo.ApMaterno = registro["ApMaterno"].ToString();
                hijo.Nombre1 = registro["Nombre1"].ToString();
                hijo.Nombre2 = registro["Nombre2"].ToString();
                hijo.NombreCompleto = registro["NombreCompleto"].ToString();
                hijo.FchNac = registro["FchNac"].ToString();
                
                hijos.Add(hijo);
            }
            return hijos;

        }


        public List<Business.HIJOS> VerHijo(int IdDerHab)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdDerHab", IdDerHab));


            DataTable tabla = accesso.Leer("VerHijo", parameters);

            List<Business.HIJOS> hijos = new List<Business.HIJOS>();
            foreach (DataRow registro in tabla.Rows)
            {
                Business.HIJOS hijo = new Business.HIJOS();

                hijo.IdDerHab = int.Parse(registro["IdDerhab"].ToString());
                hijo.IdPersonal = int.Parse(registro["IdPersonal"].ToString());
                hijo.ApPaterno = registro["ApPaterno"].ToString();
                hijo.ApMaterno = registro["ApMaterno"].ToString();
                hijo.Nombre1 = registro["Nombre1"].ToString();
                hijo.Nombre2 = registro["Nombre2"].ToString();
                hijo.NombreCompleto = registro["NombreCompleto"].ToString();
                hijo.FchNac = registro["FchNac"].ToString();

                hijos.Add(hijo);
            }
            return hijos;

        }


        public int Agregar(Business.HIJOS hijo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdPersonal", hijo.IdPersonal));
            parameters.Add(accesso.CrearParametro("@IdDerHab", hijo.IdDerHab));
            parameters.Add(accesso.CrearParametro("@ApPaterno", hijo.ApPaterno));
            parameters.Add(accesso.CrearParametro("@ApMaterno", hijo.ApMaterno));
            parameters.Add(accesso.CrearParametro("@Nombre1", hijo.Nombre1));
            parameters.Add(accesso.CrearParametro("@Nombre2", hijo.Nombre2));
            parameters.Add(accesso.CrearParametro("@FchNac", hijo.FchNac));

            return accesso.Escribir("InsertarHijos", parameters);

        }
        public int Modificar(Business.HIJOS hijo)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdPersonal", hijo.IdPersonal));
            parameters.Add(accesso.CrearParametro("@IdDerHab", hijo.IdDerHab));
            parameters.Add(accesso.CrearParametro("@ApPaterno", hijo.ApPaterno));
            parameters.Add(accesso.CrearParametro("@ApMaterno", hijo.ApMaterno));
            parameters.Add(accesso.CrearParametro("@Nombre1", hijo.Nombre1));
            parameters.Add(accesso.CrearParametro("@Nombre2", hijo.Nombre2));
            parameters.Add(accesso.CrearParametro("@FchNac", hijo.FchNac));

            return accesso.Escribir("ActualizarHijos", parameters);

        }
        public int Eliminar(int IdDerhab)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(accesso.CrearParametro("@IdDerHab", IdDerhab));

            return accesso.Escribir("EliminarHijo", parameters);
        }
    }
}
