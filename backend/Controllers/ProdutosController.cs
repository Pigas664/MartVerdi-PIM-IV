// ==================================================
// CONTROLLER DE PRODUTOS
// Responsável pelas requisições relacionadas
// aos produtos do MartVerdi.
// ==================================================

using Microsoft.AspNetCore.Mvc;
using MartVerdi.Models;

namespace MartVerdi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        // ==================================================
        // GET: /api/produtos
        // Retorna uma lista de produtos.
        // ==================================================

        [HttpGet]
        public IActionResult GetProdutos()
        {
            // Criamos um produto temporariamente.
            // Mais para frente esses dados virão do SQL Server.

            var produtos = new List<Produto>
            {
                new Produto
                {
                    Id = 1,
                    Nome = "Arroz Tio João",
                    Marca = "Tio João",
                    Categoria = "Mercearia",
                    Peso = "5kg",
                    Preco = 24.90m,
                    PrecoPromocional = 22.90m,
                    Imagem = "arroz-tio-joao.jpg",
                    Oferta = true,
                    Descricao = "Arroz branco tipo 1"
                }
            };

            // Retorna a lista como resposta da API.
            return Ok(produtos);
        }
    }
}