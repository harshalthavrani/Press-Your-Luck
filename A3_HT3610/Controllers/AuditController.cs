//Name: Harshal Thavrani
//    Student Id: 8733610
//    Assignment 3 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using A3_HT3610.Data;
using A3_HT3610.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace A3_HT3610.Controllers
{
    public class AuditController : Controller
    {
        private readonly AuditContext _context;
        public AuditController(AuditContext context)
        {
            _context = context;
        }

        // GET: Audit
        public async Task<IActionResult> Index()
        {
            var auditContext = _context.Audit.Include(a => a.AuditType);
            return View(await auditContext.ToListAsync());
        }
    }
}
