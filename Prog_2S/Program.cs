Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == numberA * numberA){
    Console.WriteLine("B = A * A");
} else{
    Console.WriteLine("B != A * A");
}
   
