class Program
{
    static int age;
    static int Age = 25;
    static private float _number = 10.87f;
    static double doubleNum = 12.45d;
    static bool isBool = true;
    
    /*
        (public) - Modificatore di accesso
        (static) - Legato alla classe
        (Void) - Tipo di ritorno
        (Main) - Nome del metodo
        (string[] args) - parametri
    */
    public static void Main(string[] args)
    {
        //Esempio Console.Writline()
        Console.WriteLine("Hello, World!");
        //Esempio Richiamo metodo
        MyMethod();

        //Esempio stampa varibili
        age = 123;
        Console.WriteLine("age: " + age);
        Console.WriteLine("Age: " + Age);

        //Stampa variabili tipi differenti
        Console.WriteLine("numero double: " + doubleNum + " --- numero float: " + _number);
        //Interpolazione
        Console.WriteLine($"Double Number = {doubleNum} --- Float Number: {_number}");

        //Casting Implicito (Widening)
        int num1 = 10;
        float num2 = num1;
        Console.WriteLine($"num1 {num1} --- num2 {num2}");
        //Casting Esplicito (Narrowing)
        float num3 = 12.456f;
        int num4 = (int)num3;
        Console.WriteLine($"num3 {num3} --- num4 {num4}");
    }

    /// <summary>
    /// Questa funzione esegue del codice
    /// </summary>
    public static void MyMethod()
    {
        
    }
}