using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class HIJOS
    {
        D.MP_HIJOS mp = new D.MP_HIJOS();

        public int Grabar(Business.HIJOS hijos)
        {
            int res = 0;
            if (hijos.IdPersonal == 0)
            {
                res = mp.Agregar(hijos);
            }
            else
            {
                res = mp.Modificar(hijos);
            }
            return res;
        }

        public int Eliminar(Business.HIJOS hijos)
        {
            return mp.Eliminar(hijos);
        }

        public List<Business.HIJOS> Listar()
        {
            return mp.Listar();
        }
    }
}
