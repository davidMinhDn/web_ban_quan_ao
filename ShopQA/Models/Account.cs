using System;
using System.Collections.Generic;

#nullable disable

namespace Slot10.Models
{
    public partial class Account
    {
        public Account()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
