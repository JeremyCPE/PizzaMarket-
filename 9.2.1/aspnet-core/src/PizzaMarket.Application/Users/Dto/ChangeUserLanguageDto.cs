using System.ComponentModel.DataAnnotations;

namespace PizzaMarket.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}