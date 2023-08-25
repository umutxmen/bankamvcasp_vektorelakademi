using AutoMapper;
using Banka.Business.Interfaces;
using Banka.Model.Dtos.BankaBilgi;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class BankaBilgiProfile : Profile
    {
        public BankaBilgiProfile()
        {
            CreateMap<BankaBilgi,BankaBilgiGetDto>();
            CreateMap<BankaBilgiPostDto, BankaBilgi>();
            CreateMap<BankaBilgiPutDto, BankaBilgi>();

        }
    }
}
