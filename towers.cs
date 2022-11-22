using System;
public class Tower
{
    static public int getMinDiff(int[] arr, int n, int k)
    {
        Array.Sort(arr);
        int ans = (arr[n - 1] + k) - (arr[0] + k);
        int tempmax = arr[n - 1] - k;
        int tempmin = arr[0] + k;
        int max, min;
        for (int i = 0; i < n - 1; i++)
        {
            if (tempmax > (arr[i] + k))
            {
                max = tempmax;
            }
            else
            {
                max = arr[i] + k;
            }

            if (tempmin < (arr[i + 1] - k))
            {
                min = tempmin;
            }
            else
            {
                min = arr[i + 1] - k;
            }
            if (ans > (max - min))
            {
                ans = max - min;
            }
        }
        return ans;
    }
    static public void Main()
    {
        int[] arr = { 1, 5, 8, 10 };
        int k = 2;
        int ans = getMinDiff(arr, arr.Length, k);
        Console.Write(ans);
    }
}