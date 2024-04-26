using AutoMapper;
using BackendApi.Core.Context;
using BackendApi.Core.Dtos.Company;
using BackendApi.Core.Dtos.Job;
using BackendApi.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private IMapper _mapper;
        private ApplicationDbContext _context { get; }

        public JobController(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        //POST
        #region Create 
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {
            Company newCompany = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();

            return Ok("Job created Successfully");
        }

        //Read
        [HttpGet]
        [Route("Get")]
        public a Task<IActionResult<IEnumerable<JobGetDto>>> GetJobs()
        {
            var jobs = _context.Jobs.ToListAsync();
            var convertedJobs = _mapper.Map<JobGetDto>(jobs);
            return Ok(convertedJobs);
        }

        #endregion
    }



}
