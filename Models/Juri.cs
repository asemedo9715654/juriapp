using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace juriapp.Models
{
    public class Juri
    {
        public int IdJuri { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public List<JuriConcurso> JuriConcursos { get; set; }
    }
}