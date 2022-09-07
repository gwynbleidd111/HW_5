// ЗАДАЧА 38_____________________________________________________________

Console.Write("Введите длину массива: ");
bool isLength = int.TryParse(Console.ReadLine(), out int length);
double [] array = new double[length];
double max = -99;
double min = 100;

if (!isLength){
    Console.WriteLine("Введите число.");
    return;
}

void GetRandom(int a){
    for (int i = 0; i < array.Length; i++){
        array[i] = Convert.ToDouble(new Random().Next(-99, 100));
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

double GetMax(int c){
    for(int i =0; i<array.Length; i++){
        if(array[i] !> max){
            max = array[i];
        }
    }
    return max;
}

double GetMin(int c){
    for(int i =0; i<array.Length; i++){
        if(array[i] !< min){
            min = array[i];
        }
    }
    return min;
}

GetRandom(length);
PrintArray(length);
Console.WriteLine("");
double maximum = GetMax(length);
double minimum = GetMin(length);
double res = maximum - minimum;
Console.WriteLine($"Максимум равен {maximum}.");
Console.WriteLine($"Минимум равен {minimum}.");
Console.WriteLine($"Разница равна {res}.");
