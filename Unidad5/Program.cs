﻿
int adc = 0;

List<personajes> personajes = Utils.cargarPersonajes();


bool continuar = true;

while (continuar) {
    Console.Clear();
    Console.WriteLine(@"
    
    Aqui puedes agregar todos los personajes que quieras.

    1. Agregar Personajes.

    2. Listar Personajes.

    3. Modificar Personajes.

    4. Eliminar Personajes

    5. Exportar Personajes.

    x. Salir


    Digite el numero de la opcion que quiera hacer
    
    ");

    string opcion = Console.ReadLine();
    switch(opcion.ToLower()){

        case "1":
        Console.Clear();
        Console.WriteLine("Agregar Personajes");

        Console.Clear();
        Console.WriteLine("Agregar Personajes");
        var p = new personajes();
        Console.Write("Nombre: ");
        p.Nombre = Console.ReadLine();
         Console.Write("Apellido: ");
        p.Apellido = Console.ReadLine();
         Console.Write("Serie: ");
        p.Serie = Console.ReadLine();
         Console.Write("Telefono: ");
        p.Telefono = Console.ReadLine();
         Console.Write("Correo: ");
        p.Correo = Console.ReadLine();
        personajes.Add(p);
        Utils.guardarPersonajes(personajes);
        
        break;

        case "2":
        Console.Clear();
        Console.WriteLine("Listar Personajes");

        foreach(var per in personajes){
            Console.WriteLine("--Nombre: {0}",per.Nombre);
            Console.WriteLine("--Apellido: {0}",per.Apellido);
            Console.WriteLine("--Serie: {0}",per.Serie);
            Console.WriteLine("--Telefono: {0}",per.Telefono);
            Console.WriteLine("--Correo: {0}",per.Correo);
            
            Console.WriteLine("--------------------------------");
        }
        Console.WriteLine("Presione enter para continuar......");
        Console.ReadKey();

        break;

        case "3":
        Console.Clear();
        Console.WriteLine("Modificar Personajes");

        Console.WriteLine("Ingrese el ID del personaje a modificar");

        var id = Console.ReadLine();
        var per_exp = personajes[int.Parse(id)-1];

        per_exp.Nombre = Utils.input($"El Nombre actual es: {per_exp.Nombre} Digite el nuevo nombre: ");
        per_exp.Apellido = Utils.input($"El Apellido actual es: {per_exp.Apellido} Digite el nuevo Apellido: ");
        per_exp.Serie = Utils.input($"El nombre de la Serie actual es: {per_exp.Serie} Digite el nuevo de la serie: ");
        per_exp.Telefono = Utils.input($"El Telefono actual es: {per_exp.Telefono} Digite el nuevo numero de telefono: ");
        per_exp.Correo = Utils.input($"El Correo actual es: {per_exp.Correo} Digite el nuevo Correo: ");

        personajes[int.Parse(id)-1] = per_exp;
        Utils.guardarPersonajes(personajes);

        break;

        case "4":
        Console.Clear();
        Console.WriteLine("Eliminar Personajes");

        Utils.mostrarListaPersonajes(personajes);

        adc = Utils.input_int("Ingrese el ID del personaje que desea borrar: ");

        if(adc-1 >=personajes.Count){
            Console.WriteLine("El ID ingresado no existe....");
            Console.ReadKey();
            break;
        }

        personajes.RemoveAt(adc-1);
        Utils.guardarPersonajes(personajes);

        break;

        case "5":
        Console.Clear();
        Console.WriteLine("Exportar Personajes");

        Console.WriteLine("Para exportar es necesario poner el ID");

        var c = 1;

        foreach(var exp in personajes){
            Console.WriteLine("--ID: " + c);
            Console.WriteLine("Nombre: {0}", exp.Nombre);
            Console.WriteLine("Apellido: {0}", exp.Apellido);
            Console.WriteLine("Serie: {0}", exp.Serie);
            Console.WriteLine("Telefono: {0}", exp.Telefono);
            Console.WriteLine("Correo: {0}", exp.Correo);        
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
            c++;                            
        }
        Console.WriteLine("Digite el ID del personaje a exportar: ");
        var ID = Console.ReadLine();
        var per_expo = personajes[int.Parse(ID)-1];
        Utils.exportarHTML(per_expo);

        break;

        case "x":
        Utils.guardarPersonajes(personajes);
        Console.WriteLine("Saliendo.....");
        continuar = false; 
        break;
        default:
        Console.WriteLine("Opcion no valida");
        break;
        
        break;
    }
}