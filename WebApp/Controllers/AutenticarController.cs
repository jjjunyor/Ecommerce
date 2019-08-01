//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace WebApp.Controllers
//{
//    public class AutenticarController : Controller
//    {
//        private readonly SignInManager<IdentityUser> _signInManager;
//        private readonly UserManager<IdentityUser> _userManager;

//        public AutenticarController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> _userManager)
//        {
//            _signInManager = signInManager;
//            _userManager = _userManager;
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }
//        public async Task<ActionResult> Registrar()
//        {
//            var user = new IdentityUser() {
//                UserName = "este",
//                Email = "teste@ig.com.br",
//                EmailConfirmed = true
//            };
//            var result = await _userManager.CreateAsync(user, "12345");
//            if (!result.Succeeded) return BadRequest(result.Errors);
//            return StatusCode(StatusCodes.Status201Created);
//        }
//    }
//}