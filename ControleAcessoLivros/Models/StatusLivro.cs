using System.Collections.Generic;

namespace ControleAcessoLivros.Models
{
    public class StatusLivro
    {
        public int StatusLivroId { get; set; }
        public string Status { get; set; }

        public ICollection<Leitura> Leitura { get; set; }
    }
}
