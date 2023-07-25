using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Repository
{
    public interface IInventoryRepository
    {
        Task<int> CreateInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name);
    }
}
