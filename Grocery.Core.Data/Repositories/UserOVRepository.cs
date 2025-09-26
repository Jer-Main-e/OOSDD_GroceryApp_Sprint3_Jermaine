using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class UserOVRepository : IUserOVRepository
    {
        private readonly List<UserOV> userOV;

        public UserOVRepository()
        {
            userOV = [
                new UserOV(1, "User 1"),
                new UserOV(2, "User 2"),
                new UserOV(3, "User 3"),
                new UserOV(4, "User 4")];
        }

        public List<UserOV> GetAll()
        {
            return userOV;
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
        //    GroceryList? groceryList = groceryLists.FirstOrDefault(g => g.Id == id);
        //    return groceryList;
        //}

        //public GroceryList? Update(GroceryList item)
        //{
        //    GroceryList? groceryList = groceryLists.FirstOrDefault(g => g.Id == item.Id);
        //    groceryList = item;
        //    return groceryList;
        //}
    }
}
