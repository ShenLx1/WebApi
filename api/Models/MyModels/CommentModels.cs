using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models.MyModels
{
    [BsonIgnoreExtraElements]
    public class CommentModels
    {
        [BsonElement("type")]
        public string type { get; set; }//类别判定标识符
        [BsonElement("match_id")]
        public string match_id { get; set; }
        [BsonElement("user_name")]
        public string user_name { get; set; }
        [BsonElement("add_time")]
        public string add_time { get; set; }
        [BsonElement("content")]
        public string content { get; set; }
    }
   
}