using Abp.Application.Services.Dto;

namespace Mpa.Phonebook.Authorization.Users.Dtos
{
    public class UpdateEmailDto : EntityDto
    {
        public string EmailAddress { get; set; }
    }
}