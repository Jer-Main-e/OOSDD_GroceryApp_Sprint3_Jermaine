
namespace Grocery.Core.Models
{
    public partial class UserOV : Model
    {
        public UserOV(int id, string name) : base(id, name)
        {
            Id = id;
            Name = name;
        }

    }
}
