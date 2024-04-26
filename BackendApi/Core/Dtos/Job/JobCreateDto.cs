using BackendApi.Core.Enums;

namespace BackendApi.Core.Dtos.Job
{
    public class JobCreateDto
    {

        public string? Title { get; set; }
        public JobLevel Level { get; set; }

        public long CompanyId { get; set; }
    }
}
