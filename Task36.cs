// ЗАДАЧА 36_____________________________________________________________

Console.Write("Введите длину массива: ");
bool isLength = int.TryParse(Console.ReadLine(), out int length);
int [] array = new int[length];

if (!isLength){
    Console.WriteLine("Введите число.");
    return;
}

void GetRandom(int a){
    Random random = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(-99, 100);
    }
}

void PrintArray(int b){
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
    
}


int GetSum(int c){
    int sum = 0;
    for(int i =0; i<array.Length; i++){
        if(i%2 != 0){
            sum = sum + array[i];
        }
    }
    return sum;
}

GetRandom(length);
PrintArray(length);
Console.WriteLine("");
int res = GetSum(length);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {res}.");
