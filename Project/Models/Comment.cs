using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Comment
    {
        public int ID_Conmment { get; set; }
        public string NoiDung { get; set; }
        public int ID_NguoiCom { get; set; }
        public DateTime NgayCom { get; set; }
        public int ID_Topic { get; set; }
    }
}
