namespace RRHHSystem.Models{
    public class Ponche
{
    public int PoncheId { get; set; }
    public DateTime FechaEntrada { get; set; }
    public DateTime FechaSalida { get; set; }
    public int EmpleadoId { get; set; }
    public Employee Empleado { get; set; }
}
}