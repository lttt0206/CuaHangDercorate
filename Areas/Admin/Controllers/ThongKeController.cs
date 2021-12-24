//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace doan.Areas.Admin.Controllers
//{
//    public class ThongKeController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}



using doan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace doan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThongKeController : Controller
    {
        private readonly StoreContext _context;

        public ThongKeController(StoreContext context)
        {
            _context = context;
        }
        public string Index()
        {

            return "hello from the Index method of the HomeController";

        }
        //public IActionResult SanPham_DanhMuc()

        //{
        //    return View();
        //}
        //public string test()

        //{
        //    return "test";
        //}


        //public IActionResult DanhThu_Ngay(int thang, int nam)
        //{
        //    StoreContext context = HttpContext.RequestServices.GetService(typeof(doan.Models.StoreContext)) as StoreContext;
        //    List<ThongKeModel> listdt = _context.DanhSo_Ngay(thang, nam);
        //    ViewData["listdanhthu"] = listdt;

        //    return View();
        //}


    }
}
