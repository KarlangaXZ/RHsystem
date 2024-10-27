namespace RRHHSystem.Models{
    public class Permiso
{
    public int Id { get; set; }
    public string PermisoDescripcion { get; set; }
    public bool Activo { get; set; }
    public int CargoId { get; set; }
    public Cargo Cargo { get; set; }
}
}