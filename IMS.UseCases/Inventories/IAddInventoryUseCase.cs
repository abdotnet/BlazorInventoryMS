using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories
{
    public interface IAddInventoryUseCase
    {
        Task<int> ExecuteAsync(Inventory inventory);
    }
}