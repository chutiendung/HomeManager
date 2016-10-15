﻿using System.Web.Mvc;
using home.manager.Models.db;
using home.manager.Repositories;
using home.manager.Shared;

namespace home.manager.Controllers
{
    [Authorize]
    public class SecurityController : SharedController<SecurityItem, SecurityCategory, SecurityRepository> { }
}