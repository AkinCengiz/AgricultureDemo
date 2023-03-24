using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;
using FluentValidation;

namespace Agriculture.Business.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(t => t.FirstName).NotEmpty().WithMessage("Ad alanı boş geçilemez...");
            RuleFor(t => t.LastName).NotEmpty().WithMessage("Soyad alanı boş geçilemez...");
            RuleFor(t => t.Title).NotEmpty().WithMessage("Görev alanı boş geçilemez...");
            RuleFor(t => t.ImageUrl).NotEmpty().WithMessage("Resim dosya yolu boş geçilemez...");
            RuleFor(t => t.FirstName).MinimumLength(2).WithMessage("Ad değeri 2 karakterden az olamaz...");
            RuleFor(t => t.LastName).MinimumLength(2).WithMessage("Soyad değeri 2 karakterden az olamaz...");
            RuleFor(t => t.Title).MinimumLength(3).WithMessage("Görev alanı 3 karakterden az olamaz...");
        }
    }
}
