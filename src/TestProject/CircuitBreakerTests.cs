﻿namespace TestProject
{
    public class CircuitBreakerTests
    {
        public void Test()
        {
            int i = 1;
            int j = 2;
            int k = i + j;


            int l = 0;
            while (i < 10)
            {
                l--;
                l++;
                return;
            }


            while (i < 10 && j > 20)
            {
                l--;
                l++;
            }

            while (i < 10)
            {

            }

            while (i < 10 && j > 20)
            {
                i++;
            }

            int counter = 0;
            while (counter > 1)
            {
                counter++;
                if (counter > 100)
                {

                }
                else
                {
                    break;
                }
            }

            for(; ; )
            {
                int h = 1;
            }
        }
    }
}
