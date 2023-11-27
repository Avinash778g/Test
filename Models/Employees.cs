namespace Test.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentsId { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }

    }
}
