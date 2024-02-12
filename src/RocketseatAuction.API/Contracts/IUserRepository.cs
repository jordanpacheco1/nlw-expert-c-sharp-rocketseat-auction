using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IUserRepository
{
    public bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
