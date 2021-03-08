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
    public class HijosController : ControllerBase
    {

        Entity.HIJOS entity = new Entity.HIJOS();

        [HttpGet]
        public List<Business.HIJOS> Lista()
        {

            List<Business.HIJOS> lp = new List<Business.HIJOS>();
            foreach (Business.HIJOS per in entity.Listar())
            {
                Business.HIJOS p = new Business.HIJOS();
                p.IdPersonal = per.IdPersonal;
                p.IdDerHab = per.IdDerHab;
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

        [HttpDelete("{IdDerHab}")]
        public void Eliminar([FromRoute] int IdDerHab)
        {

            entity.Eliminar(IdDerHab);
        }

        [HttpPost]
        public void Agregar(Business.HIJOS hij)
        {

            Business.HIJOS p = new Business.HIJOS();
            p.IdPersonal = hij.IdPersonal;
            p.IdDerHab = hij.IdDerHab;
            p.ApPaterno = hij.ApPaterno;
            p.ApMaterno = hij.ApMaterno;
            p.Nombre1 = hij.Nombre1;
            p.Nombre2 = hij.Nombre2;
            p.FchNac = hij.FchNac;
            p.NombreCompleto = hij.NombreCompleto;

            entity.Agregar(p);
        }

        [HttpPut]
        public void Modificar(Business.HIJOS hij)
        {

            Business.HIJOS p = new Business.HIJOS();
            p.IdPersonal = hij.IdPersonal;
            p.IdDerHab = hij.IdDerHab;
            p.ApPaterno = hij.ApPaterno;
            p.ApMaterno = hij.ApMaterno;
            p.Nombre1 = hij.Nombre1;
            p.Nombre2 = hij.Nombre2;
            p.FchNac = hij.FchNac;
            p.NombreCompleto = hij.NombreCompleto;

            entity.Modificar(p);
        }



    }
}
