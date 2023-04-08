using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class Repo
    {
        public CNContext db;
        public Repo()
        {
            db = new CNContext();
        }
    }
}
