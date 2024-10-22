using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolesnikovMN.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach (char ch in value)
            {
                if (char.IsDigit(ch))
                {
                    res += ch;
                }
            }
            return Int32.Parse(res);
        }
    }
}
