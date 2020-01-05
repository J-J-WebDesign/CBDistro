namespace CBDistro.Services
{
    public interface IIdentityProvider<T>
    {
        T GetCurrentUserId();
    }
}