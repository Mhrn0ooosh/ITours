using System.ComponentModel.DataAnnotations;

namespace ITours.Solutions.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}