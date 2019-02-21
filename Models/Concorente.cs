using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace juriapp.Models
{
    public class Concorente
    {
        public int IdConcorente { get; set; }
        public string Nome { get; set; }
        public string Contacto { get; set; }
        public string Morada { get; set; }
        public List<ParticipacaoConcurso> ParticipacaoConcursos { get; set; }
    }
}