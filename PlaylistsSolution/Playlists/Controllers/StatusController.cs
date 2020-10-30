using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Playlists.Services;

namespace Playlists.Controllers
{
    public class StatusController : Controller
    {
        private readonly IProvideServerStatus _status;

        public StatusController(IProvideServerStatus status)
        {
            _status = status;
        }

        public IActionResult Index()
        {
            // create the model or process the request.
            return View(_status.GetServerStatus());
        }
    }
}
