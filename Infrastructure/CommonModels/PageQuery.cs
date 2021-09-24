using System;
using System.Text;

namespace Infrastructure.CommonModels
{
    /// <summary>
    /// 分页查询
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageQuery<T> where T : class
    {
        /// <summary>
        /// 页数
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 条件对象
        /// </summary>
        public T Where { get; set; }

    }

}
