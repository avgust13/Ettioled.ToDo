using AutoMapper;
using Ettioled.ToDo.Business.Data;
using Ettioled.ToDo.Business.Services;
using Ettioled.ToDo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Ettioled.ToDo.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IToDoService _toDoService;

        public HomeController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public ActionResult Index()
        {
            var todos = _toDoService.GetUserToDoList(User.Identity.GetUserId());

            return View(todos);
        }

        [HttpPost]
        public ActionResult Add(string description)
        {
            var model = new ToDoViewModel()
            {
                Description = description,
                UserId = User.Identity.GetUserId()
            };

            TryValidateModel(model);
            if (ModelState.IsValid)
            {
                _toDoService.Add(Mapper.Map<ToDoData>(model));

                return RedirectToAction("Index");
            }

            var todos = _toDoService.GetUserToDoList(User.Identity.GetUserId());
            return View("Index", todos);
        }

        [HttpPost]
        public ActionResult Update(int id, bool isDone, string description)
        {
            var data = new ToDoData()
            {
                ToDoId = id,
                UserId = User.Identity.GetUserId(),
                IsDone = isDone,
                Description = description,
                LastUpdatedDate = DateTime.Now
            };

            _toDoService.Update(data);

            return Json(new { updated = data.LastUpdatedDate.ToString("dd/MM/yyyy HH:mm:ss") });
        }
    }
}