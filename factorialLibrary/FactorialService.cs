namespace factorialLibrary;

public class FactorialService
{

    public static int Factorial(int n){

        if (n<0){
            throw new InvalidOperationException("Negative numbers dont have a valid factorial");
        }
        if (n == 0|| n == 1) { // 0! = 1  1! = 1
         return 1;
        }
         return n * Factorial(n-1);
    }

}
