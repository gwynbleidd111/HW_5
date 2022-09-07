// ЗАДАЧА 34_____________________________________________________________

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
        array[i] = random.Next(100, 1000);
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

int GetEvenNumber(int c){
    int amount=0;
    for(int i =0; i<array.Length; i++){
        if(array[i]%2 != 1){
            amount++;
        }
    }
    return amount;
}

GetRandom(length);
PrintArray(length);
Console.WriteLine("");
int res = GetEvenNumber(length);
Console.WriteLine($"Количество четных чисел в массиве равно {res}.");
