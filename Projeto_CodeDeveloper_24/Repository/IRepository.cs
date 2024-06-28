namespace Projeto_CodeDeveloper_24.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> All();
        T? Get(int id);
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}