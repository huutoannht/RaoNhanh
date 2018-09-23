using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models.Common
{
    public static class Constants
    {
        public static string LocaltionImage = "content\\uploads\\images\\";
        public static string LocaltionImageDb = "\\content\\uploads\\images\\";
        public static string LocaltionImageSmall = "content\\uploads\\images\\small\\";
        public static string LocaltionFileBlog = "content\\uploads\\blogs\\";
        public static string LocaltionFile = "content\\uploads\\files\\";
        public class TYPE_PICTURE
        {
            public static int Picture = 1;
            public static int Slide =2;
            public static int Blog = 3;
            public static int Product = 4;
            public static int Category = 4;
        }
    }
}
