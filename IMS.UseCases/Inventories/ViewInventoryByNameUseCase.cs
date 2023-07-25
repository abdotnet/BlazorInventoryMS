using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoryByNameUseCase : IViewInventoryByNameUseCase
    {
        private readonly IInventoryRepository iventoryRepository;

        public ViewInventoryByNameUseCase(IInventoryRepository iventoryRepository)
        {
            this.iventoryRepository=iventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await iventoryRepository.GetInventoryByNameAsync(name);
        }
    }
}
