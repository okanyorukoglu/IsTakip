using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.AppUserDto;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class AppUserSignInValidator : AbstractValidator<AppUserSignDto>
    {
        public AppUserSignInValidator()
        {
            RuleFor(I => I.UserName).NotNull().WithMessage("Kullanıcı Ad alanı boş geçilemez");
            RuleFor(I => I.Password).NotNull().WithMessage("Parola alanı boş geçilemez");
        }

    }
}
