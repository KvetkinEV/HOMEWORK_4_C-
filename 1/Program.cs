int Stepen(int chisloa, int chislob)
            {
                int result = 1;
                for (int i = 1; i <= chisloa; i++)
                {
                    result = chislob * result;
                }
                
                return result;
            }

            Console.Write("Введите число A: ");
            int chisloA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int chisloB = Convert.ToInt32(Console.ReadLine());

            int vivod = Stepen(chisloB, chisloA);
            Console.WriteLine("Ответ: " + vivod);

            Console.ReadLine();

