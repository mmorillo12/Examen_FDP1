using System;

namespace Holamundo
{
    class Program
    {
      static void Main(string[] args){
      int monto, lmin = 10000,lmx = 20000, mil = 18000, quinientos = 9500, doscientos = 4600, cincuenta = 5000;
      //Aplicacion de cajero automatico.
      Console.WriteLine("Bienvenido a su Cajero Automatico");
      
      Console.WriteLine("1- FDP INVESMENTS");
      Console.WriteLine("2- Banco Popular");
      Console.WriteLine("Porfavor ingrese el numero de Banco: ");
      int banco = int.Parse(Console.ReadLine());
      
      if(banco == 1){
      Console.WriteLine("Cuanto desea retirar, su limite deber ser de 10,000 a 20,000: ");
      monto = int.Parse(Console.ReadLine());
      
      if((monto < lmin) && (monto > lmx)){
        Console.WriteLine("Porfavor digite otro monto");
        Console.WriteLine("Cuanto desea retirar, su limite deber ser de 10,000 a 20,000: ");
        monto = int.Parse(Console.ReadLine());
      }
      if((monto >= lmin) && (monto <= lmx)){
        //Console.WriteLine("En breve resivira su dinero");
      if(monto < mil){
      int retiro = monto/1000;
      int retiro1 = (retiro) * 1000;
      monto = monto - retiro1;
      if(monto == 0){
        Console.WriteLine("retire su dinero: {0} papeletasa de mil", retiro);
      if(retiro1 < monto){
        int retiro2 = monto - retiro1;
      if((retiro2 == 500)&&(quinientos > 0)){
        int totalretiro = retiro1 + retiro2;
        monto = monto - totalretiro;
      if(monto == 0){
        Console.WriteLine("Retire su dinero: {0} papeletas de", totalretiro);
      if((monto == 200) && (doscientos > 0)){
        int retiro3 = 200;
        totalretiro = retiro1 + retiro2 + retiro3;
        Console.WriteLine("Retire su dinero: {0}", totalretiro);
      }
      }
      }
      }
      }
      }
      }
      }
    }
}}

