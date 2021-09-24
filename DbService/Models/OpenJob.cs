using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class OpenJob
    {
        public string Id { get; set; }
        public string JobName { get; set; }
        public int RunCount { get; set; }
        public int ErrorCount { get; set; }
        public DateTime? NextRunTime { get; set; }
        public DateTime? LastRunTime { get; set; }
        public DateTime? LastErrorTime { get; set; }
        public int JobType { get; set; }
        public string JobCall { get; set; }
        public string JobCallParams { get; set; }
        public string Cron { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
        public string OrgId { get; set; }
    }
}
