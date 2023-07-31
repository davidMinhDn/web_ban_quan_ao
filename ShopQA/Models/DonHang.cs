using System;
using System.Collections.Generic;

#nullable disable

namespace Slot10.Models
{
    public partial class DonHang
    {
        public DonHang()
        {
            ChiTietDhs = new HashSet<ChiTietDh>();
        }

        public int Id { get; set; }
        public int? LuotMua { get; set; }
        public int? NguoiMua { get; set; }
        public int? GiaTri { get; set; }
        public string Diachi { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }

        public virtual Account NguoiMuaNavigation { get; set; }
        public virtual ICollection<ChiTietDh> ChiTietDhs { get; set; }
    }
}
