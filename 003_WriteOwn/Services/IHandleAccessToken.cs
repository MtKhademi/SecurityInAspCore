namespace _003_WriteOwn.Services
{
    public interface IHandleAccessToken<TModel>
    {
        string GetAccessToken(TModel model);
        TModel GetModelFromAccessToken(string accessToken);

    }
}
