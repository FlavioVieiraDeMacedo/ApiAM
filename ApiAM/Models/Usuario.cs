﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAM.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public double Saldo { get; set; }
        public ICollection<Transacao> Transacoes { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }
}