public class Operacion {

    //El tipo de dato que debe de ir es double pero de alguna razon
    //En el return cuando lo pongo doble return valor1 esta mal...
         int valor1;
         int valor2;
         int resultado;

        public int Valor1 
        {
            set 
            {
                valor1=value;
            }
            get
            {
                return valor1;
            }
        }

        public int Valor2 
        {
            set 
            {
                valor2=value;
            }
            get
            {
                return valor2;
            }
        }

        public int Resultado
        {
            protected set 
            {
               resultado=value;
            }
            get
            {
                return resultado;
            }
        }        
    }


    public class Suma: Operacion
    {
        public void Operar() 
        {
            Resultado=Valor1+Valor2;
        }
    }


    public class Resta: Operacion
    {
        public void Operar() 
        {
            Resultado=Valor1-Valor2;
        }
    }

        public class Multiplicacion: Operacion
    {
        public void Operar() 
        {
            Resultado=Valor1*Valor2;
        }
    }

        public class Division: Operacion
    {
        public void Operar() 
        {
            Resultado=Valor1/Valor2;
        }
    }

    class imprimir {

        static void Main(String[] args){

            Suma suma1 = new Suma();
            suma1.Valor1 = Utils.inputInt("Ingrese el primer numero para sumar: ");
            suma1.Valor2 = Utils.inputInt("Ingrese el segundo numero para sumar:  ");
            suma1.Operar();
            Console.WriteLine("La suma de " + suma1.Valor1 + " y " +
             suma1.Valor2 + " es " + suma1.Resultado);

            Resta resta1 = new Resta();
            resta1.Valor1 = Utils.inputInt("Ingrese el primer numero para restar: ");
            resta1.Valor2 = Utils.inputInt("Ingrese el segundo numero para restar: ");
            resta1.Operar();

            Console.WriteLine("La resta de " + resta1.Valor1 + " y " +
             resta1.Valor2 + " es " + resta1.Resultado);
            
            Multiplicacion multiplicacion1 = new Multiplicacion();
            multiplicacion1.Valor1 = Utils.inputInt("Ingrese el primer numero para multiplicar: ");
            multiplicacion1.Valor2 = Utils.inputInt("Ingrese el segundo numero para multiplicar: ");
            multiplicacion1.Operar();

             Console.WriteLine("La resta de " + multiplicacion1.Valor1 + " y " +
             multiplicacion1.Valor2 + " es " + multiplicacion1.Resultado);      

            Division division1 = new Division();
            division1.Valor1 = Utils.inputInt("Ingrese el primer numero para Dividir: ");
            division1.Valor2 = Utils.inputInt("Ingrese el segundo numero para Dividir: ");
            division1.Operar();

            Console.WriteLine("La resta de " + division1.Valor1 + " y " +
             division1.Valor2 + " es " + division1.Resultado);     
             
             Console.ReadKey();

        }
    }