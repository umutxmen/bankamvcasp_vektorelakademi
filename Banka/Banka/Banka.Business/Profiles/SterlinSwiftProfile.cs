using AutoMapper;
using Banka.Model.Dtos.SterlinHesap;
using Banka.Model.Dtos.SterlinSwift;
using Banka.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Business.Profiles
{
    public class SterlinSwiftProfile :Profile
    {
        public SterlinSwiftProfile()
        {
            CreateMap<SterlinSwift, SterlinSwiftGetDto>();
            CreateMap<SterlinSwiftPostDto, SterlinSwift>();
            CreateMap<SterlinSwiftPutDto, SterlinSwift>();

        }
    }
}
