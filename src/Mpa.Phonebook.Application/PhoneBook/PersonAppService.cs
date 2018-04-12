<<<<<<< HEAD
﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Mpa.Phonebook.PhoneBook.Dtos;
=======
﻿using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using Mpa.Phonebook.PhoneBook.Dtos;
using Mpa.Phonebook.PhoneBook.Persons;
>>>>>>> 16be02dc76f1129db7077df55ee0c6946090e348

namespace Mpa.Phonebook.PhoneBook
{
    public class PersonAppService : PhonebookAppServiceBase, IPersonAppService
    {
<<<<<<< HEAD
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
=======
        /// <summary>
        /// 依赖注入，实现对Person的仓储管理
        /// </summary>
        private readonly IRepository<Persons.Person> _personRepository;

        public PersonAppService(IRepository<Persons.Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonDto input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }
        }

        /// <summary>
        /// Person信息更新
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id.Value);

            await _personRepository.UpdateAsync(input.MapTo(entity));
        }
        /// <summary>
        /// 新增Person信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            //input 映射到 person对象 
            var entity = input.MapTo<Persons.Person>();

            await _personRepository.InsertAsync(entity);
>>>>>>> 16be02dc76f1129db7077df55ee0c6946090e348
        }

        public Task DeletePersonByIdAsync(EntityDto input)
        {
            throw new System.NotImplementedException();
        }
<<<<<<< HEAD
=======

        /// <summary>
        /// 返回具有：分页和排序结果的PersonListDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            //构建查询语句，Including PhoneNumbers
            var query = _personRepository.GetAllIncluding(a => a.PhoneNumbers);
            //查询，数据总数
            var personCount = await query.CountAsync();
            //执行查询
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            //查询结果 映射到 PersonListDto
            var dtos = persons.MapTo<List<PersonListDto>>();
            //返回分数数据结果
            return new PagedResultDto<PersonListDto>(personCount, dtos);

        }
        /// <summary>
        /// 删除联系人信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id);

            if (entity == null)
            {
                throw new UserFriendlyException("该联系人已经消失在数据库中，无法二次删除");
            }
            await _personRepository.DeleteAsync(input.Id);
        }

        /// <summary>
        /// 根据ID查询联系人信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personRepository.GetAllIncluding(a => a.PhoneNumbers).FirstOrDefaultAsync(a => a.Id == input.Id.Value);

            return person.MapTo<PersonListDto>();
        }

        public async Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdDto<int> input)
        {
            var output = new GetPersonForEditOutput();

            PersonEditDto personEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _personRepository.GetAllIncluding(a => a.PhoneNumbers)
                    .FirstOrDefaultAsync(a => a.Id == input.Id.Value);

                personEditDto = entity.MapTo<PersonEditDto>();
            }
            else
            {
                personEditDto = new PersonEditDto();
            }


            output.Person = personEditDto;

            return output;
        }
>>>>>>> 16be02dc76f1129db7077df55ee0c6946090e348
    }
}