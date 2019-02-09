using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.MyModels
{
   
    public class NewsComment
    {
        [BsonElement("news_id")]
        public string news_id { get; set; }
        [BsonElement("user_name")]
        public string user_name { get; set; }
        [BsonElement("add_time")]
        public string add_time { get; set; }
        [BsonElement("content")]
        public string content { get; set; }
    }
}