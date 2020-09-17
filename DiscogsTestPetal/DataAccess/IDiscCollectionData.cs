using DiscogsTestPetal.Models;
using System.Threading.Tasks;

namespace DiscogsTestPetal.DataAccess
{
    public interface IDiscCollectionData
    {
        Task<Collection> GetCollectionInfoAsync(int quantity);
    }
}
