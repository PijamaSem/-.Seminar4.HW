//Task 25. Write program, which get two digit (A) and (B) and return result  digit (A) in degree (B)
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
