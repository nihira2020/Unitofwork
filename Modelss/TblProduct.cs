using System;
using System.Collections.Generic;

namespace Unitofwork.Modelss;

public partial class TblProduct
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public decimal? Amount { get; set; }
}
