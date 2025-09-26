using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IUserOVService
    {
        public List<UserOV> GetAll();

        //public GroceryList Add(GroceryList item);

        //public GroceryList? Delete(GroceryList item);

        //public GroceryList? Get(int id);

        //public GroceryList? Update(GroceryList item);
    }
}
