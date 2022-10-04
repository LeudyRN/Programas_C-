Console.WriteLine("Digite las calificaciones para INF-512");

int nota1 = Utils.inputInt("Ingrese la primera nota: ");
int nota2 = Utils.inputInt("Ingrese la segunda nota: ");
int nota3 = Utils.inputInt("Ingrese la tercera nota: ");


double promedio = (nota1 + nota2 + nota3)/3;
double porcentaje = (promedio / 100) *70;
Console.WriteLine("Calificacion para INF 512: " + porcentaje);

Console.WriteLine("Digite las calificaciones para INF-513");

int nota4 = Utils.inputInt("Ingrese la primera nota: ");
int nota5 = Utils.inputInt("Ingrese la segunda nota: ");
int nota6= Utils.inputInt("Ingrese la tercera nota: ");

double promedio2 = (nota4 + nota5 + nota6)/3;
double porcentajeIN = (promedio2 / 100) *30;


Console.WriteLine("Calificacion para INF 513: " + porcentajeIN);
double CalificacionFinal =  (porcentaje + porcentajeIN);
Console.WriteLine("Su calificacion final es: " + CalificacionFinal);
