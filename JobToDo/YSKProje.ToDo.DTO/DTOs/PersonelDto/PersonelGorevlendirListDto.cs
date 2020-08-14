using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.AppUserDto;
using YSKProje.ToDo.DTO.DTOs.GorevDto;

namespace YSKProje.ToDo.DTO.DTOs.PersonelDto
{
    public class PersonelGorevlendirListDto
    {
        public AppUserSignDto AppUser { get; set; }
        public GorevListDto Gorev { get; set; }
    }
}
