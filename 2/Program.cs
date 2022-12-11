Console.Write("Введите число N =  ");
            int chisloN = Convert.ToInt32(Console.ReadLine());

            int SumCifr(int chislon)
            {

                int schetchik = Convert.ToString(chisloN).Length;
                int advance = 0;
                int result = 0;

                for (int i = 0; i < schetchik; i++)
                {
                    advance = chisloN - chisloN % 10;
                    result = result + (chisloN - advance);
                    chisloN = chisloN / 10;
                }
                return result;
            }

            int sumCifr = SumCifr(chisloN);
            Console.WriteLine("Сумма цифр в числе =  " + sumCifr);
            Console.ReadLine();

