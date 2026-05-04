using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos32427421.Data;
using ValeAtivos32427421.Models;

namespace ValeAtivos32427421.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EquipamentosControllers : ControllerBase
    {
        private readonly AppDbContext _context;
        public EquipamentosControllers(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEquipamentos()
        {
            var equipamentos = await _context.Equipamentos.ToListAsync();
            return Ok(equipamentos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEquipamento(int id)
        {
            var equipamento = await _context.Equipamentos.FindAsync(id);
            if(equipamento == null)
            {
                return NotFound();
            }
            return Ok(equipamento);
        }

        [HttpPost]
        public async Task<ActionResult> PostEquipamento(Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEquipamento), new {id = equipamento.Id}, equipamento);
        }



    }
}