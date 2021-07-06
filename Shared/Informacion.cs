using System;
using System.Collections.Generic;

#nullable disable

namespace ArticulosTecnologicos.Shared.Models
{
    public partial class Informacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalles { get; set; }
        public long Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Stock { get; set; }
        public bool Existencia { get; set; }
    }
}
