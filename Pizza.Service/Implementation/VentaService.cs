using System.Collections.Generic;
using Pizza.Domain;
using Pizza.Repository;

namespace Pizza.Service.Implementation
{
    public class VentaService : IVentaService
    {
        private IVentaRepository ventaRepo;
        public VentaService(IVentaRepository ventaRepo){
            this.ventaRepo=ventaRepo;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Venta Get(int id)
        {
            return ventaRepo.Get(id);
        }

        public IEnumerable<Venta> GetAll()
        {
            return ventaRepo.GetAll();
        }

        public bool Save(Venta entity)
        {
            return ventaRepo.Save(entity);
        }

        public bool Update(Venta entity)
        {
            return ventaRepo.Update(entity);
        }
    }
}