using EntityCoreCourse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// domain model
namespace EntityCoreCourse
{
    //  [Table("Posters")] change the table name to posters
    public class Posts
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[Column("hhhh")] change only column name
        public string Context { get; set; }
        public Blog Blog { get; set; } //application propertiy
    }
}
