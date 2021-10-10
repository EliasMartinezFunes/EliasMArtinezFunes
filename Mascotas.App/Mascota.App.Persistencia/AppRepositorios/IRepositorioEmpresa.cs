using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEmpresa
    {
        IEnumerable<EmpresaVeterinaria> GetAllEmpresa();
        EmpresaVeterinaria AddEmpresa(EmpresaVeterinaria Empresa);
        EmpresaVeterinaria UpdateEmpresa(EmpresaVeterinaria Empresa);
        void DeleteEmpresa(int IdEmpresa);
        EmpresaVeterinaria GetEmpresa(int IdEmpresa);
    }
}