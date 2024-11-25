using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.Differences
{
    class IntTryParseConvertToInt32Program
    {
        static void Main()
        {
            string validNumber = "123";
            string invalidNumber = "ABC";
            string nullValue = null;

            // Using int.TryParse
            if (int.TryParse(validNumber, out int result))
            {
                Console.WriteLine($"int.TryParse Success: {result}");
            }
            else
            {
                Console.WriteLine("int.TryParse Failed");
            }

            if (int.TryParse(invalidNumber, out result))
            {
                Console.WriteLine($"int.TryParse Success: {result}");
            }
            else
            {
                Console.WriteLine("int.TryParse Failed");
            }

            // Using Convert.ToInt32
            try
            {
                int convertedValue = Convert.ToInt32(validNumber);
                Console.WriteLine($"Convert.ToInt32 Success: {convertedValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Convert.ToInt32 Failed: {ex.Message}");
            }

            try
            {
                int convertedValue = Convert.ToInt32(invalidNumber);
                Console.WriteLine($"Convert.ToInt32 Success: {convertedValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Convert.ToInt32 Failed: {ex.Message}");
            }

            try
            {
                int convertedValue = Convert.ToInt32(nullValue);
                Console.WriteLine($"Convert.ToInt32 Success: {convertedValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Convert.ToInt32 Failed: {ex.Message}");
            }
        }
    }

}
