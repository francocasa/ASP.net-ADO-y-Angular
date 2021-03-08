using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class HIJOS
    {
        Data.MP_HIJOS mp = new Data.MP_HIJOS();

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

        public int Eliminar(int IdDerhab)
        {
            return mp.Eliminar(IdDerhab);
        }

        public List<Business.HIJOS> Listar()
        {
            return mp.Listar();
        }


        public void Agregar(Business.HIJOS hijo)
        {
            mp.Agregar(hijo);
        }

        public void Modificar(Business.HIJOS hijo)
        {
            mp.Modificar(hijo);
        }
    }
}
