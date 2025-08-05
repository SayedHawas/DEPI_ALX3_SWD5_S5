namespace Day6Lab
{
    public class Human
    {
        //Fields 

        //Property 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //default CTOR 
        public Human()
        {

        }

        public override string ToString()
        {
            return $"Info : Id {Id}\nName : {Name}\nAge : {Age}";
        }

        public virtual double Income()
        {
            return 0;
        }

    }
}
