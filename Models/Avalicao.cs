using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace juriapp.Models
{
    public class Avalicao
    {
        public int IdAvalicao { get; set; }
        public int Avalicaoatribuida { get; set; }
        public string Obs { get; set; }
         public int IdRequisitos { get; set; }
        public Requisitos Requisitos { get; set; }

    }
}