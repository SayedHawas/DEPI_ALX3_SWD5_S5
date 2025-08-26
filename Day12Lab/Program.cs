namespace Day12Lab
{
    internal class Program
    {
        private int myVar = 5;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public int Id { get; set; } = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee em = new Employee();
            em.Add(new Employee());
            ((IOperation<Employee>)em).Saveing();


            IOperation<Employee> Em2 = new Employee();
            Em2.Saveing();


            test2 t = new test2("khfhkgfhgfhgf");
            Console.ReadLine();

        }
    }
    public class Employee : Human, IOperation<Employee>, IStreamFile<Employee>
    {


        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public override int getID()
        {
            throw new NotImplementedException();
        }



        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Employee entity)
        {
            // throw new NotImplementedException();
        }
        void IStreamFile<Employee>.Add(Employee Entity)
        {
            throw new NotImplementedException();
        }

        byte[] IStreamFile<Employee>.Read()
        {
            throw new NotImplementedException();
        }

        void IStreamFile<Employee>.Write(Employee File)
        {
            throw new NotImplementedException();
        }
    }
    public abstract class Human
    {
        public abstract int getID();

    }
    public interface IOperation<T>
    {
        //int x;
        public T GetByID(int id);
        public void Add(T entity);
        public void Delete(T entity);
        public void Update(T entity);
        public IEnumerable<T> GetAll();

        public void Saveing()
        {
            //throw new Exception();
        }
    }

    public interface IStreamFile<T>
    {
        public void Add(T Entity);
        public void Write(T File);
        public byte[] Read();
    }


    public class test
    {

        public test() : this("Toto")
        {

        }

        public test(string str)
        {
            Console.WriteLine(str);
        }
    }


    class test2 : test
    {
        public test2(string str) : base(str)
        {

        }
    }
}
