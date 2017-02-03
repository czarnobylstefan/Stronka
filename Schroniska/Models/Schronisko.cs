using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schroniska.Models
{
    public class Schronisko
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Miejscowosc { get; set; }
        public int Ocena { get; set; }
    }
}