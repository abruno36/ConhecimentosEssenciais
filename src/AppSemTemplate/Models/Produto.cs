﻿using AppSemTemplate.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppSemTemplate.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string? Nome { get; set; }

        [NotMapped]
        [DisplayName("Imagem do Produto")]
        public IFormFile? ImagemUpload { get; set; }

        public string? Imagem { get; set; }

        [Moeda]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        public bool Processado { get; set; }
    }
}
