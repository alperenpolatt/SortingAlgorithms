
        
		
		string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.pairs(k, arr);

        Console.WriteLine(result);


class Result
{

    /*
     * Complete the 'pairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int pairs(int k, List<int> arr)
    {
        var total =0;
        for (int i = 0; i < arr.Count-1; i++)
        {
            for (int j = i+1; j < arr.Count; j++)
            {
                var dif = Math.Abs(arr[i]-arr[j]);
                if(dif==k)
                    total++;
            } 
        }
        return total;
    }

}
