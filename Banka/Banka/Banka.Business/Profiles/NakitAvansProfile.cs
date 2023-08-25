using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.MusteriVarlik;
using Banka.Model.Dtos.NakitAvans;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class NakitAvansProfile : Profile
    {
        public NakitAvansProfile()
        {
            CreateMap<NakitAvans, NakitAvansGetDto>();
            CreateMap<NakitAvansPostDto, NakitAvans>();
            CreateMap<NakitAvansPutDto, NakitAvans>();

        }
    }
}
