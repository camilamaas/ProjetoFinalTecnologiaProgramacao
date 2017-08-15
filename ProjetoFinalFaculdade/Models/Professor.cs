﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinalFaculdade.Models
{
    public class Professor
    {
        public string Nome { get; set; }

        public int Matricula { get; set; }

        public string DataNascimento { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }

        public List<Disciplina> Disciplinas { get; set; }
    }
}