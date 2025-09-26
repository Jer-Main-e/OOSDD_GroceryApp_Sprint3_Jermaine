using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IUserOVRepository
    {
        public List<UserOV> GetAll();

        //public UserOV Add(UserOV item);

        //public UserOV? Delete(UserOV item);

        //public UserOV? Get(int id);

        //public UserOV? Update(UserOV item);
    }
}
