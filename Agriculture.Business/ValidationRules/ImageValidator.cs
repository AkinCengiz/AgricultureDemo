using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;
using FluentValidation;

namespace Agriculture.Business.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(i => i.Title).NotEmpty().WithMessage("Başlık bilgisi boş geçilemez...");
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez...");
        }
    }
}
