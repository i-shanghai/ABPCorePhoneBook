using System.ComponentModel.DataAnnotations;

namespace Mpa.Phonebook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}