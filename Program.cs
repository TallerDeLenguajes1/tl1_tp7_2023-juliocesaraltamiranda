// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

var calculadora = new Calculadora();

string menuString = "1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Limpiar";
int continuar = 1;
string menuContinuar = "Desea realizar otra operacion: SI=1\tNO=0";
int menuOpcion;
double termino;


while(continuar == 1) {

    Console.WriteLine(menuString);
    Console.WriteLine("Ingrese una opcion");

    menuOpcion = int.TryParse(Console.ReadLine(), out menuOpcion) ? menuOpcion : 0;

    switch(menuOpcion) {

        case 1:

            Console.WriteLine("Ingrese un valor");
            termino = double.TryParse(Console.ReadLine(), out termino) ? termino : 0;
            calculadora.Sumar(termino);

        break;
        case 2:

            Console.WriteLine("Ingrese un valor");
            termino = double.TryParse(Console.ReadLine(), out termino) ? termino : 0;
            calculadora.Restar(termino);

        break;
        case 3:

            Console.WriteLine("Ingrese un valor");
            termino = double.TryParse(Console.ReadLine(), out termino) ? termino : 0;
            calculadora.Multiplicar(termino);

        break;
        case 4:

            Console.WriteLine("Ingrese un valor");
            termino = double.TryParse(Console.ReadLine(), out termino) ? termino : 0;
            calculadora.Dividir(termino);

        break;
        case 5:

            calculadora.Limpiar();

        break;
        
       
    }

    Console.WriteLine($"El resultado es: {calculadora.Resultado}");
    Console.WriteLine(menuContinuar);
    continuar = int.TryParse(Console.ReadLine(), out continuar) ? continuar : 0;    
} 