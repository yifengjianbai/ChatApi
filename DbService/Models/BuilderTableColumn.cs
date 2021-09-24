using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class BuilderTableColumn
    {
        public string Id { get; set; }
        public string TableId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Comment { get; set; }
        public string ColumnType { get; set; }
        public string EntityType { get; set; }
        public string EntityName { get; set; }
        public bool IsKey { get; set; }
        public bool IsIncrement { get; set; }
        public bool IsRequired { get; set; }
        public bool IsInsert { get; set; }
        public bool IsEdit { get; set; }
        public bool IsList { get; set; }
        public bool IsQuery { get; set; }
        public string QueryType { get; set; }
        public string HtmlType { get; set; }
        public string EditType { get; set; }
        public int Sort { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUserId { get; set; }
        public int? EditRow { get; set; }
        public int? EditCol { get; set; }
        public string UpdateUserName { get; set; }
        public string CreateUserName { get; set; }
        public int? MaxLength { get; set; }
    }
}
