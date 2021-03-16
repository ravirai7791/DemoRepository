using System;
using System.Collections.Generic;

namespace NumberGeneratorProcessor
{
    public class Processor
    {
        public List<int> GenerateNumber(int terminate)
        {
            List<int> generatedNo = new List<int>() { 1, 1, 1 };

            for (int i = 2; i < terminate; i++)
            {
                generatedNo.Add(generatedNo[i] + generatedNo[i - 1] + generatedNo[i - 2]);
            }

            return generatedNo;
        }

        public string GetValues(int devisior, int number)
        {
            List<int> values = new List<int>();
            try
            {
                List<int> generatedNo = new List<int>() { 1, 1, 1 };

                for (int i = 2; i < 11; i++)
                {
                    generatedNo.Add(generatedNo[i] + generatedNo[i - 1] + generatedNo[i - 2]);
                }


                for (int i = 0; i < generatedNo.Count; i++)
                {
                    if (devisior <= generatedNo[i])
                    {
                        if ((generatedNo[i] % devisior) == 0 )
                        {
                            values.Add(generatedNo[i]);
                        }
                        if (values.Count == number)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                //throw;
            }

            return values[number-1].ToString();
        }
    }
}
