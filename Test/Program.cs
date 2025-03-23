void BubbleSort(int [] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		for (int j = 0; j < arr.Length-i-1; j++)
		{
			if (arr[j] > arr[j+1])
			{
				swap(arr, j, j + 1);
			}
		}
	}
}

void SelectionSort(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		var minIndex = i;
		for (int j = i+1; j < arr.Length; j++)
		{
			if (arr[j] < arr[minIndex])
			{
				minIndex = j;
			}
		}
		swap(arr, i, minIndex);
	}
}

void swap (int[] arr, int firstIndex, int secondIndex)
{
	int temp = arr[firstIndex];
	arr[firstIndex] = arr[secondIndex];
	arr[secondIndex] = temp;
}

int[] numbers = { 1, 2, 5, 3, 0 };
BubbleSort(numbers);
Console.WriteLine(string.Join(",",numbers));