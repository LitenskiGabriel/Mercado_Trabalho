﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado_Trabalho.Entidade
{
    public class Cliente
    {
        public Guid Id {  get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }

    }
}
