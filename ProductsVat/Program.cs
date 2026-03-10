namespace ProductsVat
{
    /// <summary>
    /// Reads a product price from the console, calculating the VAT (24%) and the
    /// total price including VAT, and prints the results formatted to 2 decimal places.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Δήλωση και αρχικοποίηση μεταβλητών
            const double VAT_PER_PRODUCT = 0.24D;
            double productPrice = 0D;
            double vat = 0D;
            double totalPrice = 0D;

            // Εισαγωγή δεδομένων, data binding και validation
            Console.WriteLine("Παρακαλώ δώστε την τιμή του προϊόντος:");
            if (!double.TryParse(Console.ReadLine(), out productPrice) || productPrice < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για χιλιόμετρα.");
                return;
            }

            // Μετατροπή και υπολογισμοί - Λογική του προγράμματος
            vat = productPrice * VAT_PER_PRODUCT;
            totalPrice = productPrice + vat;


            // Εμφάνιση αποτελεσμάτων 
            Console.WriteLine($"{"Τελική τιμή προϊόντος",-15} {totalPrice,-15:C2}");
        }
    }
}
