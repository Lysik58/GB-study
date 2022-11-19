Console.Write("Введите число: ");
int cube = int.Parse(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = int.Parse(Math.Pow(counter, 3));
    counter++;
  }
}


void NumOut(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
NumOut(arry);