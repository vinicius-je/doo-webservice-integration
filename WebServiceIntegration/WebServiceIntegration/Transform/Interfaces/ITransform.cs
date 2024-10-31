namespace WebServiceIntegration.Transform.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="E">Entity</typeparam>
    /// <typeparam name="D">DTO</typeparam>
    public interface ITransform<E, D>
    {
        public List<E> Execute(List<D> list);
    }
}
