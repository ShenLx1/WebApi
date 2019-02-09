using api.Models.MyModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.Models
{
    //[BsonIgnoreExtraElements]
    //[BsonId]
    //public ObjectId ID { get; set; }
    //两者总要加一个
    [BsonIgnoreExtraElements]
    public class NewsModels
    {
        [BsonElement("uniquekey")]
        public string uniquekey { get; set; }
        [BsonElement("title")]
        public string title { get; set; }
        [BsonElement("date")]
        public string date { get; set; }
        [BsonElement("category")]
        public string category { get; set; }
        [BsonElement("author_name")]
        public string author_name { get; set; }
        [BsonElement("img")]
        public string img { get; set; }
        [BsonElement("Detail")]
        //public  Detail { get; set; }
        //这里不用list接收！！ 不然会序列化失败BsonDocument
        public NewsDetail Detail { get; set; }
        [BsonElement("Comment")]
        public List<NewsComment>  Comment { get; set; }
    }

    public class NewsDetail
    {
        [BsonElement("date")]
        public string date { get; set; }
        [BsonElement("category")]
        public string category { get; set; }
        [BsonElement("author_name")]
        public string author_name { get; set; }
        [BsonElement("url")]
        public string url { get; set; }
        [BsonElement("image1")]
        public string image1 { get; set; }
        [BsonElement("image2")]
        public string image2 { get; set; }
        [BsonElement("image3")]
        public string image3 { get; set; }
        [BsonElement("content")]
        public string content { get; set; }
    }

    public class NewsComment
    {
        [BsonElement("type")]
        public string type { get; set; }//类别判定标识符
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