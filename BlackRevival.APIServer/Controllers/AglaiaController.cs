﻿using System.Text.Json;
using BlackRevival.APIServer.Classes;
using Microsoft.AspNetCore.Mvc;

namespace BlackRevival.APIServer.Controllers;

public class AglaiaController : Controller
{
    [HttpGet("/api/aglaia/pass/progress/all/{uid}", Name = "GetAglaiaPassProgress")]
    public IActionResult GetAglaiaPassProgress(string uid)
    {
        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "SUCCESS",
            Rst = new {},
            Eac = 0
        });
    }
}