using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Mpa.Phonebook.Dtos
{
    /// <summary>
    /// 基类Dto 定义分布和排序属性，继承Paged、Sorted
    /// </summary>
    public class PagedAndSortedInputDto:IPagedResultRequest,ISortedResultRequest
    {
        /// <summary>
        /// 每页显示数据条数
        /// </summary>
        [Range(1, 500)]
        public int MaxResultCount { get; set; }

        /// <summary>
        /// 跳过的数据条数 
        /// </summary>
        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }


        /// <summary>
        /// 排序字段
        /// </summary>
        public string Sorting { get; set; }
    }
}