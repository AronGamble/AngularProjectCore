using System.ComponentModel.DataAnnotations;

namespace AngularCoreProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}