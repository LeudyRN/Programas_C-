public class Utils{

    public static int inputInt(string mensaje){
        int resultado = 0;
        Console.WriteLine(mensaje);
        try{
        resultado = int.Parse(Console.ReadLine());
        }catch(Exception ex){
            Console.WriteLine("Digite un numero, no letras stupid");
            Console.ReadKey();
            resultado = inputInt(mensaje);
        }
        return resultado;

    }

    public static void print(string texto){
        Console.WriteLine(texto);
    }
}