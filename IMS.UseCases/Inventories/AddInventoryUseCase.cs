using IMS.CoreBusiness;
using IMS.UseCases.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository=inventoryRepository;
        }
        public async Task<int> ExecuteAsync(Inventory inventory)
        {
            return await inventoryRepository.CreateInventoryAsync(inventory);
        }
    }
}
