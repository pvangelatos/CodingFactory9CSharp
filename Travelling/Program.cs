namespace Travelling
{
    internal class Program
    {
        /// <summary>
        /// Reads fuel consumption (liters/100km) adn distance (km) from the user,
        /// calculates the total fuel needed for the trip and the total cost,
        /// and prints the results formatted to 2 decimal places.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Δήλωση και αρχικοποίηση μεταβλητών
            const double FUEL_PRICE = 1.85D; // Example fuel price

            double fuelConsumption = 0D; // liters per 100 km
            double distance = 0D; // kilometers
            double totalFuelNeeded = 0D; // liters
            double cost = 0D; // total cost of fuel for the trip

            // Εισαγωγή δεδομένων, data binding και validation
            Console.WriteLine("Παρακαλώ δώστε την κατανάλωση καυσίμου (λίτρα/100χλμ):");
            if (!double.TryParse(Console.ReadLine(), out fuelConsumption) || fuelConsumption < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για κατανάλωση καυσίμου.");
                return;
            }
            Console.WriteLine("Παρακαλώ δώστε την απόσταση του ταξιδιού σε χλμ:");
            if (!double.TryParse(Console.ReadLine(), out distance) || distance < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για χιλιομετρική απόσταση.");
                return;
            }


            // Μετατροπή και υπολογισμοί - Λογική του προγράμματος
            totalFuelNeeded = Math.Round(fuelConsumption * distance / 100, 2); // Convert to liters
            cost = Math.Round(totalFuelNeeded * FUEL_PRICE, 2); // Calculate total cost


            // Εμφάνιση αποτελεσμάτων 
            Console.WriteLine($"{"Κατανάλωση:", -25} {fuelConsumption:N2}");
            Console.WriteLine($"{"Απόσταση:", -25} {distance:N2}");
            Console.WriteLine($"{"Τιμή καυσίμου:", -25} {FUEL_PRICE:N2}");
            Console.WriteLine($"{"Λίτρα που χρειάζονται:", -25} {totalFuelNeeded:N2}");
            Console.WriteLine($"{"Κόστος ταξιδίου", -25} {cost:C2}");
            


        }
    }
}
