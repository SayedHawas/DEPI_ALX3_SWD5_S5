namespace Day9LabADOConnection
{
    public interface ICRUDOperation<T> where T : class   //CRUD
    {
        public void Insert(T Entry);
        public void Update(T Entry);
        public void Delete(int id);
        public T GetById(int id);
        public IEnumerable<T> GetAll();
    }
}
