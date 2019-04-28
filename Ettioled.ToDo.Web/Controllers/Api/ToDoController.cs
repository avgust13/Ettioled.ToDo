using Ettioled.ToDo.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Ettioled.ToDo.Business.Data;

namespace Ettioled.ToDo.Web.Controllers.Api
{
    public class ToDoController : ApiController
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet]
        public IHttpActionResult Delete(int id)
        {
            if (!_toDoService.Delete(id, User.Identity.GetUserId()))
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
