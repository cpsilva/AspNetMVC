﻿using System.ComponentModel.DataAnnotations;

namespace AspNetMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Nome { get; set; }

        [Range(0.0, 10000.0)]
        public float Preco { get; set; }

        public CategoriaDoProduto Categoria { get; set; }

        public int? CategoriaId { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }
    }
}