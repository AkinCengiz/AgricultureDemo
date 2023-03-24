using System.ComponentModel.DataAnnotations;

namespace Agriculture.WebAppUI.Models
{
    public class TeamAddViewModel
    {
        [Display(Name = "Adı")]
        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadı")]
        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        public string LastName { get; set; }

        [Display(Name = "Meslek")]
        [Required(ErrorMessage = "Meslek alanı boş geçilemez.")]
        public string Title { get; set; }

        [Display(Name = "Resim")]
        [Required(ErrorMessage = "Resim yolu boş geçilemez.")]
        public string ImageUrl { get; set; }

        [Display(Name = "Facebook")]
        [Required(ErrorMessage = "Facebook alanı boş geçilemez.")]
        public string FacebookUrl { get; set; }

        [Display(Name = "Instagram")]
        [Required(ErrorMessage = "Instagram alanı boş geçilemez.")]
        public string InstagramUrl { get; set; }

        [Display(Name = "Web sitesi")]
        [Required(ErrorMessage = "Web Sitesi alanı boş geçilemez.")]
        public string WebsiteUrl { get; set; }

        [Display(Name = "Twitter")]
        [Required(ErrorMessage = "Twitter alanı boş geçilemez.")]
        public string TwitterUrl { get; set; }

    }
}
