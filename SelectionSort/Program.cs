//Küçük olanı başa alarak devam edeceğiz 
//En küçüğü bulacağız en küçüğü listenin başına alacağız 
//Bu nedenle karşılaştırma yapıldığında döngüye göre listenin başındaki elemanı pas geçeceğiz
//Time Complexity -> O(n^2)
//Space Complexity -> O(1) biz bu algoritmayı çalıştırırken bellekte heap'de yeni bir nesne oluşturmadık zaten oluşturulmuş array içerisinde değişiklik yaptık integer gibi primitif tipler sayılmaz
void SelectionSort<T>(T[] array) where T:IComparable
{
	for (int i = 0; i < array.Length; i++)
	{
		int minIndex = i; //sıradaki değeri minumum kabul edip karşılaştırma yapacağız
		for (int j = i+1; j < array.Length; j++) //Sıralı olanlar başta olacağı için çıkardık
		{
			if (array[j].CompareTo(array[minIndex])<0)
			{
				minIndex = j;
			}
		}
		//SWAP
		var temp = array[minIndex];
		array[minIndex] = array[i];
		array[i] = temp;
	}
}

int[] numbers = { 5, 2, 7, 9, 1 };
string[] names = { "Ali", "Veli", "Ayşe", "Fatma" };
SelectionSort(numbers);
System.Console.WriteLine(string.Join(',', numbers));