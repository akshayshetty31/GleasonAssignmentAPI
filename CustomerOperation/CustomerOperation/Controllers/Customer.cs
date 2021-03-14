using CustomerOperation.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOperation.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [EnableCors(PolicyName = "CorsPolicy")]
    public class Customer : Controller
    {
        // GET: Customer
        

        private readonly ICommonService commonService;
public Customer(ICommonService _commonService)
        {
            commonService = _commonService;
        }

        

       

        [HttpGet]
        public List<Customers> Details()
        {
            return commonService.GetCustomers();
        }

        [HttpPost]
        public List<Customers> Create(Customers cust)
        {
            try
            {
                
                return commonService.CreateCustomers(cust);
            }
            catch(Exception)
            {
                throw;
            }

        }

        // POST: Customer/Create
        
        [HttpPost]
        // GET: Customer/Edit/5
        public List<Customers> Edit(Customers cust)
        {
            try
            {
                
                return commonService.UpdateCustomers(cust);
            }
            catch
            {
                throw ;
            }
        }

        // POST: Customer/Edit/5
        



        // POST: Customer/Delete/5
        [HttpGet("{id}")]

        public List<Customers> Delete(int id)
        {
            try
            {
                
                return commonService.DeleteCustomer(id);
            }
            catch
            {
                throw;
            }
        }
    }
}
