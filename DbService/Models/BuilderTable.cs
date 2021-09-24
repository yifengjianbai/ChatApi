using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class BuilderTable
    {
        public string Id { get; set; }
        public string TableName { get; set; }
        public string Comment { get; set; }
        public string DetailTableName { get; set; }
        public string DetailComment { get; set; }
        public string ClassName { get; set; }
        public string Namespace { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string Folder { get; set; }
        public string Options { get; set; }
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
        public string CreateUserName { get; set; }
    }
}
