using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using APIConcessionaria;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIConcessionaria.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly AppDbContext _Context;

        public EstoqueController(AppDbContext context)
        {
            _Context = context;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody]EstoqueDeCarros estoqueDeCarros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _Context.Add(estoqueDeCarros);
            _Context.SaveChanges();

            return CreatedAtAction(nameof(VisualizarPorPlaca), new {placa = estoqueDeCarros.Placa}, estoqueDeCarros);
        }

        [HttpGet("{placa}")]
        public IActionResult VisualizarPorPlaca(string placa)
        {
            var carro = _Context.EstoqueDeCarros.Find(placa);

            if (carro == null)
            {
                return NotFound($"O carro com a placa {placa} não foi encontrado");
            }

            return Ok(carro);
        }

        [HttpGet]
        public IActionResult Visualizar()
        {
            return  Ok(_Context.EstoqueDeCarros.ToList());
        }

        [HttpPut]
        public IActionResult Atualizar(string placa, [FromBody] EstoqueDeCarros carroAtualizado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carroExistente = _Context.EstoqueDeCarros.Find(placa);

            if (carroExistente == null)
            {
                return NotFound($"O carro com a placa {placa} não foi encontrado.");
            }

            // Atualizando propriedades
            carroExistente.Fabricante = carroAtualizado.Fabricante;
            carroExistente.Modelo = carroAtualizado.Modelo;
            carroExistente.Ano = carroAtualizado.Ano;
            carroExistente.Quilometragem = carroAtualizado.Quilometragem;
            carroExistente.Situacao = carroAtualizado.Situacao;
            carroExistente.Fipe = carroAtualizado.Fipe;
            carroExistente.ValorComprado = carroAtualizado.ValorComprado;
            carroExistente.ValorVenda = carroAtualizado.ValorVenda;

            _Context.SaveChanges();
            return Ok($"{carroExistente}\n\nAtualizado com sucesso.");
        }

        [HttpDelete("{placa}")]
            public IActionResult Apagar(string placa)
            {
                var carroExistente = _Context.EstoqueDeCarros.Find(placa);

                if (carroExistente == null)
                {
                    return NotFound($"O carro com a placa {placa} não foi encontrado.");
                }

                _Context.EstoqueDeCarros.Remove(carroExistente);
                _Context.SaveChanges();

                return NoContent();
            }

    }
}