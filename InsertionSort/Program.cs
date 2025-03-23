int[] numbers = { 5, 2, 7, 9, 1 };
string[] names = { "Ali", "Veli", "Ayşe", "Fatma" };
InsertionSort(numbers);
System.Console.WriteLine(string.Join(',', numbers));

//büyük bulduğumuzu varolanın arasına ekleme yapacağız
//en küçük olana kadar sırayla kaydırarak kendisini en başa ekliyor kendinden küçük elemanı bulana kadar kaydırıyor
void InsertionSort<T>(T[] array)  where T : IComparable
{
	for (int i = 1; i < array.Length; i++)//Solu sıralı kabul ettiğimizden 1'den başlar
	{
		T key = array[i];
		int j = i - 1; //Kendinden önceki elemanları kontrol eder
		while (j>=0 && key.CompareTo(array[j])<0) //Keyden büyükse sağa kaydır 
		{
			array[j + 1] = array[j]; //Sağa kaydır
			j--;
		}
		array[j + 1] = key; //ne zamanki keyden küçükse
	}
}

