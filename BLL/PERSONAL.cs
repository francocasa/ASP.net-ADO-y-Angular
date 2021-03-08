using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class PERSONAL
    {
        Data.MP_PERSONAL mp = new Data.MP_PERSONAL();
        
        public int Grabar(Business.PERSONAL personal)
        {
            int res = 0;
            if(personal.IdPersonal == 0)
            {
                res = mp.Agregar(personal);
            }
            else
            {
                res = mp.Modificar(personal);
            }
            return res;
        }

        public int Eliminar(int idPersonal)
        {
            return mp.Eliminar(idPersonal);
        }

        public List<Business.PERSONAL> Listar()
        {
            return mp.Listar();
        }

        public void Agregar(Business.PERSONAL personal)
        {
            mp.Agregar(personal);
        }

        public void Modificar(Business.PERSONAL personal)
        {
            mp.Modificar(personal);
        }
    }
}
