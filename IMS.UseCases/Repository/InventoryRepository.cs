using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        public List<Inventory> Inventories { get; set; }
        public InventoryRepository()
        {
            Inventories = new();
            Inventories.Add(new Inventory() { Id=1, Name ="Bike", Price = 10, Quantity =5 });
            Inventories.Add(new Inventory() { Id=2, Name ="Spoke", Price = 12, Quantity =7 });
            Inventories.Add(new Inventory() { Id=3, Name ="Wheel", Price = 09, Quantity =3 });
            Inventories.Add(new Inventory() { Id=4, Name ="Jack", Price = 6, Quantity =8 });
            Inventories.Add(new Inventory() { Id=5, Name ="Tyre", Price = 17, Quantity =50 });
        }
        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
                return await Task.FromResult(Inventories);

            return Inventories.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<int> CreateInventoryAsync(Inventory inventory)
        {
            inventory.Id =  Inventories.Max(c => c.Id) + 1;

            Inventories.Add(inventory);
            return await Task.FromResult(inventory.Id);
        }
    }
}
