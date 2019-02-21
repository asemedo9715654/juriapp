using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace juriapp.Models
{
    public class JuriConcurso
    {
        public int IdConcurso { get; set; }
        public int IdJuri { get; set; }
        public Juri Juri { get; set; }
        public Juri Concurso { get; set; }
    }
}