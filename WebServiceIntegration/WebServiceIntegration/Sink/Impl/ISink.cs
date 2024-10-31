namespace WebServiceIntegration.Sink.Impl
{
    public interface ISink<Entity>
    {
        Task Execute(List<Entity> list, string filename);
    }
}
