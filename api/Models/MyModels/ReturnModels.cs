using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.MyModels
{
    public class ReturnModels<T>//为返回值类增加泛型来自定义类型
    {
        public int message { get; set; }
        public List<T> data { get; set; }
        public IEnumerable<object> dataByPage { get; set; }
        public T data_single { get; set; }
        public string time { get; set; }
    }
}