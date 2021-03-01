using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cabare_Charlotte.Models;
using Cabare_Charlotte.DAL;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cabare_Charlotte.Helper;
using Cabare.Models;

namespace Cabare_Charlotte.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceScopeFactory _scopeFactory;
        PlayerDbContext _playerDbContext;

        public HomeController(ILogger<HomeController> logger, IServiceScopeFactory scopeFactory, PlayerDbContext playerDbContext)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
            _playerDbContext = playerDbContext;
        }

        public List<string> GetDirectores()
        {
            return PlayerHelper.GetDirectory();
        }

        public List<string> GetSongs(List<string> directores)
        {
            return PlayerHelper.GetSongs(directores);
        }

        public int Increment(int count, string deviceId)
        {
            _playerDbContext.Clients.Update(new Client { Count = count, DeviceId = deviceId });
            _playerDbContext.SaveChanges();
            var lastCount = _playerDbContext.Clients.FirstOrDefault(c => c.DeviceId == deviceId).Count;

            return lastCount;
        }

        public void RemoveCount(string deviceId)
        {
            _playerDbContext.Clients.Update(new Client { DeviceId = deviceId, Count = 0 });
            _playerDbContext.SaveChanges();
        }

        public IActionResult Index(string deviceId) 
        { 
            var client = _playerDbContext.Clients.FirstOrDefault(c => c.DeviceId == deviceId);

            return View(client);
        }
    }
}
