using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class FlowInstanceOperationHistory
    {
        public string Id { get; set; }
        public string InstanceId { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    }
}
