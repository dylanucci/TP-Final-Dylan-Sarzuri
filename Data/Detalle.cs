using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data;

public partial class Detalle
{
    [Key]
    public int IdDetalle { get; set; }

    public int CompraId { get; set; }

    public int ProductoId { get; set; }

    public int PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    public int SubTotal { get; set; }

    public virtual Compra Compra { get; set; } = null!;
}
