using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinario();
        Veterinario AddVeterinario(Veterinario Veterinario);
        Veterinario UpdateVeterinario(Veterinario Veterinario);
        void DeleteVeterinario(int IdVeterinario);
        Veterinario GetVeterinario(int IdVeterinario);
    }
}