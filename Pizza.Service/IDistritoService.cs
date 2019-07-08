using Pizza.Domain;

namespace Pizza.Service
{
    public interface IDistritoService: IService<Distrito>
    {
         Distrito fetchByNombre(string nombre);     
    }
}