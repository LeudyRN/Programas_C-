using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft;
using Newtonsoft.Json;

class personajes{

    
    public personajes(){
        Console.WriteLine("Personaje Creado");
    }

    public string Nombre {get; set;}

    public string Apellido {get; set;}

    public string Serie {get; set;}

    public string Telefono {get; set;}

    public string Correo {get; set;}

}

class Utils{


    public static int input_int(string msg){
        int tmp = 0;
        Console.Write(msg);
        while(!int.TryParse(Console.ReadLine(), out tmp)){
            Console.WriteLine("Ingrese un numero valido: ");

        }
       return tmp; 
    }


    public static void guardarPersonajes(List<personajes> personajes){
    string json = Newtonsoft.Json.JsonConvert.SerializeObject(personajes);
    File.WriteAllText("personajes.json", json);
    }

    public static List<personajes> cargarPersonajes(){

        List<personajes> Melany = new List<personajes>();

        if(File.Exists("personajes.json")){
            string json = File.ReadAllText("personajes.json");

            try{
                Melany = JsonConvert.DeserializeObject<List<personajes>>(json);

            }catch(Exception e){
                Console.WriteLine("Error al cargar los personajes");
            }
        }

        return Melany;
    }

    public static string input(string msg){
        Console.WriteLine(msg);
        return Console.ReadLine();
    }

    public static void mostrarListaPersonajes(List<personajes> personajes) {
        var n = 1;
        
        Console.WriteLine("Lista de personajes");
        Console.WriteLine("ID\t\tNombre\t\tApelldio");

        foreach(var exp in personajes){
            Console.WriteLine("{0}\t\t{1}\t\t{2}", n, exp.Nombre, exp.Apellido);
            n++;
        }
    }
    public static void exportarHTML(personajes per){
        var plantilla = "";


        StreamReader sr = new StreamReader("plantilla.html");
        plantilla = sr.ReadToEnd();
        sr.Close();

       plantilla = plantilla.Replace("Nombre#", per.Nombre);
       plantilla = plantilla.Replace("Apellido#", per.Apellido);
       plantilla = plantilla.Replace("Serie#", per.Serie);
       plantilla = plantilla.Replace("Telefono#", per.Telefono);
       plantilla = plantilla.Replace("Correo#", per.Correo);

       System.IO.File.WriteAllText("personajes.html", plantilla);

       var url = "personajes.html";
       var psl = new System.Diagnostics.ProcessStartInfo();
       psl.UseShellExecute = true;
       psl.FileName = url;
       System.Diagnostics.Process.Start(psl);

       Console.WriteLine("Personaje Exportado");
    }
 }
 

 