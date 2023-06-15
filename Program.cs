// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;

DateTime fechaNacimiento;
DateTime fechaIngreso;
double montoTotal;
int aniosCercaJubilacion = 65;
int empleado;


//+++++++++++++++++++++++ datos empleados 1 +++++++++++++++++++++++
fechaNacimiento = new DateTime(1998, 08, 18);
fechaIngreso = new DateTime(2021, 12, 21);
var emp1 = new Empleado("julio", "altamiranda", fechaNacimiento, 'S', 'M', fechaIngreso, 65000, Cargo.Especialista);
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//+++++++++++++++++++++++ datos empleados 2 +++++++++++++++++++++++
fechaNacimiento = new DateTime(1973, 07, 04);
fechaIngreso = new DateTime(2002, 05, 11);
var emp2 = new Empleado("enrique", "diaz", fechaNacimiento, 'S', 'M', fechaIngreso, 120000, Cargo.Auxiliar);
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//+++++++++++++++++++++++ datos empleados 3 +++++++++++++++++++++++
fechaNacimiento = new DateTime(1965, 01, 01);
fechaIngreso = new DateTime(1987, 07, 09);
var emp3 = new Empleado("lucia", "fernandez", fechaNacimiento, 'C', 'F', fechaIngreso, 200000, Cargo.Ingeniero);
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


montoTotal = emp1.Salario() + emp2.Salario() + emp3.Salario();
Console.WriteLine("montoTotal: " + montoTotal);//Apartado 2d

if(emp1.AniosParaJubilacion < aniosCercaJubilacion)
{
    aniosCercaJubilacion = emp1.AniosParaJubilacion;
    emp1.CercaJubilacion = true;
}

if (emp2.AniosParaJubilacion < aniosCercaJubilacion)
{
    aniosCercaJubilacion = emp2.AniosParaJubilacion;
    emp1.CercaJubilacion = false;
    emp2.CercaJubilacion = true;
}

if (emp3.AniosParaJubilacion < aniosCercaJubilacion)
{
    aniosCercaJubilacion = emp3.AniosParaJubilacion;
    emp2.CercaJubilacion = false;
    emp3.CercaJubilacion = true;
}

emp1.datos();
emp2.datos();
emp3.datos();
