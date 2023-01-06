using System;
using System.Collections.Generic;

namespace Unitofwork.Modelss;

public partial class TblMenu
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? LinkName { get; set; }
}
