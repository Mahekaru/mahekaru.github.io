using System;
using System.Text;


namespace BinaryConverter.Models
{
    public class clsConvertToBin
    {
        public string Binary { get; set; } = "";
        public string text { get; set; } = "";
        public string animate { get; set; } = "animate";

        public String SanitizeInput(String Input)//If Binary contains spaces or \n it's removed
        {
            double num;
            //bool isNum;
            // int a;
            // string x;

            //'MainForm.lblErrorMessage.Text = "";

            if (Input.Contains(" ") == true || Input.Contains("\n") == true || Input.Contains("2") || Input.Contains("3") || Input.Contains("4") || Input.Contains("5") || Input.Contains("6") || Input.Contains("7") || Input.Contains("8") || Input.Contains("9"))
            {
                Input = Input.Replace(" ", "");
                Input = Input.Replace("\n", "");
                Input = Input.Replace("2", "");
                Input = Input.Replace("3", "");
                Input = Input.Replace("4", "");
                Input = Input.Replace("5", "");
                Input = Input.Replace("6", "");
                Input = Input.Replace("7", "");
                Input = Input.Replace("8", "");
                Input = Input.Replace("9", "");

            }

            num = Input.Length % 8;

            if (num > 0 || Input.Length < 8 || Input.Length % 8 != 0)
            {
                //MainForm.lblErrorMessage.Text = "Invalid Binary Syntax!!!";
                Input = "";
            }

            return Input;
        }

        public string ToBinary(string Data)
        {
            //MessageBox.Show(Data);
            StringBuilder stringBuilder = new StringBuilder();
            byte[] bytes = Encoding.ASCII.GetBytes(Data);
            int index = 0;
            while (index < bytes.Length)
            {
                byte num = bytes[index];
                stringBuilder.Append(Convert.ToString(num, 2).PadLeft(8, '0'));
                checked { ++index; }
            }
            string str = stringBuilder.ToString().Substring(0, stringBuilder.ToString().Length);
            stringBuilder = null;
            return str;
        }

        public string ToText(String Data)
        {
            string str = Data;
            byte[] bytes = new byte[checked((int)Math.Round(unchecked((double)str.Length / 8.0 - 1.0)) + 1)];
            int num1 = 0;
            int num2 = checked(bytes.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                try
                {
                    bytes[index] = Convert.ToByte(str.Substring(checked(index * 8), 8), 2);
                    checked { ++index; }
                }
                catch
                {
                }
            }
            str = Encoding.ASCII.GetString(bytes);
            return str;
        }
    }
}