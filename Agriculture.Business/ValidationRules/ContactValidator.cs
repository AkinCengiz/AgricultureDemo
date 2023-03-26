using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;
using FluentValidation;

namespace Agriculture.Business.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez...");
            RuleFor(c => c.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez...");
            RuleFor(c => c.Mail).MinimumLength(6).WithMessage("Mail alanı en az 6 karakter içermelidir...");
            RuleFor(c => c.Message).NotEmpty().WithMessage("Mesaj alanı boş geçilemez...");
            RuleFor(c => c.Message).MinimumLength(10).WithMessage("Mesaj alanı en az 10 karakter içermelidir...");
        }
    }
}
