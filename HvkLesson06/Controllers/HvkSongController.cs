using HvkLesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HvkLesson06.Controllers
{
    public class HvkSongController : Controller
    {
        private static List<HvkSong> hvkSongs = new List<HvkSong>()
        {
            new HvkSong(){Id=2210900109,HvkTitle="Hoàng Văn Khải",HvkAuthor="K22CNT4",HvkArtist="NTU",HvkYearRelease=2020},
             new HvkSong(){Id=1,HvkTitle="Hoàng Văn Khải",HvkAuthor="K22CNT4",HvkArtist="NTU",HvkYearRelease=2020}
        };
        // GET: HvkSong
        public ActionResult HvkIndex()
        {
            return View(hvkSongs);
        }
        public ActionResult HvkCreate() 
        { 
            var HvkSong = new HvkSong();
            return View(hvkSongs);
        }
    }
}