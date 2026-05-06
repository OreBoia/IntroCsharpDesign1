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
        // ReadLineExamples();
        // VariableOperationsExamples();
        // IfExamples();
        // IfElseExamples();
        // SwitchExamples();
        // WhileExample();
        ForExamples();
    }

    /// <summary>
    /// Questa funzione esegue del codice
    /// </summary>
    public static void MyMethod()
    {
        
    }

    public static void VariableExamples()
    {
        //Esempio Console.WritLine()
        Console.WriteLine("Hello, World!");
        //Esempio Richiamo metodo
        MyMethod();

        //Esempio stampa variabili
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

    public static void ReadLineExamples()
    {
        // Console.Write($"Ciao, inserisci il tuo nome e cognome: ");
        
        // Dichiarazione e poi assegnazione tramite lettura 
        // string name;
        // name = Console.ReadLine();

        // Dichiarazione e Lettura 
        // string? name = Console.ReadLine(); //"123"
        // string? surname = Console.ReadLine();

        // Console.WriteLine($"il tuo nome è {name + surname}");

        //Conversione string to int (int.Parse())
        Console.Write("Inserisci n1: ");
        string? n1 = Console.ReadLine();
        
        Console.Write("inserisci n2: ");
        string? n2 = Console.ReadLine();
        
        int number1 = int.Parse(n1);
        int number2 = int.Parse(n2);

        Console.WriteLine($"Somma number1 + number2 = {number1 + number2}");
    }

    public static void VariableOperationsExamples()
    {
        Console.WriteLine($"Inserisci 2 numeri");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        // Console.WriteLine($"\n---- Operazioni Aritmetiche\n");
        int sum = a + b;
        // Console.WriteLine($"Somma di a e b = {sum}");
        // int diff = a - b;
        // Console.WriteLine($"Sottrazione di a e b = {diff}");
        // double div = a / b;
        // Console.WriteLine($"Divisione di a e b = {div}");
        // int prod = a * b;
        // Console.WriteLine($"Prodotto di a e b = {prod}");
        // int resto = a % b;
        // Console.WriteLine($"Resto di a e b = {resto}");

        Console.WriteLine($"\n---- Operazioni di Assegnazione\n");

        sum = sum + 10;
        Console.WriteLine($"somma + 10 = {sum}");
        sum += 10;
        Console.WriteLine($"somma += 10 = {sum}");
        sum -= 10;
        Console.WriteLine($"somma -= 10 = {sum}");
        sum *= 2;
        Console.WriteLine($"somma *= 2 = {sum}");
        sum /= 2;
        Console.WriteLine($"somma /= 2 = {sum}");
        sum++;//sum+=1 o sum = sum + 1 
        Console.WriteLine($"somma ++ = {sum}");
        sum--; //sum-=1 o sum = sum - 1
        Console.WriteLine($"somma -- = {sum}");

        Console.WriteLine($"\n---- Operazioni di Comparazione\n");

        Console.WriteLine($"a è UGUALE a b? {a == b}");
        Console.WriteLine($"a è DIVERSO da b? {a != b}");
        Console.WriteLine($"a è MINORE di b? {a < b}");
        Console.WriteLine($"a è MINORE o UGUALE di b? {a <= b}");
        Console.WriteLine($"a è MAGGIORE di b? {a > b}");
        Console.WriteLine($"a è MAGGIORE o UGUALE di b? {a >= b}");

        Console.WriteLine($"\n---- Operazioni Logiche\n");
        Console.WriteLine($"AND: {a > b && a == 16 && b < a}");
        Console.WriteLine($"OR: {a < b || a == 5}");
        Console.WriteLine($"NOT: {!(a < 5)}");
        
    }

    public static void IfExamples()
    {
        Console.Write($"Inserisci primo numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write($"Inserisci secondo numero: ");
        int b = int.Parse(Console.ReadLine());

        if(a < b && a > 10)
        {
            Console.WriteLine($"{a} è minore di {b}");
        }

        if(a > b)
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }

        if(!(a == b))
        {
            Console.WriteLine($"{a} è uguale a {b}");
        }
    }

    public static void IfElseExamples()
    {
        Console.Write($"Inserisci primo numero: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write($"Inserisci secondo numero: ");
        int b = int.Parse(Console.ReadLine());

        if(a < b)
        {
            Console.WriteLine($"{a} è minore di {b}");
        }
        else if (a > b)
        {
            Console.WriteLine($"{a} è maggiore di {b}");
        }
        else if (a != b)
        {
            Console.WriteLine($"{a} è diverso da {b}");
        }
        else
        {
            Console.WriteLine($"{a} è uguale a {b}");
        }
    }

    public static void SwitchExamples()
    {
        string giorno = "lunedì";

        switch (giorno)
        {
            case "lunedì":
                Console.WriteLine($"Siamo a lunedì, sono già stanco");
                Console.WriteLine($"voglio dormire");
                break;
            case "Venerdì":
                Console.WriteLine($"Finalmente siamo al weekend, posso dormire");
                break;
            default:
                Console.WriteLine($"giorno errato, questo giorno non esiste: {giorno}");
                break;
        }

        //Match Pattern
        int numero = 10;
        switch (numero)
        {
            case > 9:
                Console.WriteLine($"Il numero {numero} è maggiore di 9");
                break;
            case >= 5 and < 9:
                Console.WriteLine($"Il numero {numero} è tra 5 e 8");
                break;
            case < 5:
                Console.WriteLine($"Il numero {numero} è minore di 5");
                break;
            default:
                Console.WriteLine($"Numero non gestito: {numero}");
                break;
        }
    }

    public static void WhileExample()
    {
        // int n = 0;
        // while(n < 10)
        // {
        //     Console.WriteLine($"({n}) Ciclo in esecuzione");
        //     // continua = int.Parse(Console.ReadLine()) == 0;
        //     n++;
        // }

        // int numero = 120;
        // while(numero < 0 || numero > 100)
        // {
        //     Console.WriteLine($"Inserisci un numero tra 0  e 100");
        //     numero = int.Parse(Console.ReadLine());

        //     if(numero < 0 || numero > 100)
        //     {
        //         Console.WriteLine($"{numero} non è nel range richiesto (0 - 100)");
        //     }
        // }

        // int scelta = 0;

        // while (true)
        // {
        //     Console.WriteLine($"inserisci un numero da 1 a 3");
        //     scelta = int.Parse(Console.ReadLine());

        //     Console.Write($"Inserisci numero 1: ");
        //     int numero1 = int.Parse(Console.ReadLine());
            
        //     Console.Write($"Inserisci numero 2: ");
        //     int numero2 = int.Parse(Console.ReadLine());
            
        //     switch (scelta)
        //     {
        //         case 1:
        //             Console.WriteLine($"Faccio una somma {numero1 + numero2}");
        //             break;
        //         case 2:
        //             Console.WriteLine($"Faccio una sottrazione {numero1 - numero2}");
        //             break;
        //         case 3:
        //             Console.WriteLine($"Esco, ciao");
        //             break;
        //     }
            
        //     if(scelta == 3) break;
        // }

        // bool continua = false;
        // do
        // {
        //     Console.WriteLine($"Do While in esecuzione");
        //     continua = int.Parse(Console.ReadLine()) == 0;
        // }while(continua);
    }

    public static void ForExamples()
    {   
        //int i = 0;
        // for(int i = 0; i < 10; i++) //i< 10 (condizione) 
        // {
        //     if(i % 2 == 0) continue;
        //     Console.WriteLine($"Iterazione numero {i}");
        //     Console.Write($"Numero Pari o dispari ?");
        //     if(i % 2 == 0)
        //     {
        //         Console.WriteLine($"{i} è pari");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{i} è dispari"); 
        //     }

        // }//i++

        int nIterazioni = int.Parse(Console.ReadLine());

        int somma = 0;
        for(int i = 0; i < nIterazioni; i++)
        {
            int numero = int.Parse(Console.ReadLine()); //10
            somma += numero; // 0 + 10 = 10 (somma = 10)
            Console.WriteLine($"La somma è = {somma} a Iterazione {i}");
        }

        // Console.WriteLine($"La somma totale è = {somma}");
    }
}