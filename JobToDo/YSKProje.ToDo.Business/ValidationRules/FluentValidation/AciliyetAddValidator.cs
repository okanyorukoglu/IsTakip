using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.AciliyetDto;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
   public class AciliyetAddValidator :AbstractValidator<AciliyetAddDto>
    {
        public AciliyetAddValidator()
        {
            RuleFor(I=>I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
