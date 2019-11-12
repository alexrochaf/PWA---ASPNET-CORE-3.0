using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PWApp.Models
{
    public class SuperHeroi
    {
        public SuperHeroi()
        {
        }

        public SuperHeroi(int? id, string nome, string superPoder, string foto)
        {
            Id = id ?? 0;
            Nome = nome;
            SuperPoder = superPoder;
            Foto = foto;
        }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Nome"), Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Superpoder"), Required(ErrorMessage = "Campo {0} é obrigatório")]
        public string SuperPoder { get; set; }

        [Display(Name = "Foto")]
        public string Foto { get; set; }
    }
}
