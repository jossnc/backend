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
        private IMapper _mapper { get; }
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
        public async Task<IActionResult> CreateJob([FromBody]  JobCreateDto dto)
        {
            var newJob = _mapper.Map<Job>(dto);
            await _context.Jobs.AddAsync(newJob);
            await _context.SaveChangesAsync();

            return Ok("Job created Successfully");
        }

        //Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<JobGetDto>>> GetJobs()
        {
            var jobs = await _context.Jobs.Include(job => job.Company).ToListAsync();
            var convertedJobs = _mapper.Map<IEnumerable<JobGetDto>>(jobs);
            return Ok(convertedJobs);
        }

        #endregion
    }



}
