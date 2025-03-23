
void BubbleSort<T>(T[] array)
{
	for (int i = 0; i < array.Length; i++) // Dizinin her bir elemanı için yapıldığından
	{
		for (int j = 0; j < array.Length - i - 1; j++) //sonu hep sıralı gittiği için, gidilmiş sondaki elemanları çıkarıyoruz 
		{
			if (Comparer<T>.Default.Compare(array[j], array[j + 1]) > 0)//jninci eleman sağındaki elemandan büyükse sağa taşıyacak en büyük elemanı her zaman en sona götürüyor
			{
				var temp = array[j];
				array[j] = array[j + 1];
				array[j + 1] = temp;
			}
		}
	}
}


int[] numbers = { 5, 2, 7, 9, 1 };
string[] names = { "Ali", "Veli", "Ayşe", "Fatma" };
BubbleSort(numbers);
System.Console.WriteLine(string.Join(',', numbers));