bool continuar = true;

while (continuar == true)
{
    Console.Clear();
    Console.WriteLine(@"


                                            ('-. _ .-') _ _ .-') .-') _  
                                    _( OO) ( ( OO) ) ( \( -O ) ( OO ) )
                            ,--. (,------. ,--. ,--. \ .'_ ,--. ,--.,------. ,--./ ,--,'  
                            | |.-') | .---' | | | | ,`'--..._) \ `.' / | /`. '| \ | |\  
                            | | OO ) | | | | | .-') | | \ ' .-') / | / | || \| | )
                            | |`-' |(| '--. | |_|( OO )| | ' |(OO \ / | |_.' || . |/  
                            (| '---.' | .--' | | | `-' /| | / : | / /\_ | . '.'| |\ |   
                            | | | `---.(' '-'(_.-' | '--' / `-./ /.__) | |\ \ | | \ |   
                            `------' `------' `-----' `-------' `--' `--' '--'`--' `- -'  
    
    Selecciona una de las opciones que desea realizar: 
       1- Programa que acepte una cédula dominicana e indicar si la misma es valida según el algoritmo verificador.
       2- Programa que acepte una fecha de nacimiento, determinar el signo zodiacal de la misma.
       3- Programa que acepte una cédula dominicana mostrar el nombre, apellido, ciudad, fecha nacimiento, edad y signo zodiacal del dueño de la cédula.
       4- Programa que muestre como estará el clima en Santo Domingo en un futuro cercano.
       5- Programa que acepte el símbolo de un elemento de la tabla periódica. Mostrarnos el nombre, descripción y 2 informaciones mas (ej, peso atómico, protones, etc).
       6- Programa que acepte las medidas de los angulos de un triangulo, mostrar a que tipo pertenece segun las mismas.
       7- Programa que acepte las medidas de los lados de un triangulo, mostrar que tipo pertenece segun las misma.
       8- Acerca de
       x- Salir...    
    
    ");

    Console.WriteLine("Selecciona una Opcion: ");
    string opcion = Console.ReadLine();

    if (opcion == "1"){
       verificar.fragil();
    }else if (opcion == "2"){
       opciones.zodiacal();
    }else if (opcion == "3"){
       opciones.buscar_cedula();
    }else if (opcion == "4"){
       opciones.tiempo();
    }else if (opcion == "5"){
       opciones.tabla_periodica();
    }else if (opcion == "6"){
       opciones.angulos_triangulos();
    }else if (opcion == "7"){
       opciones.lados_triangulos();
    }else if (opcion == "8"){
        opciones.opt_acerca_de();
    }else if (opcion.ToLower() == "x"){
        Console.WriteLine("Bye, tome mucho cafe para la estres maning ");
        continuar = false;
    }
    else{
        Console.WriteLine("Seleccion no valida, Presione Enter para continuar");
        Console.ReadLine();
    }
}