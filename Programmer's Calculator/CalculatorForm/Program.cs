using System;
using Numbers;

namespace CalculatorForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = null;
            Number output = null;
            Number number1 = null;
            Number number2 = null;
            string inputValue1 = "", inputValue2 = "";
            bool bin = false;
            bool octa = false;
            bool hex = false;

            Console.WriteLine("*******************************************************************\n");
            Console.WriteLine($"                          CALCULATOR                               \n");
            Console.WriteLine("*******************************************************************\n");
            Console.WriteLine("Enter the Number Type: Hexadecimal(H)/Binary(B)/Octal(O): \n");
            ConsoleKeyInfo userNumType = Console.ReadKey();
            if (char.Parse(userNumType.KeyChar.ToString()) == 'H')
            {

                Console.WriteLine("\nYou have chosen Hexadecimal as input type\n");
                number = new Hexadecimal();
                Console.WriteLine("*******************************************************************\n");
                Console.WriteLine("Options: \n 1. Operations 2. Conversions\n");
                Console.WriteLine("Enter your option: ");
                ConsoleKeyInfo userOptions = Console.ReadKey();

                if ((char.IsDigit(userOptions.KeyChar) && int.Parse(userOptions.KeyChar.ToString()) == 2))
                {
                    hex = true;
                    Hexconverter();
                }
                if (char.IsDigit(userOptions.KeyChar) && int.Parse(userOptions.KeyChar.ToString()) == 1)
                {
                    hex = true;
                    BinOperation();
                }
            }

            else if (char.Parse(userNumType.KeyChar.ToString()) == 'O')
            {
                Console.WriteLine("\n*******************************************************************\n");
                Console.WriteLine("\nYou have chosen Octal as input type");
                number = new Octal();

               
                Console.WriteLine("Options: \n 1. Operations 2. Conversions\n");
                Console.WriteLine("Enter your option: ");
                ConsoleKeyInfo userOptions = Console.ReadKey();

                if ((char.IsDigit(userOptions.KeyChar) && int.Parse(userOptions.KeyChar.ToString()) == 2))
                {
                    octa = true;
                    Octconverter();
                }
                if (char.IsDigit(userOptions.KeyChar) && int.Parse(userOptions.KeyChar.ToString()) == 1)
                {
                    octa = true;
                    BinOperation();
                }
            }
            else if (char.Parse(userNumType.KeyChar.ToString()) == 'B')
            {
                Console.WriteLine("\n*******************************************************************\n");
                Console.WriteLine("\nYou have chosen Binary as input type");
                number = new Binary();

                Console.WriteLine("Options: \n 1. Operations 2. Conversions\n");
                Console.WriteLine("Enter your option: ");
                ConsoleKeyInfo userOptions = Console.ReadKey();

                if ((char.IsDigit(userOptions.KeyChar) && int.Parse(userOptions.KeyChar.ToString()) == 2))
                {
                    bin = true;
                    Binconverter();
                }
                if (char.IsDigit(userOptions.KeyChar) && int.Parse(userOptions.KeyChar.ToString()) == 1)
                {
                    bin = true;
                    BinOperation();
                }
            }
            Console.WriteLine("Enter the input");
            Console.WriteLine("Press 'E' to exit the process...\n");

            while (Console.ReadKey().Key != ConsoleKey.E)
            {

            }
            static bool HexInputValidation(string input)
            {
                return System.Text.RegularExpressions.Regex.IsMatch(input, @"\A\b[0-9a-fA-F]+\b\Z");
            }

            string BinOperation()
            {
                Console.WriteLine("\n*******************************************************************\n");
                Console.WriteLine("\nEnter the input 1 value: ");
                inputValue1 = Console.ReadLine();
                string inp = "";
                if (bin)
                {
                    number.AssignInputValue(inputValue1);
                    inp = "bin";

                }
                else if (octa)
                {
                    number.AssignInputValue(inputValue1);
                    number1 = new Binary();
                    number1.AssignInputValue(OctToBin(number));
                    number = number1;
                    inp = "oct";
                }
                else if (hex && HexInputValidation(inputValue1))
                {
                    number.AssignInputValue(inputValue1);
                    number1 = new Binary();
                    number1.AssignInputValue(HexToBin(number));
                    number = number1;
                    inp = "hex";
                }
                else { Console.WriteLine("Enter a valid entry for your digit type."); }

                Console.WriteLine("Enter the Operation type to calculate the given input: Add(+)/Subtract(-)/Multiply(*)/Divide(/)/And(A)/Or(O)/Xor(X): \n");
                char outputType = char.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the input 2 value: ");
                inputValue2 = Console.ReadLine();
                if (bin)
                {
                    output = new Binary();
                    output.AssignInputValue(inputValue2);
                    inp = "bin";
                }
                else if (octa)
                {
                    output.AssignInputValue(inputValue2);
                    number2 = new Binary();
                    number2.AssignInputValue(OctToBin(output));
                    output = number2;
                    inp = "oct";
                }
                else if (hex && HexInputValidation(inputValue2))
                {
                    output.AssignInputValue(inputValue2);
                    number2 = new Binary();
                    number2.AssignInputValue(HexToBin(output));
                    output = number2;
                    inp = "hex";
                }
                else
                {
                    Console.WriteLine("Enter a valid entry for your digit type.");
                }

                Operations.Operation op = null;
                if (outputType == '+')
                {
                    op = new Operations.AddOperation();
                    output = op.Calculate(number, output);
                }
                if (outputType == '-')
                {
                    op = new Operations.SubOperation();
                    output = op.Calculate(number, output);
                }
                if (outputType == '*')
                {
                    op = new Operations.MultiplyOperation();
                    output = op.Calculate(number, output);
                }
                if (outputType == '/')
                {
                    op = new Operations.DivideOperation();
                    output = op.Calculate(number, output);
                }
                if (outputType == 'A')
                {
                    op = new Operations.AndOperation();
                    output = op.Calculate(number, output);
                }
                if (outputType == 'O')
                {
                    op = new Operations.OrOperation();
                    output = op.Calculate(number, output);
                }
                if (outputType == 'X')
                {
                    op = new Operations.XorOperation();
                    output = op.Calculate(number, output);
                }
                if (inp == "hex")
                {
                    output = convertToHex(output);

                }
                else if (inp == "oct")
                {
                    output = convertToOct(output);

                }

                Console.WriteLine("\nDisplay output: " + output.ToString());
                Console.WriteLine("\n*******************************************************************\n");
                return output.ToString();
            }

            string Hexconverter()
            {
                Console.WriteLine("\n*******************************************************************\n");
                Console.WriteLine("\nEnter the input value: ");
                inputValue1 = Console.ReadLine();
                if (HexInputValidation(inputValue1))
                {
                    Console.WriteLine("Input value: " + inputValue1);
                    number.AssignInputValue(inputValue1);
                }
                else { Console.WriteLine("Enter a valid entry for your digit type."); }
                Convertors.ConvertorFactory cf = new Convertors.ConvertorFactory();
                Console.WriteLine("Enter the convertor type to convert the given input: Hexadecimal(H)/Binary(B)/Octal(O): \n");
                char outputType = char.Parse(Console.ReadLine());
                if (outputType == 'H')
                {
                    output = cf.Convert(Numbers.NumberType.Hexadecimal, number, Numbers.NumberType.Hexadecimal);
                }
                if (outputType == 'B')
                {
                    output = cf.Convert(Numbers.NumberType.Hexadecimal, number, Numbers.NumberType.Binary);
                }
                if (outputType == 'O')
                {
                    output = cf.Convert(Numbers.NumberType.Hexadecimal, number, Numbers.NumberType.Binary);
                    output = cf.Convert(Numbers.NumberType.Binary, output, Numbers.NumberType.Octal);
                }
                Console.WriteLine("\nDisplay output: " + output.ToString());
                Console.WriteLine("\n*******************************************************************\n");
                return output.ToString();
            }
            string Octconverter()
            {
                Console.WriteLine("\n*******************************************************************\n");
                Console.WriteLine("\nEnter the input value: ");
                inputValue1 = Console.ReadLine();
                if (octa)
                {
                    Console.WriteLine("Input value: " + inputValue1);
                    number.AssignInputValue(inputValue1);
                }
                else { Console.WriteLine("Enter a valid entry for your digit type."); }
                Convertors.ConvertorFactory cf = new Convertors.ConvertorFactory();
                Console.WriteLine("Enter the convertor type to convert the given input: Binary(B)/Octal(O)/Hexadecimal(H): \n");
                char outputType = char.Parse(Console.ReadLine());
               
                if (outputType == 'B')
                {
                    output = cf.Convert(Numbers.NumberType.Octal, number, Numbers.NumberType.Binary);
                }
                if (outputType == 'O')
                {
                    output = cf.Convert(Numbers.NumberType.Octal, number, Numbers.NumberType.Octal);
                }
                if (outputType == 'H')
                {
                    output = cf.Convert(Numbers.NumberType.Octal, number, Numbers.NumberType.Binary);
                    output = cf.Convert(Numbers.NumberType.Binary, output, Numbers.NumberType.Hexadecimal);
                }
                Console.WriteLine("\nDisplay output: " + output.ToString());
                Console.WriteLine("\n*******************************************************************\n");
                return output.ToString();
            }
            string Binconverter()
            {
                Console.WriteLine("\n*******************************************************************\n");
                Console.WriteLine("\nEnter the input value: ");
                inputValue1 = Console.ReadLine();
                if (bin)
                {
                    Console.WriteLine("Input value: " + inputValue1);
                    number.AssignInputValue(inputValue1);
                }
                else { Console.WriteLine("Enter a valid entry for your digit type."); }
                Convertors.ConvertorFactory cf = new Convertors.ConvertorFactory();
                Console.WriteLine("Enter the convertor type to convert the given input: Hexadecimal(H)/Binary(B)/Octal(O): \n");
                char outputType = char.Parse(Console.ReadLine());
                if (outputType == 'H')
                {
                    output = cf.Convert(Numbers.NumberType.Binary, number, Numbers.NumberType.Hexadecimal);
                }
                if (outputType == 'B')
                {
                    output = cf.Convert(Numbers.NumberType.Binary, number, Numbers.NumberType.Binary);
                }
                if (outputType == 'O')
                {
                    output = cf.Convert(Numbers.NumberType.Binary, number, Numbers.NumberType.Octal);
                }

                Console.WriteLine("\nDisplay output: " + output.ToString());
                Console.WriteLine("\n*******************************************************************\n");
                return output.ToString();
            }
            string HexToBin(Number number)
            {
                Convertors.ConvertorFactory cf = new Convertors.ConvertorFactory();
                output = cf.Convert(Numbers.NumberType.Hexadecimal, number, Numbers.NumberType.Binary);
                return output.ToString();
            }
            string OctToBin(Number number)
            {
                Convertors.ConvertorFactory cf = new Convertors.ConvertorFactory();
                output = cf.Convert(Numbers.NumberType.Octal, number, Numbers.NumberType.Binary);
                return output.ToString();
            }
            Number convertToHex(Number output)
            {
                Convertors.ConvertorFactory cf = new Convertors.ConvertorFactory();
                output = cf.Convert(Numbers.NumberType.Binary, output, Numbers.NumberType.Hexadecimal);
                return output;
            }
            Number convertToOct(Number output)
            {
                Convertors.ConvertorFactory cf = new Convertors.ConvertorFactory();
                output = cf.Convert(Numbers.NumberType.Binary, output, Numbers.NumberType.Octal);
                return output;
            }

        }
    }
}