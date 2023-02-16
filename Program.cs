// find the sum of first n natural numbers using recursion
namespace Program;

class SumOfNaturalTask{

static int sum = 0;
public static int SumOfNatural(int num){


if (num<1)
{
    return sum;
}

sum += num;
num--;
return SumOfNatural(num);

}

public static void Main (string[] args){
   Console.Write (SumOfNatural(4));
}

}