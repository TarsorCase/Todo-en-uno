// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nIngrese una estacion del año: ");
Console.WriteLine("1 ---> Verano\n2 ---> Otoño\n3 ---> Invierno\n4 ---> Primavera");
int estacion = Convert.ToInt32(Console.ReadLine());
switch (estacion)
{
  case 1:
  Console.WriteLine("Diciembre a Marzo");
  break;
  case 2:
  Console.WriteLine("Abril a Junio");
  break;
  case 3:
  Console.WriteLine("Julio a Septiembre");
  break;
  case 4:
  Console.WriteLine("Octubre a Noviembre");
  break;
  default:
  Console.WriteLine("Ingrese una estacion real porfavor");
  break;
}
string[] numeroromanos = new string[20];
numeroromanos = ["I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX"];
Console.WriteLine("\nIngrese un numero romano: ");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i<= 19; ++i){
  string c = numeroromanos[i];
  if(i == num - 1){    
    Console.WriteLine($"{c}");    
  }
}
