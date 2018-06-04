using System.ComponentModel.DataAnnotations;

namespace LearningABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}