// Вид метода 4 (что-то возращают и что-то принимают)

string Method4(int count, string test)
{
   string result = String.Empty;
   for(int i = 0; i < count; i++)
   {
     result = result + test;
   }
   return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);