﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Models
{
    [Keyless]
    public partial class VwLivroClienteEmprestimo
    {
        //[Required]
        [Column("cliCPF")]
        [StringLength(14)]
        [Display(Name = "CPF")]
        public string CliCpf { get; set; }

       // [Required]
        [Column("cliNome")]
        [StringLength(200)]
        [Display(Name = "Nome")]
        public string CliNome { get; set; }

       // [Required]
        [Column("livroNome")]
        [StringLength(50)]
        [Display(Name = "Livro")]
        public string LivroNome { get; set; }

        public int Id { get; set; }

        public int LceIdCliente { get; set; }

        public int LceIdLivro { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Saída")]
        [Column(TypeName = "datetime")]
        public DateTime LceDataEmprestimo { get; set; }

        [Column(TypeName = "datetime")]
        [DataType(DataType.Date)]
        [Display(Name = "Retorno")]
        public DateTime LceDataEntrega { get; set; }

        [Display(Name = "Entregue")]
        public bool LceEntregue { get; set; }

        [Required]
        [StringLength(3)]          
        [Display(Name = "Atrasado")]
        public string LceAtrazo { get; set; }
    }
}