using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class TaiKhoan
    {
        public int ID_TK { get; set; }
        public string Taikhoan { get; set; }
        public string MatKhau { get; set; }
        public bool Is_AD { get; set; }
        public bool Is_Active { get; set; }
    }
}
