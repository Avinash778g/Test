using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class Datacontacts : DbContext
    {
        public Datacontacts(DbContextOptions options) : base(options)
        {
        }
        public int MyProperty { get; set; }
    }
}
