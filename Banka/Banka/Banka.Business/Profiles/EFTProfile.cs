using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.Doviz;
using Banka.Model.Dtos.EFT;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class EFTProfile : Profile
    {
        public EFTProfile()
        {
            CreateMap<EFT, EFTGetDto>();
            CreateMap<EFTPostDto, EFT>();
            CreateMap<EFTPutDto, EFT>();

        }
    }
}
