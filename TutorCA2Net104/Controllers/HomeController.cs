using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TutorCA2Net104.Models;

namespace TutorCA2Net104.Controllers
{
    public class HomeController : Controller
    {

        // Khai báo DBContext
        DemoCode1stContext _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _context = new DemoCode1stContext();
        }
        public IActionResult Login() // Action được dùng để mở View
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string sdt)
        { // Action này dùng để xử lý dữ liệu đăng nhập
            // Kiểm tra xem thông tin nhập vào có trung khớp với đối tượng nào trong db ko?
            var accounts = _context.KhachHangs.ToList(); // Lấy ra tất cả danh sách
            // Lấy ra thông tin account theo thông tin nhập vào
            var acc = accounts.FirstOrDefault(p => p.Email == email && p.Sdt == sdt);
            // Kiểm tra xem có lấy được dữ liệu thật hay ko?
            if(acc != null) { // Nếu lấu được <=> tài khoản lấy ra không null
                TempData["login"] = email;
                return RedirectToAction("Index");
            }
            else // lấy ra bị null <=> không có thằng tài khoản nào như thế cả
            {
                return View("Login"); // vẫn trả về view đó
            }    
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }

}