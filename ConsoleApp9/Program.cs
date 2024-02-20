// Pedir un café oscuro con azúcar
Bebida cafe1 = new CafeOscuro();
cafe1 = new Azucar(cafe1);
Console.WriteLine(cafe1.GetDescripcion() + " - Costo: " + cafe1.Costo());

// Pedir un café claro con leche
Bebida cafe2 = new CafeClaro();
cafe2 = new Leche(cafe2);
Console.WriteLine(cafe2.GetDescripcion() + " - Costo:" + cafe2.Costo());

// Clase abstracta para las bebidas
public abstract class Bebida
{
    protected string descripcion = "Bebida desconocida";
    public virtual string GetDescripcion()
    {
       
        return this.descripcion;
    }

    public abstract double Costo();
}

// Implementación de la clase Bebida para café oscuro
public class CafeOscuro : Bebida
{
    public CafeOscuro()
    {
        descripcion = "Café Oscuro";
    }

    public override double Costo()
    {
        return 150.0;
    }
}

// Implementación de la clase Bebida para café claro
public class CafeClaro : Bebida
{
    public CafeClaro()
    {
        descripcion = "Café Claro";
    }

    public override double Costo()
    {
        return 200;
    }
}

// Clase abstracta para los aditivos (decoradores)
public abstract class Aditivo : Bebida
{
    public abstract override string GetDescripcion();
}

// Implementación de la clase de aditivos
public class Azucar : Aditivo
{
    private Bebida bebida;

    public Azucar(Bebida bebida)
    {
        this.bebida = bebida;
    }

    public override string GetDescripcion()
    {
        return bebida.GetDescripcion() + ", Azúcar";
    }

    public override double Costo()
    {
        return bebida.Costo() + 10;
    }
}

// Implementación de la clase de aditivos
public class Leche : Aditivo
{
    private Bebida bebida;

    public Leche(Bebida bebida)
    {
        this.bebida = bebida;
    }

    public override string GetDescripcion()
    {
        return bebida.GetDescripcion() + ", Leche";
    }

    public override double Costo()
    {
        return bebida.Costo() + 30;
    }
}


       
 