namespace Feb_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encryption of stringConsider the following text"COVID crisis has taught us several lessons and together we will overcome this great challenge.
            // Now there is a sense of introspection in people. India will emerge stronger from this.
            // ”Encrypt the above string based on the following rules:Convert the entire string into encrypted digits based on the alphabetical ordering.Ex:      
            // a becomes 1, b becomes 2, c becomes 3, d becomes 4, etc.             (lowercase)           A becomes 27, B becomes 28, C becomes 29, etc.                            (uppercase)           . (full stop) will have the value 99.            ‘space’ will have the value 0.Convert the text into a sequence of encrypted digits:Ex. COVID crisis will become  29        41        48        35        30        3          18        9          19        9          19Once the entire text is converted into digits, do the following:Each encrypted digit of a 2 lettered word will be given an increment of 200Each encrypted digit of a 3 lettered word will be given an increment of 300, 4 lettered word will get an increment of 400 and so on.           Ex. ‘has’ is a 3-lettered word. When encrypted will have a representation of 8 1 19           Since it is a 3-lettered word, it will be incremented by 300 and will become 308 301 319No increments for full stop and spaceDisplay the above text as encrypted digits before the increment. Display the sum of all the digits.          Display the above text as encrypted digits after the increment. Display the sum of all the digits.
            
            List<int> list = new List<int>();
            string str = "COVID crisis has taught us several lessons and together we will overcome this great challenge. " +
                "Now there is a sense of introspection in people. India will emerge stronger from this";
            string[] strArray = str.Split(" ");

            foreach (string a in strArray)
            {
                for (int i = 0; i < a.Length; i++)

                {
                    int b = a[i] + 0;
                    if (b >= 65 && b <= 90)
                    {
                        b -= 38;
                        if (a.Length == 4)
                        {
                            b += a.Length * 100;
                        }
                        else if (a.Length == 3)
                        {
                            b += a.Length * 100;
                        }
                    }
                    else if (b >= 97 && b <= 122)
                    {
                        b -= 96;
                        if (a.Length == 4)
                        {
                            b += a.Length * 100;
                        }
                        else if (a.Length == 3)
                        {
                            b += a.Length * 100;
                        }
                    }
                    else if (b == 46)
                    {
                        b = 99;
                    }
                    list.Add(b);
                }
            }
            foreach (int crisis in list)
            {
                Console.Write(crisis + " ");

            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            int sum = list.Sum();
            Console.Write(" above text as encrypted digits after the increment sum :" + sum);


        }
    }
}
