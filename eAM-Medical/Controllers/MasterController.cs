using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eAM_Medical.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult ClinicMaster()
        {
            return View();
        }
        public IActionResult BranchMaster()
        {
            return View();
        }
    }
}
