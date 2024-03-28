using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorCA2Net104.Models;

namespace TutorCA2Net104.Controllers
{
    public class KhachHangController : Controller
    {
        DemoCode1stContext context;
        public KhachHangController() // thêm con schắc tơ vào
        {
            context = new DemoCode1stContext();
        }
        // GET: KhachHangController
        public ActionResult Index() // Hiển thị ra tất cả các Khách hàng đang có
        {
            var khachhangs = context.KhachHangs.ToList(); // Lấy ra từ DB thông qua DBSet 
            // Truyền dữ liệu sang View
            return View(khachhangs);
        }

        // GET: KhachHangController/Details/5
        public ActionResult Details(string sdt)
        {
            var khachhang = context.KhachHangs.ToList().FirstOrDefault(p => p.Sdt == sdt);
            return View(khachhang); // Truyền 1 đối tượng sang view
        }

        // GET: KhachHangController/Create
        public ActionResult Create() // Mở view
        {
            return View();
        }

        // POST: KhachHangController/Create
        [HttpPost]
        public ActionResult Create(KhachHang khachhang) // Thực hiện thao tác
        {
            try
            {
                context.KhachHangs.Add(khachhang);
                context.SaveChanges();  
                return RedirectToAction("Index", "KhachHang"); // Chuyển hướng khi thêm thành công
            }
            catch
            {
                return Content("Thêm thất bại");
            }
        }

        // GET: KhachHangController/Edit/5
        public ActionResult Edit(string sdt) // Action này để mở View và truyền đối tượng đã có sang
        {
            var editKH = context.KhachHangs.Find(sdt); // Tìm thông tin đối tượng cần sửa theo ID
            return View(editKH);
        }

        // POST: KhachHangController/Edit
        [HttpPost]
        public ActionResult Edit(KhachHang khachhang) // Action này để thực hiện việc sửa theo data nhập vào
        {
            try
            {
                var editKH = context.KhachHangs.Find(khachhang.Sdt); // Tìm chính xác tới đối tượng cần sửa
                editKH.Email = khachhang.Email;
                editKH.Diachi = khachhang.Diachi;
                editKH.Status = khachhang.Status;
                // Tobe Continue (Chưa full thuộc tính đâu =)))
                context.Update(editKH);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: KhachHangController/Delete/5
        public ActionResult Delete(string sdt)
        {
            var deleteKH = context.KhachHangs.Find(sdt); // Tìm đối tượng để xóa theo SDT
            context.KhachHangs.Remove(deleteKH);    
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: KhachHangController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
