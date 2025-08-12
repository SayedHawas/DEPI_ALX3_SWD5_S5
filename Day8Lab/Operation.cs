namespace Day8Lab
{
    public class Operation<T> //CRUD Create , Read (All , ByID) , Update , Delete
    {
        public IEnumerable<T> GetAll()
        {
            return null;
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }
        public void Create(T employee)
        {
        }
        public void Update(T employee)
        {
        }
        public void Delete(int id)
        {

        }
    }
}
