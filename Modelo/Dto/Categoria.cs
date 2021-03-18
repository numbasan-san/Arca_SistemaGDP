using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Dto
{
    class Categoria
    {
        internal readonly object TXT_Nombre;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}
