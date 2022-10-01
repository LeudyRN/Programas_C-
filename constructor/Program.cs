class asignatura{

    private string Nombre;

    private double Nota1;

    private double Nota2;

    private double Nota3;

    private double NotaFinal;


    public asignatura(){

    Console.WriteLine("Nombre del estudiante: ");   
    Nombre = Console.ReadLine();

    Console.WriteLine($"Ingrese la primera nota del estudiante {Nombre}:");
    Nota1 = double.Parse (Console.ReadLine()); 

    Console.WriteLine($"Ingrese la segunda nota del estudiante {Nombre}:");
    Nota2 = double.Parse (Console.ReadLine()); 

    Console.WriteLine($"Ingrese la tercera nota del estudiante {Nombre}:");
    Nota3 = double.Parse (Console.ReadLine()); 


    }
   
   ~ asignatura() 
	{Console.WriteLine ("\n\n Destructor liberando especio \n");}



    public   void mostrarNotas(){

        NotaFinal = Nota1 + Nota2 + Nota3;

        Console.WriteLine($"La nota final del estudiante {Nombre} es: " + NotaFinal);
    }


    public void estatusProRe(){

        if(NotaFinal >= 70) {
            Console.WriteLine("Felicitaciones, usted a aprobado la asignatura INF-512 ");
        }
        else{
            Console.WriteLine("Has reprobado la asignatura INF-512 ");
        }
    }
    
}

class pruebaCL{

    static void Main(){

        asignatura asigna = new asignatura();

        Console.Clear();
        asigna.mostrarNotas();
        asigna.estatusProRe();
        Console.ReadKey();
        
    }
}