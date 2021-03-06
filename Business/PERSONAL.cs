using System;

namespace Business
{
    public class PERSONAL
    {

        private int idPersonal;
        private String apPaterno;
        private String apMaterno;
        private String nombre1;
        private String nombre2;
        private String nombreCompleto;
        private String fchNac;
        private String fchIngreso;

        public String FchIngreso
        {
            get { return fchIngreso; }
            set { fchIngreso = value; }
        }


        public String FchNac
        {
            get { return fchNac; }
            set { fchNac = value; }
        }


        public String NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }


        public String Nombre2
        {
            get { return nombre2; }
            set { nombre2 = value; }
        }



        public String Nombre1
        {
            get { return nombre1; }
            set { nombre1 = value; }
        }



        public String ApMaterno
        {
            get { return apMaterno; }
            set { apMaterno = value; }
        }


        public String ApPaterno
        {
            get { return apPaterno; }
            set { apPaterno = value; }
        }


        public int IdPersonal
        {
            get { return idPersonal; }
            set { idPersonal = value; }
        }


    }
}
