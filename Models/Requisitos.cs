﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace juriapp.Models
{
    public class Requisitos
    {
        public int IdRequisitos { get; set; }
        public int Texto { get; set; }
        public int PontuacaoMaxima { get; set; }
        public int PontuacaoMinimo{ get; set; }
        public TipoAvalicao TipoAvalicao { get; set; }
        public int IdConcurso { get; set; }
         public Concurso Concurso { get; set; }
        public List<Avalicao> Avalicoes { get; set; }
    }

    public enum TipoAvalicao
    {
        Quantitativa=1,
        Qualitativa=2
    }
}