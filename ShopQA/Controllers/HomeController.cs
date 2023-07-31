using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Slot10.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Slot10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Trangchu()
        {
            using(var context = new WebShopContext())
            {
                List<SanPham> list = context.SanPhams.Where(x => x.Status == true).ToList();
                ViewBag.list = list;
                ViewBag.lsp = context.Brands.ToList();
            }
           

            string id= HttpContext.Session.GetString("id");
            string role = HttpContext.Session.GetString("role");
            string sum = HttpContext.Session.GetString("slsp");
            if(sum== null)
            {
                sum = "0";
            }
            ViewBag.id = id;
            ViewBag.role = role;
            ViewBag.slsp=sum;
            return View();
        }

        public IActionResult FormLogin()
        {
            return View();
        }
        public IActionResult FormDK()
        {
            ViewBag.err = HttpContext.Session.GetString("err");
            return View();
        }
        [HttpPost]
        public IActionResult DangKi()
        {
            string user = HttpContext.Request.Form["user"];
            string pass = HttpContext.Request.Form["pass"];
            string pass1 = HttpContext.Request.Form["pass1"];
            if(pass == pass1)
            {
                using (var context = new WebShopContext())
                {
                    Account a = context.Accounts.Where(x => x.Username == user).SingleOrDefault();
                    if (a != null)
                    {
                        // bay h la luc tao session cho no
                        HttpContext.Session.SetString("err", "Ten tai khoan da co nguoi dang ki");
                        return Redirect("/Home/FormDK");
                    }
                    else
                    {
                        Account b = new Account();
                        b.Username = user;
                        b.Password = pass;
                        b.Role = 2;
                        context.Accounts.Add(b);
                        context.SaveChanges();

                        HttpContext.Session.SetString("err", "Dang ki thanh cong");
                        return Redirect("/Home/FormDK");
                    }
                }
            }
            else
            {
                HttpContext.Session.SetString("err", "Pass va Re-Pass can giong nhau");
                return Redirect("/Home/FormDK");
            }

            
         
        }
        [HttpPost]
        public IActionResult DangNhap()
        {
            string user = HttpContext.Request.Form["user"];
            string pass = HttpContext.Request.Form["pass"];
            using (var context = new WebShopContext())
            {
                Account a = context.Accounts.Where(x => x.Password == pass && x.Username == user).SingleOrDefault();
                if(a != null)
                {
                    HttpContext.Session.SetString("id", a.Id.ToString());
                    HttpContext.Session.SetString("role", a.Role.ToString());
                    return Redirect("/Home/Trangchu");
                }
                else
                {
                    return Redirect("/Home/FormLogin");
                }
            }
        }
        public  IActionResult Thoat()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Trangchu");
        }

        [HttpPost]
        public IActionResult Search()
        {
            string kq = HttpContext.Request.Form["kq"];
            string brand = HttpContext.Request.Form["brand"];
            using (var context = new WebShopContext())
            {
                List<SanPham> list = new List<SanPham>();
                if(brand == "0")
                {
                    list = context.SanPhams.Where(x => x.Status == true && x.Tensp.ToLower().Contains(kq.ToLower())).ToList();
                }
                else
                {
                    list = context.SanPhams.Where(x => x.Status == true && x.Tensp.ToLower().Contains(kq.ToLower()) && x.Brand== int.Parse(brand)).ToList();
                }
               
                ViewBag.list = list;
                ViewBag.lsp = context.Brands.ToList();
            }
            // luu 1 cai session
            //  HttpContext.Session.SetString("")

            // lay thong tin tu 1 session
            string id = HttpContext.Session.GetString("id");
            string role = HttpContext.Session.GetString("role");
            string sum = HttpContext.Session.GetString("slsp");
            if (sum == null)
            {
                sum = "0";
            }
            ViewBag.id = id;
            ViewBag.role = role;
            ViewBag.slsp = sum;
            ViewBag.br = brand;
            return View();
        }
        public IActionResult AddSp(int id)
        {
            // vi du sp1 co sl 1
            //       sp2 co sl 2

            string cart1 = HttpContext.Session.GetString("cart");

            IDictionary <int, int> cart= new Dictionary<int, int>();
            if(cart1 != null)
            { // vi sp 1 co sl1 la cart1
                cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);
                if (cart.ContainsKey(id))
                {
                    cart[id] += 1;
                }
                else
                {
                    cart.Add(id, 1);
                }
            }
            // la truong hop add lan dau tien
            else
            {
                cart.Add(id, 1);
            }
            
            int sum = 0;
            foreach(KeyValuePair<int,int> item in cart)
            {
                sum += item.Value;
            }
            HttpContext.Session.SetString("slsp",sum.ToString());
            // chuyen cart ve string de luu trong session
            string jsonData= JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);

            return Redirect("/Home/Trangchu");
        }
        public IActionResult XemGH()
        {
            string json = HttpContext.Session.GetString("cart");
            if(json != null)
            {
                IDictionary<int, int> cart = JsonSerializer.Deserialize<Dictionary<int, int>>(json);
                int? sum = 0;
                foreach (KeyValuePair<int, int> item in cart)
                {
                    using (var context = new WebShopContext())
                    {
                        SanPham sp = context.SanPhams.Where(x => x.Id == item.Key).SingleOrDefault();
                        sum += sp.Gia * item.Value;

                    }
                }
                ViewBag.sum = sum;
                ViewBag.cart = cart;
            }
        

            return View();
        }
        public IActionResult ThemHang(int id)
        {
            string cart1 = HttpContext.Session.GetString("cart");

            IDictionary<int, int> cart = new Dictionary<int, int>();
            if (cart1 != null)
            { // vi sp 1 co sl1 la cart1
                cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);
                if (cart.ContainsKey(id))
                {
                    cart[id] += 1;
                }
              
            }
            // la truong hop add lan dau tien
         

            int sum = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                sum += item.Value;
            }
            HttpContext.Session.SetString("slsp", sum.ToString());
            // chuyen cart ve string de luu trong session
            string jsonData = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);

            return RedirectToAction("XemGH");
        }
        public IActionResult BotHang(int id)
        {
            string cart1 = HttpContext.Session.GetString("cart");

            IDictionary<int, int> cart = new Dictionary<int, int>();
            if (cart1 != null)
            { // vi sp 1 co sl1 la cart1
                cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);
                if (cart.ContainsKey(id))
                {
                    if(cart[id]== 1)
                    {
                        cart.Remove(id);

                    }
                    else
                    {
                        cart[id] -= 1;
                    }
                }

            }
            // la truong hop add lan dau tien


            int sum = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                sum += item.Value;
            }
            HttpContext.Session.SetString("slsp", sum.ToString());
            // chuyen cart ve string de luu trong session
            string jsonData = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);

            return RedirectToAction("XemGH");
        }
        [HttpPost]
        public IActionResult AddHD(int sum)
        {
            string note = HttpContext.Request.Form["note"];
            string diachi = HttpContext.Request.Form["diachi"];
            string id = HttpContext.Session.GetString("id");
            using var context = new WebShopContext();
            List<DonHang> list = context.DonHangs.ToList();
            int count = list.Count + 1;
       

            DonHang d = new DonHang();
            d.LuotMua = count;
            d.NguoiMua = int.Parse(id);
            d.GiaTri = sum;
            d.Diachi = diachi;
            d.Date = System.DateTime.Now;
            d.Note = note;
            context.DonHangs.Add(d);
            context.SaveChanges();

            string cart1 = HttpContext.Session.GetString("cart");
            IDictionary<int, int> cart = new Dictionary<int, int>();
            cart = JsonSerializer.Deserialize<Dictionary<int, int>>(cart1);

            DonHang d1 = context.DonHangs.Where(x => x.LuotMua == count).SingleOrDefault();
            foreach(KeyValuePair<int,int> item in cart)
            {
                ChiTietDh ct = new ChiTietDh();
                ct.Iddh = d1.Id;
                ct.Sanpham = item.Key;// key la id cua id cua sp
                ct.Soluong = item.Value;// value la so luong sp trong cart
                SanPham sp = context.SanPhams.FirstOrDefault(x => x.Id == item.Key);
                sp.SoLuong -= item.Value; 

                context.ChiTietDhs.Add(ct);
                context.SanPhams.Update(sp);
                context.SaveChanges();
            }

            // sau khi thanh toan xong can xoa het cac sp trong cart
            cart = new Dictionary<int, int>();
            string jsonData = JsonSerializer.Serialize(cart);
            HttpContext.Session.SetString("cart", jsonData);

            // set so luong cua gio hang
            int sum1 = 0;
            foreach (KeyValuePair<int, int> item in cart)
            {
                sum1 += item.Value;
            }
            HttpContext.Session.SetString("slsp", sum1.ToString());
            return RedirectToAction("Trangchu");
        }


        public  IActionResult QuanLy()
        {
            using var context = new WebShopContext();
            List<SanPham> list = context.SanPhams.ToList();
            ViewBag.list = list;
            ViewBag.lsp = context.Brands.ToList();
            return View();
        }
        public IActionResult AnHien(int id , int loai)
        {
            using var context = new WebShopContext();
            if (loai != 3) 
            {
                
                SanPham sp = context.SanPhams.Where(x => x.Id == id).SingleOrDefault();
                if (loai == 0)
                {
                    sp.Status = false;
                }
                else
                {
                    sp.Status = true;

                }
                context.SanPhams.Update(sp);
                context.SaveChanges();
            }
            else
            {
                SanPham sp = context.SanPhams.Where(x => x.Id == id).SingleOrDefault();
                List<ChiTietDh> chiTietDhs = context.ChiTietDhs.Where(x => x.Sanpham == sp.Id).ToList();
                foreach(ChiTietDh item in chiTietDhs)
                {
                    context.ChiTietDhs.Remove(item);
                }
                context.SanPhams.Remove(sp);
                context.SaveChanges();
            }
            
            return RedirectToAction("QuanLy");
        }
        [HttpPost]
        public IActionResult Addnewsp()
        {
            string ten = HttpContext.Request.Form["ten"];
            string anh = HttpContext.Request.Form["anh"];
            string gia = HttpContext.Request.Form["gia"];
            string sl = HttpContext.Request.Form["sl"];
            string brand = HttpContext.Request.Form["brand"];
            using var context = new WebShopContext();
            SanPham sp = new SanPham();
            sp.Tensp= ten;
            sp.Image = anh;
            sp.Gia = int.Parse(gia);
            sp.SoLuong= int.Parse(sl);
            sp.Brand = int.Parse(brand);
            sp.Status = true;
            context.SanPhams.Add(sp);
            context.SaveChanges();
            return RedirectToAction("QuanLy");
        }
        public IActionResult GiaodienEdit(int id)
        {
            using var context = new WebShopContext();
            SanPham sp = context.SanPhams.Where(x => x.Id == id).SingleOrDefault();
            ViewBag.lsp = context.Brands.ToList();
            ViewBag.sp = sp;
            return View();
        }
        [HttpPost]

        
        public IActionResult Editsp(int id)
        {
            string ten = HttpContext.Request.Form["ten"];
            string anh = HttpContext.Request.Form["anh"];
            string gia = HttpContext.Request.Form["gia"];
            string sl = HttpContext.Request.Form["sl"];
            string brand = HttpContext.Request.Form["brand"];
            using var context = new WebShopContext();
            SanPham sp = context.SanPhams.Where(x => x.Id == id).SingleOrDefault();
            sp.Tensp = ten;
            sp.Image = anh;
            sp.Gia = int.Parse(gia);
            sp.SoLuong = int.Parse(sl);
            sp.Brand= int.Parse(brand);
           
            context.SanPhams.Update(sp);
            context.SaveChanges();
            return RedirectToAction("QuanLy");
        }
        public IActionResult DanhsachDMH()
        {
            using(var context = new WebShopContext())
            {
                List<DonHang> list = context.DonHangs.ToList();
                foreach(DonHang item in list)
                {
                    item.NguoiMuaNavigation = context.Accounts.Where(x => x.Id == item.NguoiMua).Single();
                }
                ViewBag.list = list.OrderByDescending(x=>x.Date);
            }
            return View();
        }
        public IActionResult Chitiet(int id)
        {
            using (var context = new WebShopContext())
            {
                List<ChiTietDh> list = context.ChiTietDhs.Where(x=>x.Iddh==id).ToList();
                foreach (ChiTietDh item in list)
                {
                    item.SanphamNavigation = context.SanPhams.Where(x => x.Id == item.Sanpham).SingleOrDefault();
                }
                ViewBag.list = list;
            }
            return View();
        }

    }
}
