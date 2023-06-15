using System.Reflection.Metadata.Ecma335;

namespace EspacioEmpleado;

class Empleado {

    private string ?nombre;
    private string ?apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;
    private Cargo cargos;
    private int edad;
    private int antiguedad;
    private int aniosParaJubilacion;
    private bool cercaJubilacion;

    public Empleado(string? nombre, string? apellido, DateTime fechaDeNacimiento, char estadoCivil, char genero, DateTime fechaDeIngreso, double sueldoBasico, Cargo cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaDeNacimiento = fechaDeNacimiento;
        EstadoCivil = estadoCivil;
        Genero = genero;
        FechaDeIngreso = fechaDeIngreso;
        SueldoBasico = sueldoBasico;
        Cargos = cargo;
        CercaJubilacion = false;
    }

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public bool CercaJubilacion { get => cercaJubilacion; set => cercaJubilacion = value; }

    public int calculaAnios(DateTime fecha1, DateTime fecha2)
    {
        int anios = fecha2.Year - fecha1.Year - 1;

        if(fecha2.Month > fecha1.Month)
        {
            anios += 1;
        }

        if (fecha2.Month == fecha1.Month && fecha2.Day >= fecha1.Day)
        {
            anios += 1;
        }

        return anios;
    }
    
    public int Edad
    {
        get
        {
            var fecha1 = fechaDeNacimiento;
            var fecha2 = DateTime.Now;

            return calculaAnios(fecha1, fecha2);
        }
        
    }

    public int Antiguedad
    {
        get
        {
            var fecha1 = fechaDeIngreso;
            var fecha2 = DateTime.Now;

            return calculaAnios(fecha1, fecha2);
        }
        
    }

    public int AniosParaJubilacion
    {
        
        get
        {
            int aniosJubilacion = 65;//Masculinos

            if(genero.ToString().Equals('F'))
            {
                aniosJubilacion = 60;
            }

            return aniosJubilacion - Edad;
        }
    }

    public Cargo Cargos
    {
        get
        {
            return cargos;
        }

        set { cargos = value; }
    }

    public double Salario()
    {
        double salario;
        double adicional = 0;
        
        double porcentajeSueldoBasico = Antiguedad;
        
        if(Antiguedad > 21)
        {
            porcentajeSueldoBasico = 25;
        }

        adicional += SueldoBasico * porcentajeSueldoBasico / 100;

        if(Cargos.Equals(Cargo.Ingeniero) || Cargos.Equals(Cargo.Especialista))
        {
            adicional += adicional * 50 / 100;
        }
        
        if (estadoCivil.ToString().Equals("C"))
        {
            adicional += 15000;
        }
        
        salario = sueldoBasico + adicional;

        return salario;
    }
    
    public void datos()
    {
        if(cercaJubilacion)
        {
            Console.WriteLine(
                $"Nombre: {nombre}\n" +
                $"Apellido: {apellido}\n" +
                $"Fecha de nacimiento: {fechaDeNacimiento.ToString("dd/MM/yyyy")}\n" +
                $"Estado civil: {estadoCivil}\n" +
                $"Genero: {genero}\n" +
                $"Edad: {Edad}\n" +
                $"Fecha de ingreso: {fechaDeIngreso.ToString("dd/MM/yyyy")}\n" +
                $"Antiguedad: {Antiguedad}\n" +
                $"Sueldo basico: {sueldoBasico}\n" +
                $"Cargo: {cargos}\n" +
                $"Salario: {Salario()}"
            );
        }
         
    }
    
}

enum Cargo {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}