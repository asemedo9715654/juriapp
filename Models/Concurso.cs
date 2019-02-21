using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace juriapp.Models
{
    public class Concurso
    {
        public int IdConcurso { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Obs { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal? PrecoBase { get; set; }
        public List<JuriConcurso> JuriConcursos { get; set; }
        public List<ParticipacaoConcurso> ParticipacaoConcursos { get; set; }
        public List<Requisitos> Requisitos { get; set; }
    }
}