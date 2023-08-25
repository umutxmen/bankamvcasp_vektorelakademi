using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.EuroHesap;
using Banka.Model.Dtos.EuroSwift;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class EuroSwiftProfile: Profile
    {
        public EuroSwiftProfile()
        {
            CreateMap<EuroSwift, EuroSwiftGetDto>();
            CreateMap<EuroSwiftPostDto, EuroSwift>();
            CreateMap<EuroSwiftPutDto, EuroSwift>();

        }
    }
}
