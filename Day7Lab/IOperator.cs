namespace Day7Lab
{
    public interface IOperator //CRUD Create , Update , Read(All , By Id) , Delete 
    {
        void Create();
        void Delete();
        void Update();
        void GetAll();
        void GetById(int id);

        //public void GetByName(string name)
        //{ 

        //}
    }
}
