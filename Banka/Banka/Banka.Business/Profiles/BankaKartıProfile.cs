using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Dtos.BankaKartı;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class BankaKartiProfile : Profile
    {
        public BankaKartiProfile()
        {
            CreateMap<BankaKarti, BankaKartiGetDto>();
            CreateMap<BankaKartiPostDto, BankaKarti>();
            CreateMap<BankaKartiPutDto, BankaKarti>();

        }
    }
}
