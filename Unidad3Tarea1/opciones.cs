using Newtonsoft.Json.Linq;




public class opciones{
    public static void opt_acerca_de(){
        Console.Clear();
        Console.WriteLine(@"
        
        
            ██╗░░░░░███████╗██╗░░░██╗██████╗░██╗░░░██╗██████╗░███╗░░██╗  ░██████╗░█████╗░███████╗████████╗
            ██║░░░░░██╔════╝██║░░░██║██╔══██╗╚██╗░██╔╝██╔══██╗████╗░██║  ██╔════╝██╔══██╗██╔════╝╚══██╔══╝
            ██║░░░░░█████╗░░██║░░░██║██║░░██║░╚████╔╝░██████╔╝██╔██╗██║  ╚█████╗░██║░░██║█████╗░░░░░██║░░░
            ██║░░░░░██╔══╝░░██║░░░██║██║░░██║░░╚██╔╝░░██╔══██╗██║╚████║  ░╚═══██╗██║░░██║██╔══╝░░░░░██║░░░
            ███████╗███████╗╚██████╔╝██████╔╝░░░██║░░░██║░░██║██║░╚███║  ██████╔╝╚█████╔╝██║░░░░░░░░██║░░░
            ╚══════╝╚══════╝░╚═════╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░╚═╝░░░░░░░░╚═╝░░░
        
        
        Creado por: Leudy Randy Nolasco.
        Estudiante de Licenciatura Para informatica UASD.

        Telefono: 829-334-3632.
        Correo: randylnolasco7@gmail.com
        
        ");
        Console.ReadKey();
    }

       public static int CalcularEdad(DateTime FechaNacimiento)
        {
            
            DateTime fechaActual = DateTime.Today;
            
           
            if (FechaNacimiento > fechaActual)
            {
                Console.WriteLine ("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else 
            {
                int edad = fechaActual.Year - FechaNacimiento.Year;
                
         
                if (FechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
                
                return edad;
            }
        }
         

      public static void zodiacal(){
          Console.Clear();
       
        
            int dia, mes;

            Console.Write("Ingresa el valor de dia: ");

            dia = int.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el valor de mes: ");

            mes = int.Parse(Console.ReadLine());

            if((dia>=21&&mes==3)||(dia<=20&&mes==4))
                Console.WriteLine("Aries");
            if((dia>=24&&mes==9)||(dia<=23&&mes==10))
                Console.WriteLine("Libra");
            if((dia>=21&&mes==4)||(dia<=21&&mes==5))
                Console.WriteLine("Tauro");
            if((dia>=24&&mes==10)||(dia<=22&&mes==11))
                Console.WriteLine("Escorpio");
            if((dia>=22&&mes==5)||(dia<=21&&mes==6))
                Console.WriteLine("Geminis");
            if((dia>=23&&mes==11)||(dia<=21&&mes==12))
                Console.WriteLine("Sagitario");
            if((dia>=21&&mes==6)||(dia<=23&&mes==7))
                Console.WriteLine("Cancer");
            if((dia>=22&&mes==12)||(dia<=20&&mes==1))
                Console.WriteLine("Capricornio");
            if((dia>=24&&mes==7)||(dia<=23&&mes==8))
                Console.WriteLine("Leo");
            if((dia>=21&&mes==1)||(dia<=19&&mes==2))
                Console.WriteLine("Acuario");
            if((dia>=24&&mes==8)||(dia<=23&&mes==9))
                Console.WriteLine("Virgo");
            if((dia>=20&&mes==2)||(dia<=20&&mes==3))
                Console.WriteLine("Piscis");
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }

    public static async void buscar_cedula(){

        Console.Clear();
        Console.WriteLine("Buscador de cedula");
        Console.WriteLine("Ingrese su cedula");
        int _dia = 0;
        int _mes = 0;
        int _anio =0;
        string cedula = Console.ReadLine();
        System.Net.WebClient client = new System.Net.WebClient();
        string url = "https://api.adamix.net/apec/cedula/" + cedula;
        string json = client.DownloadString(url);
        dynamic obj = JObject.Parse(json);
        
        var dataUsuaio = Convert.ToString(obj.FechaNacimiento);
        DateTime getDate = DateTime.Parse(dataUsuaio, System.Globalization.CultureInfo.InvariantCulture);

        Console.Clear();

       
        _mes = getDate.Month;
        _anio = getDate.Year;

        Console.Clear();

        if(obj.ok == "true" ){

            Console.WriteLine("\nNombre: " + obj.Nombres);
            Console.WriteLine("\nApellido: " + obj.Apellido1 +" " + obj.Apellido2 );
            Console.WriteLine("\nFecha de nacimiento: " + obj.FechaNacimiento);
            Console.WriteLine("\nEdad: " + CalcularEdad(getDate));
            Console.WriteLine("\nSigno zodiacal: " + zodiacal);
        }else{

            Console.WriteLine("\nLa cedula ingresada no es valida....");
        }
        
        Console.WriteLine("Presione Enter para volver al menu... ");
        Console.ReadKey();
    }
       
       public static async void angulos_triangulos(){
           Console.Clear();
           Console.WriteLine("Determinador de triangulos segun sus angulos ");
           double ladoA = Utils.inputInt("Introduce el primer angulo: ");
           double ladoB = Utils.inputInt("Introduce el segundo angulo: ");
           double ladoC = Utils.inputInt("Introduce el tercer angulo: ");
           double A = Math.Acos(ladoA);
           double B = Math.Acos(ladoB);
           double C = Math.Acos(ladoC);
           

           A = ((ladoB*ladoB+ladoC*ladoC-ladoA*ladoA)/(2*ladoB*ladoC))*180;
           B = ((ladoA*ladoA+ladoC*ladoC-ladoB*ladoB)/(2*ladoA*ladoC))*180;
           C = ((ladoA*ladoA+ladoB*ladoB-ladoC*ladoC)/(2*ladoA*ladoB))*180;

           if(A == 90 || B == 90 || C == 90)
           Console.WriteLine("Es un rectangulo ");
           else{
           if(A < 90 && B < 90 && C < 90)
           Console.WriteLine("Es un obtusangulo ");
           else{
           if(A > 90 || B > 90 || C > 90)
           Console.WriteLine("Es un acutangulo ");
           }
        }
           Console.ReadKey();
    }


    public static void lados_triangulos(){
        Console.Clear();

        double n1 = Utils.inputInt("Introduce el primer lado: ");
        double n2 = Utils.inputInt("Introduce el segundo lado: ");
        double n3 = Utils.inputInt("Introduce el tercer lado: ");

        if (n1 == n2 && n1 == n3)
        Console.WriteLine("Es equilateo ");
        else {
            if (n1 == n2 || n1 == n3 || n3 == n2)
            Console.WriteLine("Es isosceles ");
            else {
                if (n1 != n2 || n2 != n3 || n3 != n1)
                Console.WriteLine("Es escaleno ");
            }
        }

        Console.ReadKey();
    }

    public static void tiempo(){

        Console.Clear();
        Console.WriteLine("METEOLOGO DEL TIEMPO ");
        Console.WriteLine("Ingrese la ciudad ");
        string ciudad = Console.ReadLine();
        System.Net.WebClient client = new System.Net.WebClient();
        
        string url = "http://api.weatherstack.com/current?access_key=bca710bba539802b8c2cab746536c4b1&query= " + ciudad;
        string json = client.DownloadString(url);
        Console.WriteLine(json);
        Console.WriteLine("Presione Enter para volver al menu... ");
        Console.ReadKey();
    }


    public static void tabla_periodica(){

       Console.Clear();
       Console.WriteLine("TABLA PERIODICA ");
       Console.WriteLine("Ingrese el numero atomico del elemento a comprobar ");
        string atomico = Console.ReadLine();
        System.Net.WebClient client = new System.Net.WebClient();
        
        string url = " https://ag-ti-na-api.herokuapp.com/chemical_elements/ " + atomico;
        string json = client.DownloadString(url);
        Console.WriteLine(json);
        Console.WriteLine("Presione Enter para volver al menu... ");
        Console.ReadKey();
    }




}




































