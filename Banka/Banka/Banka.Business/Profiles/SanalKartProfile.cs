using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.NakitAvans;
using Banka.Model.Dtos.SanalKart;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class SanalKartProfile : Profile
    {
        public SanalKartProfile()
        {
            CreateMap<SanalKart, SanalKartGetDto>();
            CreateMap<SanalKartPostDto, SanalKart>();
            CreateMap<SanalKartPutDto, SanalKart>();

        }
    }
}
