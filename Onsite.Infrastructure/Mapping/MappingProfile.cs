using AutoMapper;
using Onsite.Domain.Entities;
using Onsite.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Onsite.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Etudiant, EtudiantEntity>().ReverseMap();
            CreateMap<Matiere, MatiereEntity>().ReverseMap();
        }
    }
}
