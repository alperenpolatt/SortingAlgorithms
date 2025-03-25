//iki tane nesnenin bir araya gelmesi birleştirilmesi
//sorunu küçük parçalara ayırarak sonuca varmamızı sağlar

void MergeSort<T>(T [] array,int left,int right)where T:IComparable{
    //5, 2, 7, 9, 1
    if (left<right)
    {
        int middle = left + (right-left)/2;
        MergeSort(array,left,middle);
        MergeSort(array,middle+1,right);
        Merge(array,left,middle,right);
    }
}

void Merge<T>(T [] array,int left, int middle,int right) where T:IComparable{
    int n1=middle-left+1; //Oluşturulacak left arrayın eleman boyutu
    int n2=right-middle;//Oluşturulacak right arrayın eleman boyutu
    T[] leftArray=new T[n1]; // Yeni sol dizi
    T[] rightArray=new T[n2]; // Yeni sağdaki dizi
    Array.Copy(array,left,leftArray,0,n1);
    Array.Copy(array,middle+1,rightArray,0,n2);

    //1,3,5
    //4,6,9
    int leftIndex =0, rightIndex=0;//sol ve sağ dizilerin indexerları
    int k=left;// ana arrayın içerisindeki verinin konulacak olan indexi tutulacak

    while (leftIndex<n1 && rightIndex<n2)//indexerlar dizi boyutuna ulaştığında
    {
        if (leftArray[leftIndex].CompareTo(rightArray[rightIndex])<=0)
        {
            array[k]=leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            array[k]=rightArray[rightIndex];
            rightIndex++; 
        }
        k++;
    }
    while (leftIndex<n1)//eleman kalmışsa
    {
        array[k]=leftArray[leftIndex];
        leftIndex++;
        k++;
    }
    while (rightIndex<n2)//eleman kalmışsa
    {
        array[k]=rightArray[rightIndex];
        rightIndex++;
        k++;
    }
}

int[] numbers = { 5, 2, 7, 9, 1 };
MergeSort(numbers,0,numbers.Length-1);
System.Console.WriteLine(string.Join(',', numbers));
