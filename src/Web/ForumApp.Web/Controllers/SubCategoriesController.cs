﻿namespace ForumApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SubCategoriesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}