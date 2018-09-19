using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotebookAndHook.Models;

namespace NotebookAndHook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HookController : ControllerBase
    {
        static List<Hook> Hooks;

       static HookController ()
        {
            Hooks = new List<Hook>
            {
                new Hook {Name="Stix", Gender= Gender.Female, isSocial=false},
                new Hook {Name="Jamie", Gender= Gender.Female, isSocial=true},
                new Hook {Name="Kennedi", Gender= Gender.Female, isSocial=true},
                new Hook {Name="Justin", Gender= Gender.Male, isSocial=false},
                new Hook {Name="Jordan", Gender= Gender.Female, isSocial=false},
                new Hook {Name="Kameron", Gender= Gender.Male, isSocial=true},
            };
        }

        [HttpGet] 
        public ActionResult<IEnumerable<Hook>> GetAll()
        {
            return Hooks;
        }

        [HttpGet("cool")]
        public ActionResult<IEnumerable<Hook>> GetCoolHooks()
        {
            var coolHooks = Hooks.Where(hook => hook.Gender == Gender.Female && hook.isSocial);
            return Ok(coolHooks);
        }

        [HttpPost]
        public IActionResult AddAHook(Hook hook)
        {
            Hooks.Add(hook);
            return Ok();
        }


    }
}