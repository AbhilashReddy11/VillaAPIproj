﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Diagnostics;
using VillaAPI_Utility;
using VillaAPI_Web.Models;
using VillaAPI_Web.Models.Dto;
using VillaAPI_Web.Services.IServices;

namespace VillaAPI_Web.Controllers
{
    public class HomeController : Controller
    {
		private readonly IVillaService _villaService;
		private readonly IMapper _mapper;

		public HomeController(IVillaService villaService, IMapper mapper)
		{
			_villaService = villaService;
			_mapper = mapper;
		}
		public async Task<IActionResult> Index()
		{
			List<VillaDTO> list = new();

			var response = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
			if (response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
			}
			return View(list);
        }
    }
}