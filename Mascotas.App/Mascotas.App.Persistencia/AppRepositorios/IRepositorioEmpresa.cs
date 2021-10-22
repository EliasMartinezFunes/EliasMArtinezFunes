using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;


namespace Mascotas.App.Persistencia.AppRepositorios
{
   public interface IRepositorioEmpresa
    {
        //firma de los metodos
        // Ejemplo : descriptores de acceso (public, private, proted), valor de retorno tipo de variable, Nombre del metodo, variables de entrada. 
        
        //Ingresar información a la base de datos a la tabla Empresa
        ClaseEmpresa AddClasEmpresa(ClaseEmpresa empresas);

        

        //
        IEnumerable<ClaseEmpresa> GetAllEmpresa();
        
        //Consultar una Empresa segun Id.
        ClaseEmpresa GetClaseEmpresa(long nit);

        void DeleteClaseEmpresa(long nit);

        //firma del metodo para actualizar información de la persona en la base de datos.
        ClaseEmpresa UpdateClasEmpresa(ClaseEmpresa empresas);
        
        
    
    }
}