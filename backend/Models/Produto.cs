// ==================================================
// MODELO DE PRODUTO
// Representa um produto que será utilizado
// pelo sistema MartVerdi.
// ==================================================

namespace MartVerdi.Models
{
    public class Produto
    {
        // Identificador único do produto
        public int Id { get; set; }

        // Nome do produto
        public string Nome { get; set; } = string.Empty;

        // Marca do produto
        public string Marca { get; set; } = string.Empty;

        // Categoria do produto
        public string Categoria { get; set; } = string.Empty;

        // Peso ou quantidade do produto
        public string Peso { get; set; } = string.Empty;

        // Preço normal
        public decimal Preco { get; set; }

        // Preço promocional
        public decimal? PrecoPromocional { get; set; }

        // Nome/caminho da imagem do produto
        public string Imagem { get; set; } = string.Empty;

        // Indica se o produto está em oferta
        public bool Oferta { get; set; }

        // Descrição do produto
        public string Descricao { get; set; } = string.Empty;
    }
}
