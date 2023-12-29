using System;

namespace cstask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            Kvadrati(ref num);
            Console.WriteLine(num);

            int[] numArr = { 2, -3, -6, 10, 4 };

            ArrKvad(ref numArr);
            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine($"<{numArr[i]}>");
            }

            string text = "Hello everyone !";
            WithoutSpaces(ref text);
            Console.WriteLine(text);

            int[] Array = { 1, 2, 3 };
            AddElement(ref Array, 4);
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($">{Array[i]}<");
            }
        }
        
        //1.Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)
        static void Kvadrati(ref int num)
        {
            num *= num;
        }

        //2.Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod
        static void ArrKvad(ref int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] *= arr[i];
            }
            int[] newArr = new int[arr.Length];
            
            for(int i=0;i<newArr.Length;i++)
            {
                newArr[i] = arr[i];
            }
        }

        //3.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov "
        //deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.
        static void WithoutSpaces(ref string text)
        {
            string newText = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newText+= text[i];
                }
            }
            text = newText;
        }

        //4.Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni
        //element kimi elave eden metod. Misal üçün int[] nums = {1,5,7} deyə bir variable-mız var.yazdığımız metodu çağırıb arqument
        //olaraq nums və 3 göndərsək nums arrayının dəyəri  {1,5,7,3} olmalıdır.
        static void AddElement(ref int[] arr, int element)
        {
            int[] newArray = new int[arr.Length + 1]; 

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }

            newArray[newArray.Length - 1] = element;
            arr = newArray;
        }
    }
}
