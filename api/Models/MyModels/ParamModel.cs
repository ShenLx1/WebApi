using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    public class ParamModel
    {
        public string id { get; set; }

        public string gid { get; set; }
        public int page { get; set; }
        public string backup_id { get; set; }
        public string type { get; set; }//新闻还是图片标识
    }
}