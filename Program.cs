internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. Ingrese 1 para el primer ejercicio");
        Console.WriteLine("2. Ingrese 2 para el segundo ejercicio");
        Console.WriteLine("3. Ingrese 3 para el tercer ejercicio");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                const int first = 0;
                const int second = 1;
                Console.WriteLine("Ingrese el numero N: ");
                int number = int.Parse(Console.ReadLine());
                List<int> numberList = [first, second];
                for(int i = 2; i < (number + 2); i++){
                    int result = numberList[i-1] + numberList[i-2];
                    numberList.Add(result);
                }
                Console.WriteLine($"F{number}: {numberList[number]}");
                break;
            case 2:
                Console.WriteLine("Ingrese si es un numero Fibonacci");
                int number2 = int.Parse(Console.ReadLine());
                List<int> numberList2 = [0, 1];
                for(int i = 2; i < (number2 + 2); i++){
                    int result = numberList2[i-1] + numberList2[i-2];
                    numberList2.Add(result);
                }
                foreach(int i in numberList2)
                {
                    if(i == number2){
                        Console.WriteLine($"{number2} es un numero de Fibonacci");
                        break;
                    }else
                    {
                        Console.WriteLine($"{number2} no es un numero de Fibonacci");
                    }
                }
            break;
            case 3:
                Console.WriteLine("Ingrese el numero de numeros a visualizar");
                int number3 = int.Parse(Console.ReadLine());
                List<int> numberList3 = [0, 1];
                for(int i = 2; i < (number3 + 2); i++){
                    int result = numberList3[i-1] + numberList3[i-2];
                    numberList3.Add(result);
                }
                foreach(int i in numberList3)
                {
                    Console.WriteLine(i);
                }
            break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        
    }
}