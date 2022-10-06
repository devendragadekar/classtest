using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_DB_Crud.Models;

namespace WebAPI_DB_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductcategoryController : ControllerBase
    {


        public ProductcategoryController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }


        [HttpGet]
        public ActionResult get()
        {
            var data = _context.CatWiseProducts.FromSqlInterpolated($"dbo.SP_ProductByCat");
            return Ok(data);
        }
    }
}
