using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SimpleLoginC.Models;


namespace SimpleLoginC.Controllers
{
    public class FormsController : Controller
        {
            [HttpGet("")]
            public IActionResult Index()
                {
                    return View();
                }

            [HttpPost("Login")]
            public IActionResult UserLogin(Login newLogin)
                {
                    if(ModelState.IsValid)
                        {
                            return RedirectToAction("SuccessPage");
                        }
                        return View("Index");
                }

            [HttpPost("Register")]
            public IActionResult UserRegister(Register newRegister)
                {
                    if(ModelState.IsValid)
                        {
                            return RedirectToAction("SuccessPage");
                        }
                     return View("Index");
                }

            [HttpGet("Success")]
            public IActionResult SuccessPage()
                {
                    return View("SuccessPage");
                }
        }
}
