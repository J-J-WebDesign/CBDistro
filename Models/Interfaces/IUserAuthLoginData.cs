using System.Collections.Generic;

namespace CBDistro.Models
{
    public interface IUserAuthLoginData
    {
        int Id { get; }
        string Name { get; }
        string Role { get; }
        object TenantId { get; }
    }
}