using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.HizliKredi;
using Banka.Model.Dtos.KartaParaAktar;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class KartaParaAktarProfile : Profile
    {
        public KartaParaAktarProfile()
        {
            CreateMap<KartaParaAktar, KartaParaAktarGetDto>();
            CreateMap<KartaParaAktarPostDto, KartaParaAktar>();
            CreateMap<KartaParaAktarPutDto, KartaParaAktar>();

        }
    }
}
