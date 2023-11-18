using EntityCoreCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// domain model
namespace EntityCoreCourse
{
    public class Posts
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Context { get; set; }
        public Blog Blog { get; set; } //application propertiy
    }
}
