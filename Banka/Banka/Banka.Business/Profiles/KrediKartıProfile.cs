using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.Kartlar;
using Banka.Model.Dtos.KrediKartı;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class KrediKartıProfile : Profile
    {
        public KrediKartıProfile()
        {
            CreateMap<KrediKartı, KrediKartıGetDto>();
            CreateMap<KrediKartıPostDto, KrediKartı>();
            CreateMap<KrediKartıPutDto, KrediKartı>();

        }
    }
}
