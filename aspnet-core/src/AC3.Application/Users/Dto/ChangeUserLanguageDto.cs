using System.ComponentModel.DataAnnotations;

namespace AC3.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}