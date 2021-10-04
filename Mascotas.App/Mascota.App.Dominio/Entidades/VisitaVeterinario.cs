namespace Mascota.App.Dominio.Entidades
{
    public class VisitaVeterinario
    {
        public int Id {get; set;}
        public string Fecha {get; set;}
        public string Temperatura {get; set;}
        public string Peso {get; set;}
        public string FrecuenciaRespiratoria {get; set;}
        public string FrecuenciaCardiaca {get; set;}
        public string EstadoAnimal {get; set;}
        public string IdVeterinario {get; set;}
        public string Recomendacion {get; set;}
    }
}