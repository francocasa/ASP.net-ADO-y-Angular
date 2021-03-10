using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrancoCasanova.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {

        Entity.PERSONAL entity = new Entity.PERSONAL();

        [HttpGet]
        public IEnumerable<Business.PERSONAL> Lista()
        {

            List<Business.PERSONAL> lp = new List<Business.PERSONAL>();
            foreach (Business.PERSONAL per in entity.Listar())
            {
                Business.PERSONAL p = new Business.PERSONAL();
                p.IdPersonal = per.IdPersonal;
                p.FchIngreso = per.FchIngreso;
                p.ApPaterno = per.ApPaterno;
                p.ApMaterno = per.ApMaterno;
                p.Nombre1 = per.Nombre1;
                p.Nombre2 = per.Nombre2;
                p.FchNac = per.FchNac;
                p.NombreCompleto = per.NombreCompleto;

                lp.Add(p);
            }

            return lp;
        }

        [HttpGet("{IdPersonal}")]
        public IEnumerable<Business.PERSONAL> VerPersonal(int IdPersonal)
        {

            List<Business.PERSONAL> lp = new List<Business.PERSONAL>();
            foreach (Business.PERSONAL per in entity.VerPersonal(IdPersonal))
            {
                Business.PERSONAL p = new Business.PERSONAL();
                p.IdPersonal = per.IdPersonal;
                p.FchIngreso = per.FchIngreso;
                p.ApPaterno = per.ApPaterno;
                p.ApMaterno = per.ApMaterno;
                p.Nombre1 = per.Nombre1;
                p.Nombre2 = per.Nombre2;
                p.FchNac = per.FchNac;
                p.NombreCompleto = per.NombreCompleto;

                lp.Add(p);
            }

            return lp;
        }

        [HttpDelete("{IdPersonal}")]
        public void Eliminar([FromRoute] int IdPersonal)
        {

            entity.Eliminar(IdPersonal);
        }

        [HttpPost]
        public void Agregar(Business.PERSONAL per)
        {

            Business.PERSONAL p = new Business.PERSONAL();
            p.IdPersonal = per.IdPersonal;
            p.FchIngreso = per.FchIngreso;
            p.ApPaterno = per.ApPaterno;
            p.ApMaterno = per.ApMaterno;
            p.Nombre1 = per.Nombre1;
            p.Nombre2 = per.Nombre2;
            p.FchNac = per.FchNac;
            p.NombreCompleto = per.NombreCompleto;

            entity.Agregar(p);
        }

        [HttpPut]
        public void Modificar(Business.PERSONAL per)
        {

            Business.PERSONAL p = new Business.PERSONAL();
            p.IdPersonal = per.IdPersonal;
            p.FchIngreso = per.FchIngreso;
            p.ApPaterno = per.ApPaterno;
            p.ApMaterno = per.ApMaterno;
            p.Nombre1 = per.Nombre1;
            p.Nombre2 = per.Nombre2;
            p.FchNac = per.FchNac;
            p.NombreCompleto = per.NombreCompleto;

            entity.Modificar(p);
        }





    }
}
