using System.ComponentModel.DataAnnotations;

namespace ControleAcessoLivros.Models
{
    public class Leitura
    {
        public int LeituraId { get; set; }
        public Leitor Leitor { get; set; }


        [Display(Name = "Nome do Leitor")]
        public int LeitorId { get; set; }


        public Livro Livro { get; set; }

        [Display(Name = "Nome do Livro")]
        public int LivroId { get; set; }

        [Display(Name = "Status")]
        public StatusLivro StatusLivro { get; set; }

        [Display(Name = "Status")]
        public int StatusLivroId { get; set; }
    }
}
