//Task 25

int Prompt1(string text)
{
    System.Console.Write(text);
    string readInput = System.Console.ReadLine();
    int numb = int.Parse(readInput);
    return numb;
}

int number1 = Prompt1("Please enter first number");
int number2 = Prompt1("Please enter second number");

int Calc(int a, int b){
    int res = 1;
    for(int i = 0; i< b; i++)
    {
        res *= a;
    }
    return res;
}

System.Console.WriteLine(Calc(number1, number2));


//Task 27

int Prompt(String text)
{
    System.Console.Write(text);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Sum(int number)
{
    int res = 0;
    while(number > 0)
    {
        res += number%10;
        number = number/10;
    }
    return res;
}


int number = Prompt("Please enter number");


System.Console.WriteLine(Sum(number));
