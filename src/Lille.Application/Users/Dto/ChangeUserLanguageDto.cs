using System.ComponentModel.DataAnnotations;

namespace Lille.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}