﻿using Microsoft.AspNetCore.Mvc;

namespace wixisoftware.WebUI.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialAddComment()
		{


			return PartialView();
		}

        public PartialViewResult CommentListByBlog()
        {


            return PartialView();
        }
    }
}
