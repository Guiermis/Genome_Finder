using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Genome_Finder.Models
{
    public class Base_Nitrogen
    {
        [Required(ErrorMessage = "Digite a Espécie do Gene")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Código do NCBI")]
        public string NCBICod { get; set; }

        [Required(ErrorMessage = "Digite a Base Nitrogenada")]
        public string Gene { get; set; }

        public int searchnum = 1;

    }
}
