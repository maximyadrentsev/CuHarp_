Console.Clear();



void DecToBinary(int numb)
{
    string result = "";
    int binary = 0;
    for (int i = numb; i > 0; i/=2)
    {
        binary = i % 2;
        result = binary + result;
    }
    System.Console.Write(result);
}

DecToBinary(10);