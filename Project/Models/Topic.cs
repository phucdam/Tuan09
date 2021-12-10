using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Topic
    {
        public int ID_Topic { get; set; }
        public string TenTopic { get; set; }
        public string NoiDung { get; set; }
        public int ID_NguoiDang { get; set; }
        public DateTime NgayDang { get; set; }
        public bool TrangThai { get; set; }
        public bool ChoPhepComment { get; set; }
    }
}
