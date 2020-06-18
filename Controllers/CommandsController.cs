using System.Collections.Generic;
using Commander.Models;
using Commander.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace Commander.Controllers
{
    [Route("/api/invoices")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CommandsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public IEnumerable<invoice> Get()
        {
            var invoices = _dataAccessProvider.GetAllInvoices();
            return invoices;
        }
        [HttpGet("{id}")]
        public invoice GetOne(Guid id)
            {
                var invoice = _dataAccessProvider.GetSingleInvoice(id);
                return invoice;
            }
    }
}