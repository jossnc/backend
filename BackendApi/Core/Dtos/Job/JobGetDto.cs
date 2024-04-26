﻿using BackendApi.Core.Enums;

namespace BackendApi.Core.Dtos.Job
{
    public class JobGetDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
    }
}
