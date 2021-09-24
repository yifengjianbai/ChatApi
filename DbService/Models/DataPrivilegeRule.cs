using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class DataPrivilegeRule
    {
        public string Id { get; set; }
        public string SourceCode { get; set; }
        public string SubSourceCode { get; set; }
        public string Description { get; set; }
        public int SortNo { get; set; }
        public string PrivilegeRules { get; set; }
        public bool Enable { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
    }
}
