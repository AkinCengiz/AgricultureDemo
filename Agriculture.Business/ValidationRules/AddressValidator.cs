using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;
using FluentValidation;

namespace Agriculture.Business.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez...");
            RuleFor(a => a.Town).NotEmpty().WithMessage("İlçe alanı boş geçilemez...");
            RuleFor(a => a.District).NotEmpty().WithMessage("Mahalle alanı boş geçilemez...");
            RuleFor(a => a.Street).NotEmpty().WithMessage("Cadde ve sokak alanı boş geçilemez...");
            RuleFor(a => a.BuildNo).NotEmpty().WithMessage("Bina numara alanı boş geçilemez...");
        }
    }
}
