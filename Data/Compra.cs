using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data;

public partial class Compra
{
    [Key]
    public int IdCompra { get; set; }

    public int ClienteId { get; set; }

    public DateTime Fecha { get; set; }

    public int? Total { get; set; }
    public virtual ICollection<Detalle> Detalles { get; set; } = new List<Detalle>();
}
