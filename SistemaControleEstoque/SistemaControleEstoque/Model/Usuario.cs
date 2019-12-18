﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleEstoque.Model
{
    public class Usuario : ControleUsuario
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
