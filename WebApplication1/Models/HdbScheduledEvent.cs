﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class HdbScheduledEvent
    {
        public HdbScheduledEvent()
        {
            HdbScheduledEventInvocationLogs = new HashSet<HdbScheduledEventInvocationLog>();
        }

        public string Id { get; set; }
        public string WebhookConf { get; set; }
        public DateTime ScheduledTime { get; set; }
        public string RetryConf { get; set; }
        public string Payload { get; set; }
        public string HeaderConf { get; set; }
        public string Status { get; set; }
        public int Tries { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? NextRetryAt { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<HdbScheduledEventInvocationLog> HdbScheduledEventInvocationLogs { get; set; }
    }
}
