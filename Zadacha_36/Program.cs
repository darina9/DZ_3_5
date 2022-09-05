 int[]array = GetArray(4);
Console.WriteLine(string.Join("," , array));
int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0;i<size;i++)
    {
        result [i] = new Random().Next(-100,100);
    }
    return result;
}
int size= array.Length;
int sum=0;
for(int i = 0;i<size;i++)
{  
    
    if(i%2==0)
    {
        sum+=array[i];
    } 
}
Console.WriteLine("Сумма  элементов, стоящих на нечётных позициях :"+ sum);
