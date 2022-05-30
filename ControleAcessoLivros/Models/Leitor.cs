using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleAcessoLivros.Models
{
    public class Leitor
    {
        public int LeitorId { get; set; }

        [Display(Name = "Nome do Leitor")]
        public string NomeLeitor { get; set; }
        public string Email { get; set; }
        public double Telefone { get; set; }

        public ICollection<Leitura> leituras { get; set; }
    }
}
