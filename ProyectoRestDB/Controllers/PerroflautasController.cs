using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoRestDB.models;


namespace ProyectoRestDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerroflautasController : ControllerBase
    {
        private List<Perroflauta> perroflautas = new List<Perroflauta>()
        {
            new Perroflauta
            {

            Id=0,
            Nombre="LeoNardo",
            OrientacionIdeologica="Budista",
            Direccion="Calle carmele 42",
            Posesiones="Mantita de perro",
            GritoComun="Carmeleeeee!",
            GritoApareamiento="Joaquineeee!"
        
            },
            new Perroflauta
            {

            Id=1,
            Nombre="NikoKill",
            OrientacionIdeologica="Pastafarista",
            Direccion="Calle Gros 42",
            Posesiones="Jose",
            GritoComun="Hya!",
            GritoApareamiento="Wiki-wiki"

            },
            new Perroflauta
            {

            Id=2,
            Nombre="Mamen",
            OrientacionIdeologica="Nihilista",
            Direccion="Calle Winsconsin 42",
            Posesiones="Clamidia",
            GritoComun="Espartanos!",
            GritoApareamiento="Au au au!"

            },
        };
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Perroflauta>> Get()
        {
            return perroflautas;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Perroflauta> Get(int id)
        {
            return perroflautas[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        }
    }
}
