// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSPlus.DATA.Models
{
    public partial class Secao
    {
        public Secao()
        {
            Produto = new HashSet<Produto>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Codigo { get; set; }
        public bool Ativa { get; set; }

        [InverseProperty("IdSecaoProdutoNavigation")]
        public virtual ICollection<Produto> Produto { get; set; }
    }
}