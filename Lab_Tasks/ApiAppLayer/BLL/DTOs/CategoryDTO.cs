using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CategoryDTO
    {
        public int Cid { get; set; }
        public string Name { get; set; }
        public virtual ICollection<News> News { get; set; }
        public CategoryDTO()
        {
            News = new List<News>();
        }
    }
}
