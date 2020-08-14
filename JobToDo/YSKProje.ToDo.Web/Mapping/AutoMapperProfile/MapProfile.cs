using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.DTO.DTOs.AciliyetDto;
using YSKProje.ToDo.DTO.DTOs.AppUserDto;
using YSKProje.ToDo.DTO.DTOs.BildirimDto;
using YSKProje.ToDo.DTO.DTOs.GorevDto;
using YSKProje.ToDo.DTO.DTOs.RaporDto;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {

            //Ctrl + K + S


            #region Aciliyet-AciliyetDto
            CreateMap<Aciliyet, AciliyetAddDto>();
            CreateMap<AciliyetAddDto, Aciliyet>();
            CreateMap<Aciliyet, AciliyetListDto>();
            CreateMap<AciliyetListDto, Aciliyet>();
            CreateMap<Aciliyet, AciliyetUpdateDto>();
            CreateMap<AciliyetUpdateDto, Aciliyet>();
            #endregion

            #region AppUser-AppUserDto
            CreateMap<AppUser, AppUserAddDto>();
            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserSignDto>();
            CreateMap<AppUserSignDto, AppUser>();
            CreateMap<AppUser, AppUserSignDto>();
            CreateMap<AppUserSignDto, AppUser>();
            #endregion

            #region Bildirim-BildirimDto
            CreateMap<Bildirim, BildirimListDto>();
            CreateMap<BildirimListDto, Bildirim>();
            #endregion

            #region Gorev-GorevDto
            CreateMap<Gorev, GorevAddDto>();
            CreateMap<GorevAddDto, Gorev>();
            CreateMap<Gorev, GorevListDto>();
            CreateMap<GorevListDto, Gorev>();
            CreateMap<Gorev, GorevUpdateDto>();
            CreateMap<GorevUpdateDto, Gorev>();
            CreateMap<Gorev, GorevListAllDto>();
            CreateMap<GorevListAllDto, Gorev>();
            #endregion

            #region Rapor-RaporDto
            CreateMap<Rapor, RaporAddDto>();
            CreateMap<RaporAddDto, Rapor>();
            CreateMap<Rapor, RaporUpdateDto>();
            CreateMap<RaporUpdateDto, Rapor>();
            #endregion
            

        }
    }
}
