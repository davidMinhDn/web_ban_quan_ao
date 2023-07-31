using System;
using System.Collections.Generic;

#nullable disable

namespace Slot10.Models
{
    public partial class ChiTietDh
    {
        public int Idct { get; set; }
        public int? Iddh { get; set; }
        public int? Sanpham { get; set; }
        public int? Soluong { get; set; }

        public virtual DonHang IddhNavigation { get; set; }
        public virtual SanPham SanphamNavigation { get; set; }
    }
}
