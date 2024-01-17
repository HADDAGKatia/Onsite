using System;
using System.Collections.Generic;

namespace Onsite.Infrastructure.Models;

public partial class Etudiant
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
