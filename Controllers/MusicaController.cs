using System;
using System.Collections.Generic;
using System.Linq;
using MusicFy_Backend.Data;
using MusicFy_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace MusicFy_Backend.Controllers
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


    }

}