using Onsite.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onsite.Domain.Entities
{
    public class MatiereEntity : BaseEntity
    {
        public int Id { get; set; }

        public string? Nom { get; set; }

        public string? Coefficient { get; set; }
    }
}
