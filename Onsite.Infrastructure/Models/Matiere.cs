using System;
using System.Collections.Generic;

namespace Onsite.Infrastructure.Models;

public partial class Matiere
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public string? Coefficient { get; set; }
}
