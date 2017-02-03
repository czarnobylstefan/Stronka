using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schroniska.Models
{
    public class Recenzja
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int Ocena { get; set; }
        public int IdSchroniska { get; set; }
    }
}