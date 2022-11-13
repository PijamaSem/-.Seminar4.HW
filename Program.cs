//Task 25. Write program, which get two digit (A) and (B) and return result  digit (A) in degree natural (B)
/*
int NaturalNumber(int num) // проверка второй числа, натуральное или нет
    {
        if (num > 0) //ноль не натуральное число проверка "0" не нужна
        {
             return num;  
        }
        else
        {
            Console.WriteLine($"Dear, it's not natural numer pls try againe:");  
            int numNew  = Convert.ToInt32(Console.ReadLine());
            num = numNew;
            return NaturalNumber(num);   
        }
    }   

void DigitInDegree(int a, int b) //метод для возведения в степени циклом "for"
    {
        int digitInDegree = a;
        for(int i=1; i<b;i++)
        {
            digitInDegree*=a;
        }
        Console.WriteLine($"Your result is: {digitInDegree}"); 
    }
Console.WriteLine($"Dear, pls put number (A):");  // аргумент (А) не требует проверок по условию задачи
int numA  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"thanks, now put natural number (B):");   // аргумент (В) должен быть натуральным 1,2,3... нужна проверка
int numB  = Convert.ToInt32(Console.ReadLine());
DigitInDegree(numA, NaturalNumber(numB));  
*/
// Task 27. Write program, which get number and return sum of digit of this number (123=>1+2+3=6)
/*
int Decimal(int degree)
    {
    int result = 1;
     for(int i=1; i<=degree ; i++)
     {
        result*=10;
     }
     return  result;
    }
int CountOfDigits(int num)

    {
    int count1 = 0;
    while (num >0  )
        {
        count1++;
        num = num /10;
    }
    return count1;
    }
int SumOfDigits(int num, int digits)
    {
    int sum=0;
    for (int i=digits-1; i > -1; i--) // 123456 digit 6 1=123456/100000
    {
    sum+=num/Decimal(i);
    num = num%Decimal(i);
    //Console.WriteLine($"-{sum}-{num}-{i}-{digits}-{Decimal(i)}");
    }
    return sum;
    }
Console.WriteLine($"Dear, pls put number (A):");  // аргумент (А) 
int number  = Convert.ToInt32(Console.ReadLine());
int numberDigits = CountOfDigits(number);
int sumDigits = SumOfDigits(number, numberDigits);
//SumOfDigits (number, numberDigits);
Console.WriteLine($"your number have {numberDigits} digit(s). Sum of it is: {sumDigits}");
*/

//: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

int [] CreateRandomArray(int n,int minVal,int maxVal)
    {
    int [] arr = new int [n];
    for (int i=0; i<n; i++)
    {
        arr[i] = new Random().Next(minVal,maxVal);
    }   
    return arr;
}
//***************
void PrintArray(int [] array)
    {
     Console.Write("Your  array is:[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]");
    }
//***************
Console.WriteLine($"Put array size:"); 
int size  = Convert.ToInt32(Console.ReadLine());
int minVal = 1;
int maxVal = 99;
PrintArray(CreateRandomArray(size,minVal,maxVal+1));  // "+1" - так как правая граница определенна строго
