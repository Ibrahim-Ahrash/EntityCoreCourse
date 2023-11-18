// See https://aka.ms/new-console-template for more information
using EntityCoreCourse;

class Porgram
{
    static void Main(string[] args)
    {
        var _context = new ApplicationDbContext();
        _context.SaveChanges();

    }
}