using System.ComponentModel.DataAnnotations;

namespace ControleAcessoLivros.Models
{
    public class Livro
    {
        public int LivroId { get; set; }

        [Display(Name ="Nome do Livro")]
        public string NomeLivro { get; set; }

        [Display(Name ="Gênero")]
        public string Genero { get; set; }
        public Autor Autor { get; set; }

        [Display(Name = "Autor")]
        public int AutorId { get; set; }


        [Display(Name = "Ano de Lançamento")]
        public int AnoLancamento { get; set; }

        public Leitura Leitura { get; set; }

        
    }
}
