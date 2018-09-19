using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotebookAndHook.DataAccess;
using NotebookAndHook.Models;

namespace NotebookAndHook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotebookController : ControllerBase
    {
        [HttpPost] //adding something
        public void AddACustomer (Notebook notebook)
        {
            var storage = new NotebookStorage(); //initializes Notebook Storage
            storage.Add(notebook);
        }

        [HttpPut("{id}")]
        public void AddHookToNotebook(int id, Hook hook)
        {
            var storage = new NotebookStorage();

            var notebook = storage.GetById(id);
            notebook.OwnedHooks.Add(hook);
        }
    }
}