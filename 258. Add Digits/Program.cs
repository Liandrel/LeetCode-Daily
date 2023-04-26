public class Solution
{
    //Digital root formula
    public int AddDigits(int num)
    {
        if (num == 0)
        {
            return 0;
        }
        return 1 + (num - 1) % 9;
    }
}

//Iterative solution
/*
int AddDigits(int num)
{
    while (num >= 10)
    {
        int sum = 0;
        while(num >=10)
        {
            sum += num % 10;
            num /= 10;
        }
        sum += num;
        num = sum;
    }
    return num;
}
*/