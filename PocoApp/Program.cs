namespace PocoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new();    // C# 9
            var julia = new Student(); // C# 10    

            Teacher teacher = new Teacher(1, "Μάκης", "Καπέτης");   // Overloaded Constructor
            // ή άλλος τρόπος
            Teacher teacher1 = new (2, "Αθανάσιος", "Ανδρούτσος");

            // Student student = new() { Id = 3, Firstname = "Παναγιώτης", Lastname = "Βαγγελάτος"};
        }
    }
}
