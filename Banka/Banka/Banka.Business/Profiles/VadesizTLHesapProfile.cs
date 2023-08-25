using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.VadeliTLHesap;
using Banka.Model.Dtos.VadesizTLHesap;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class VadesizTLHesapProfile : Profile
    {
        public VadesizTLHesapProfile()
        {
            CreateMap<VadesizTLHesap, VadesizTLHesapGetDto>();
            CreateMap<VadesizTLHesapPostDto, VadesizTLHesap>();
            CreateMap<VadesizTLHesapPutDto, VadesizTLHesap>();

        }
    }
}
