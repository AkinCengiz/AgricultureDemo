using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;
using FluentValidation;

namespace Agriculture.Business.ValidationRules
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(s => s.Title).NotEmpty().WithMessage("Başlık bilgisi boş eçilemez...");
            RuleFor(s => s.Description).NotEmpty().WithMessage("Açıklama bilgisi boş eçilemez...");
            RuleFor(s => s.Image).NotEmpty().WithMessage("Resim bilgisi boş eçilemez...");
        }
    }
}
