using System;
class Program {

    static string IsAdult (int x ) {
        if (x >= 18) return "You are adult"; // try add comment to allow me to stage this one
        return "Nah you not";
    }
    static void Main() {
        int age = 18;
        Console.WriteLine  (IsAdult (age));
        Console.ReadKey(true);
    }
    
}