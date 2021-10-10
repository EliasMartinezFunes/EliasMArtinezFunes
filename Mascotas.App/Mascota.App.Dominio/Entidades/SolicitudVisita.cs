namespace Mascota.App.Dominio.Entidades
{
    public class SolicitudVisita
    {
        public int Id {get; set;}
        public string IdDueño {get; set;}
        public string NombreMascota {get; set;}
        public string TipoMascota {get; set;}
        public string Veterinario {get; set;}
        public string FechaVisita {get; set;}
    }
}