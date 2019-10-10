using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public string Id { get; set; } 

        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O campo Gênero é obrigatório")]
        [Display(Name = "Gênero")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo Avaliação é obrigatório")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 0 a 5")]
        public int Avaliacao { get; set; }
    }
}
