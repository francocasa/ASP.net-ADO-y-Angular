using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class PERSONAL
    {
        D.MP_PERSONAL mp = new D.MP_PERSONAL();
        
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

        public int Eliminar(Business.PERSONAL personal)
        {
            return mp.Eliminar(personal);
        }

        public List<Business.PERSONAL> Listar()
        {
            return mp.Listar();
        }
    }
}
