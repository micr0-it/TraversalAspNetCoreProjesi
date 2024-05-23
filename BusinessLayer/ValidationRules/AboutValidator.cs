using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() 
        {
            RuleFor(p => p.FirstTitle).NotEmpty().WithMessage("İlk Title Boş Geçilemez").NotNull().WithMessage("İlk Title Boş Geçilemez");
            RuleFor(p => p.FirstDescription).NotEmpty().WithMessage("İlk Açıklama Boş Geçilemez").NotNull().WithMessage("İlk Açıklama Boş Geçilemez");
        }
    }
}
