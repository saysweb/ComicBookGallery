﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        public ActionResult Detail()
        {
            return View();
        }
    }
}