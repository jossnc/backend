﻿namespace BackendApi.Core.Dtos.Candidate
{
    public class CandidateCreateDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? ConverLetter { get; set; }
        public long JobId { get; set; }
    }
}
