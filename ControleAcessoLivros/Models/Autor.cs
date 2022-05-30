using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleAcessoLivros.Models
{
    public class Autor
    {
        public int AutorId { get; set; }

        [Display(Name = "Nome do Autor")]
        public string NomeAutor { get; set; }
        public string Email { get; set; }

        public ICollection<Livro> Livros { get; set; }

    }
}
