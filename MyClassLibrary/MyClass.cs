namespace MyClassLibrary
{
    public class MyClass                                          //Object     Inherit
    {
        private int PrivateValue { get; set; }                      // X         X
        public int PublicValue { get; set; }                        // O         O
        internal int InternalValue { get; set; }                    // O         O
        protected int ProtectedValue { get; set; }                  // X         O
        internal protected int InternalProtectedValue { get; set; } // O  X      O  O
        private protected int PrivateProtectedValue { get; set; }   // X  X      X  O
    }

    public class TestObject
    {
        public TestObject()
        {
            MyClass Mc = new MyClass();
            Mc.PublicValue = 100;
            Mc.InternalValue = 200;
            Mc.InternalProtectedValue = 300;

        }
    }

    public class TestInhertiance : MyClass
    {
        public TestInhertiance()
        {
            PublicValue = 100;
            InternalValue = 100;
            ProtectedValue = 100;
            InternalProtectedValue = 100;
            PrivateProtectedValue = 100;
        }
    }
}