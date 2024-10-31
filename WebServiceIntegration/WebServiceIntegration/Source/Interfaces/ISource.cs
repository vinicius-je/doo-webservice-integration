namespace WebServiceIntegration.Source.Interfaces
{
    public interface ISource<T>
    {
        Task<List<T>> Execute(string endpoint);
    }
}
