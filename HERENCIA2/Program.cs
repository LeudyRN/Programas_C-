public class Operacion {

    
         double notaTEO1;
         double notaTEO2;
         double notaTEO3;
         double notaLAB1;
         double notaLAB2;
         double notaLAB3;
         double porcentaje;
         double porcentajeIN;
         double resultadoTEO;
         double resultadoLAB;
         double calificacionFinal;

    public double NotaTEO1
        {
            set 
            {
                notaTEO1=value;
            }
            get
            {
                return notaTEO1;
            }
        }

        public double NotaTEO2
        {
            set 
            {
                notaTEO2=value;
            }
            get
            {
                return notaTEO2;
            }
        }

        public double NotaTEO3
        {
            set 
            {
                notaTEO3=value;
            }
            get
            {
                return notaTEO3;
            }
        }

        public double NotaLAB1
        {
            set 
            {
                notaLAB1=value;
            }
            get
            {
                return notaLAB1;
            }
        }
        
        public double NotaLAB2
        {
            set 
            {
                notaLAB2=value;
            }
            get
            {
                return notaLAB2;
            }
        }


        public double NotaLAB3
        {
            set 
            {
                notaLAB3=value;
            }
            get
            {
                return notaLAB3;
            }
        }

        public double CalificacionFinal
        {
            set 
            {
                calificacionFinal=value;
            }
            get
            {
                return calificacionFinal;
            }
        }

        public double ResultadoTEO
        {
            set 
            {
                resultadoTEO=value;
            }
            get
            {
                return resultadoTEO;
            }
        }

        public double ResultadoLAB
        {
            set 
            {
                resultadoLAB=value;
            }
            get
            {
                return resultadoLAB;
            }
        }

        public double Porcentaje
        {
            set 
            {
                porcentaje=value;
            }
            get
            {
                return porcentaje;
            }
        }

        public double PorcentajeIN
        {
            set 
            {
                porcentajeIN=value;
            }
            get
            {
                return porcentajeIN;
            }
        }
      

    public class PromedioTEO: Operacion{
            public void Operar() 
                {
                    ResultadoTEO=(notaTEO1 + notaTEO2 + notaTEO3)/3;
                    porcentaje = (ResultadoTEO / 100) *70;
                }
        }

    public class PromedioLAB: Operacion{
            public void Operar() 
                {
                    ResultadoLAB=(notaLAB1 + notaLAB2 + notaLAB3)/3;
                    porcentajeIN = (ResultadoLAB / 100) *30;
                }
        }
    class imprimir {

        static void Main(String[] args){

            PromedioTEO promedioTEO1 = new PromedioTEO();
            promedioTEO1.notaTEO1 = Utils.inputInt("Ingrese la primera nota: ");
            promedioTEO1.notaTEO2 = Utils.inputInt("Ingrese la segunda nota: ");
            promedioTEO1.notaTEO3 = Utils.inputInt("Ingrese la tercera nota: ");
            promedioTEO1.Operar();
            Console.WriteLine("Calificacion promedio para INF-512: " + promedioTEO1.notaTEO1 + " , " +
            promedioTEO1.notaTEO2 + " y " + promedioTEO1.notaTEO3 + " es " + promedioTEO1.porcentaje);

            PromedioLAB promedioLAB1 = new PromedioLAB();
            promedioLAB1.notaLAB1 = Utils.inputInt("Ingrese la primera nota: ");
            promedioLAB1.notaLAB2 = Utils.inputInt("Ingrese la segunda nota: ");
            promedioLAB1.notaLAB3 = Utils.inputInt("Ingrese la tercera nota: ");
            promedioLAB1.Operar();
            Console.WriteLine("Calificacion promedio para INF-513: " +  promedioLAB1.notaLAB1 + " , " +
            promedioLAB1.notaLAB2 + " y " + promedioLAB1.notaLAB3 + " es " + promedioLAB1.porcentajeIN);
            Console.WriteLine("La calificacion final es: " + (promedioTEO1.porcentaje + promedioLAB1.porcentajeIN));

            
            

           Console.ReadKey();
        }
    
    }
}    