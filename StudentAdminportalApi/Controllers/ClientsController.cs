using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminportalApi.domainModels;
using StudentAdminportalApi.repo;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdminportalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IRepo repo;
        private readonly IMapper mapper;    
        public ClientsController(IRepo repo,IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<ActionResult> getallClientsAsync()
        {
            var clients =await repo.GetClientsAsync();


            return Ok(mapper.Map<List<Client>>(clients));
        }
    }
}

