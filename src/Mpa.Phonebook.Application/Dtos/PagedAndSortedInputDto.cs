using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Mpa.Phonebook.Dtos
{
    /// <summary>
    /// 分页Dto,继承Paged、Sorted请求
    /// </summary>
    public class PagedAndSortedInputDto:IPagedResultRequest,ISortedResultRequest
    {
        [Range(1, 500)]
        public int MaxResultCount { get; set; }

        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }
         
        public string Sorting { get; set; }
    }
}