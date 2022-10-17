using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214056
{
    internal class Anime2_1214056 : product_1214056
    {
        protected string duration;

        public Anime2_1214056(string title, string episode, string duration) //method constructor dengan 3 parameter
        {
            this.MyTitle = title;
            this.EpisodeCount = episode;
            this.duration = duration;
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
