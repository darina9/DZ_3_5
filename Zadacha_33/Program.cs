int [] array = new int[4];
int size = array.Length;

int count= 0;


for(int i=0;i<size;i++)
{
   array[i]=new Random().Next(100,1000);
   if(array[i]%2==0)
   {
     count++;
   }
}
Console.WriteLine(String.Join(",", array));
Console.WriteLine("Количество четных чисел " + count );
