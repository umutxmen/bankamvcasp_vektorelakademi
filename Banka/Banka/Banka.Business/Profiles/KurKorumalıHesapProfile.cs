using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.KrediKartı;
using Banka.Model.Dtos.KurKorumalıHesap;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class KurKorumalıHesapProfile : Profile
    {
        public KurKorumalıHesapProfile()
        {
            CreateMap<KurKorumalıHesap, KurKorumalıHesapGetDto>();
            CreateMap<KurKorumalıHesapPostDto, KurKorumalıHesap>();
            CreateMap<KurKorumalıHesapPutDto, KurKorumalıHesap>();

        }
    }
}
