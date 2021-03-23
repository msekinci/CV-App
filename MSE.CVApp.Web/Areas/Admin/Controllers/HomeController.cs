using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSE.CVApp.Business.Interfaces;
using MSE.CVApp.DTO.DTOs.AppUserDTOs;
using MSE.CVApp.Web.Models;
using System;
using System.IO;

namespace MSE.CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IAppUserService _appUserService;

        public HomeController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "bilgilerim";
            var user = _appUserService.FindByName(User.Identity.Name);
            var appUserUpdateModel = new AppUserUpdateModel
            {
                Email = user.Email,
                Address = user.Address,
                FirstName = user.FirstName,
                Id = user.Id,
                ImageUrl = user.ImageUrl,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription
            };
            return View(appUserUpdateModel);
        }

        [HttpPost]
        public IActionResult Index(AppUserUpdateModel model)
        {
            TempData["active"] = "bilgilerim";
            if (ModelState.IsValid)
            {
                var updatedAppUser = _appUserService.GetById(model.Id);
                if (model.Picture != null)
                {
                    var imgName = Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);
                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName;
                    var stream = new FileStream(path, FileMode.Create);
                    model.Picture.CopyTo(stream);
                    updatedAppUser.ImageUrl = imgName;

                }

                updatedAppUser.LastName = model.LastName;
                updatedAppUser.FirstName = model.FirstName;
                updatedAppUser.PhoneNumber = model.PhoneNumber;
                updatedAppUser.ShortDescription = model.ShortDescription;
                updatedAppUser.Address = model.Address;
                updatedAppUser.Email = model.Email;


                _appUserService.Update(updatedAppUser);
                TempData["message"] = "İşleminiz başarı ile gerçekleşti";

                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult ChangePassword()
        {
            TempData["active"] = "sifre";
            var user = _appUserService.FindByName(User.Identity.Name);
            return View(new AppUserPasswordDTO
            {
                Id = user.Id
            });
        }

        [HttpPost]
        public IActionResult ChangePassword(AppUserPasswordDTO model)
        {
            TempData["active"] = "sifre";
            if (ModelState.IsValid)
            {
                var updatedUser = _appUserService.FindByName(User.Identity.Name);
                updatedUser.Password = model.Password;
                _appUserService.Update(updatedUser);
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            return View(model);
        }


    }
}
