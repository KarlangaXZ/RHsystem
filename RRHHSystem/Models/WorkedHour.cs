namespace RRHHSystem.Models
{
    public class WorkedHour
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int HoursWorked { get; set; }
    }
}