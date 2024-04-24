using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.ReservasController
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
         private readonly UserManager<AppUser> _userManager;
        private readonly  IReservaReposotory _reservaRepository;
        public ReservaController(IReservaReposotory reservaRepository, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _reservaRepository = reservaRepository;
        }
        [HttpGet]
        public async  Task<IActionResult> GetUserReserva()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var userReserva = await _reservaRepository.GetUserReserva(appUser);
            return Ok(userReserva);
        }

        [HttpPost]
        public async Task<IActionResult>  AddReserva(string instalacionNombre)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var instalacion = await in
        }
    }
}