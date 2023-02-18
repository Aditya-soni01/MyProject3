using System.ComponentModel.DataAnnotations;

namespace MyProject3.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}