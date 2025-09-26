using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class UserOVService : IUserOVService
    {
        private readonly IUserOVRepository _userOVRepository;
        public UserOVService(IUserOVRepository userOVRepository)
        {
            _userOVRepository = userOVRepository;
        }
        public List<UserOV> GetAll()
        {
            return _userOVRepository.GetAll();
        }
        //public GroceryList Add(GroceryList item)
        //{
        //    throw new NotImplementedException();
        //}

        //public GroceryList? Delete(GroceryList item)
        //{
        //    throw new NotImplementedException();
        //}

        //public GroceryList? Get(int id)
        //{
        //    return _groceryRepository.Get(id);
        //}

        //public GroceryList? Update(GroceryList item)
        //{
        //    return _groceryRepository.Update(item);
        //}
    }
}
