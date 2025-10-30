using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data;

public partial class Compra
{
    [Key]
    public int IdCompra { get; set; }

    public int ClienteId { get; set; }

    public DateOnly Fecha { get; set; }

    public string? Total { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<Detalle> Detalles { get; set; } = new List<Detalle>();
}
