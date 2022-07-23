namespace Clever.Kindergarten.Data.AbstractionModels
{
    public interface CleverOperations<T>
    {
        public IEnumerable<T> GetAllData();
        public T GetById(int id);
        public void Add(T model);
        public void Update(T model);
        public void Delete(T model);

    }
}