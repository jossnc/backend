using BackendApi.Core.Enums;

namespace BackendApi.Core.Dtos.Company
{
    public class CompanyGetDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public CompanySize Size { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

       

    }
}
