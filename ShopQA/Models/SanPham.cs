using System;
using System.Collections.Generic;

#nullable disable

namespace Slot10.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietDhs = new HashSet<ChiTietDh>();
        }

        public int Id { get; set; }
        public string Tensp { get; set; }
        public string Image { get; set; }
        public int? Gia { get; set; }
        public int? Brand { get; set; }
        public int? SoLuong { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ChiTietDh> ChiTietDhs { get; set; }
    }
}
