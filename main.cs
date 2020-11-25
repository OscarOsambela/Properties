using System;
using System.Collections.Generic;
using System.Linq;
//las propiedades sirven para simplificar codigo y poder utilizar campos de clase privados y poder modificarlos sin llamar al getter y setter
public class Program
{
  public static void Main()
  {
    
    Empleado Oscar = new Empleado("Oscar");
    //Oscar.setSalario(3000);
    //Console.WriteLine("El salario de Oscar es " + Oscar.getSalario());
    //3. llamamos a la propiedad
    Oscar.SALARIO = -1200;
    Console.WriteLine("El salario de Oscar es: " + Oscar.SALARIO);
  }

	
  class Empleado{
    //convencion de propiedades. cuando se utilice propiedades los campos de clase se escribe con un subguion o guion bajo
    private double _salario;
    private string _nombre;

    public Empleado(string _nombre){
      this._nombre = _nombre;
    }
    //se omite toda instruccion setter y setter y se crea la propiedad con las instrucciones set y get
    /*
    public void setSalario(double salario){
      if(salario < 0){
        Console.WriteLine("El salario no puede ser negativo. Seasignará 0 como salario");
        this.salario = 0;
      }else{
        this.salario = salario;
      }
    }
    public double getSalario(){
      return salario;
    }
    */
    /*1.creamos un metodo para este ejemplo
    private double evaluaSalario(double _salario){
      if(_salario < 0) return 0;
      else return _salario;
    }*/
    /*2. crear propiedad en mayusculas
    public double SALARIO{
      get{ return this.salario;}
      set{ this.salario = evaluaSalario(value);}
    }*/
    //4.simplifiquemos la sentencia del propiedad explicada en el punto 2
    public double SALARIO{
      get => this._salario;
      //set => this._salario = evaluaSalario(value);
			//remplazamos el metodo 1. por esta sentencia
			set{ if(value < 0) value = -value;
			_salario = value;
			}
		}
    //propiedad de solo lectura se utiliza el get y se omite el set
    //propiedad de solo escritura se utiliza el set y se omite el get
    //puede servir en casos se presente este escenario
  }
}
