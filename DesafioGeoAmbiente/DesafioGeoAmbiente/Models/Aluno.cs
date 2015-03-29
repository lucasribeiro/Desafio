using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioGeoAmbiente.Models
{
    public class Aluno
    {
        public string  Nome { get; set; }
        public int RA { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
    }
}