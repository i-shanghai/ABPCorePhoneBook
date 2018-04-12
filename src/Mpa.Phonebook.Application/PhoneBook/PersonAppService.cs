using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Mpa.Phonebook.PhoneBook.Dtos;

namespace Mpa.Phonebook.PhoneBook
{
    public class PersonAppService: PhonebookAppServiceBase,IPersonAppService
    {
        public Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            throw new System.NotImplementedException();
        }

        public Task<PersonListDto> GetPersonByIdAsync(GetPersonInput input)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateOrUpdatePersonAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task DeletePersonByIdAsync(EntityDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}