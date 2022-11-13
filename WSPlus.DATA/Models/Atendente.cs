﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSPlus.DATA.Models
{
    public partial class Atendente
    {
        public Atendente()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Codigo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Nome { get; set; }
        [Column("CPF")]
        [StringLength(14)]
        [Unicode(false)]
        public string Cpf { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }

        [InverseProperty("IdAtendenteNavigation")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}