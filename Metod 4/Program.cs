// Вид метода 4 (что-то возращают и что-то принимают)

string Method4(int count, string test)
{
   int i = 0;
   string result = String.Empty;

   while (i < count)
   {
     result = result + test;
     i++;
   }
   return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
