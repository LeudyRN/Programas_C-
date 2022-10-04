public class verificar
    {


    public static void fragil(){
        Console.Clear();
        Console.WriteLine("Verificador de Cedula Dominicana");

        

            int digito = 0;
           verificar ob=new verificar ();
 
            Console.Write("Introduce los 11 primeros dígitos de su cédula: ");
            Console.Write("*****Recuerde que no puede llevar guiones*****\n");
 
            digito = ob.ci(Console.ReadLine());
            Console.Write("el dígito verificador es: " + digito+ "\n");

            Console.ReadKey();
        }
 
        public int ci(string cedula)
        {
            int sumaPares = 0;
            int sumaImpares = 0;
            int tmp = 0;
 
            int digito = 0;
 
            
            for (int i = 2; i <=10; i += 2)
            {
                sumaPares = sumaPares + int.Parse(cedula.Substring(i-1, 1));
            }
 
            
            for (int i = 1; i <= 11; i += 2)
            {
                tmp = int.Parse (cedula.Substring (i-1,1))* 2;
                if (tmp > 11)
                tmp = tmp - 11;
                sumaImpares = sumaImpares + tmp;
            }
 
            
            digito = 11 - ((sumaPares + sumaImpares) % 11);
            if (digito == 11)
                digito = 0;
 
            return digito;
            
        }



         
}

   

