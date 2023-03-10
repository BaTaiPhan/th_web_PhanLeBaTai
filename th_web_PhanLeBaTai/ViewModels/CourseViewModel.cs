using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using th_web_PhanLeBaTai.Models;

namespace th_web_PhanLeBaTai.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}