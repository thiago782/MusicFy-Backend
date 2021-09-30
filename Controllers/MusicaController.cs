using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/musica")]
    public class MusicaController : ControllerBase
    {
        private readonly DataContext _context;
        //Construtor
        public MusicaController(DataContext context) => _context = context;
        //POST: api/musica/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Musica musica)
        {
            _context.Musicas.Add(musica);
            _context.SaveChanges();
            return Created("", musica);
        }

        //GET: api/musica/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Musicas.ToList());

        //GET: api/musica/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {

            Musica musica = _context.Musicas.Find(id);
            if (musica == null)
            {
                return NotFound();
            }
            return Ok(musica);
        }
        //DELETE: api/musica/delete/piao
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            Musica musica = _context.Musicas.FirstOrDefault(
                x => x.nome == name
            );
            if (musica == null)
            {
                return NotFound();
            }
            _context.Musicas.Remove(musica);
            _context.SaveChanges();
            return Ok(_context.Musicas.ToList());
        }
        //PUT: api/musica/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Musica musica)
        {
            _context.Musicas.Update(musica);
            _context.SaveChanges();
            return Ok(musica);
        }


    }

}