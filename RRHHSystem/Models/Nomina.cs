namespace RRHHSystem.Models{
    public class Nomina
{
    public int Id { get; set; }
    public int EmpleadoId { get; set; }
    public Employee Empleado { get; set; }
    public decimal Salario { get; set; }
    public int HorasTrabajadas { get; set; }
    public int HorasExtras { get; set; }
    public decimal TotalDineroHorasExtras { get; set; }
    public DateTime FechaGeneracionNomina { get; set; }
    public string CorteNomina { get; set; }
    public decimal TotalAPagar { get; set; }
}
}