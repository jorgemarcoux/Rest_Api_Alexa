using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using Newtonsoft.Json.Linq;

namespace RestApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly app_developmentContext _context;

        public EmployeesController(app_developmentContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employe>>> GetEmployees()
        {
            return await _context.employees.ToListAsync();
        }

         private bool EmployeesExists(long id)
        {
            return _context.employees.Any(e => e.Id == id);
        }

    }




}