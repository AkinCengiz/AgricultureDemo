using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;
using FluentValidation;

namespace Agriculture.Business.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(a => a.Title).NotEmpty().WithMessage("Duyuru başlığı boş geçilemez...");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez...");
        }
    }
}
