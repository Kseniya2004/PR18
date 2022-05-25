using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    public class STRING
    {
        private string stroka;
        public string Stroka { get { return stroka; } set { stroka = value; } }

        public STRING() // Конструктор по умолчанию
        {
            stroka = "";
        }

        public STRING(string a)
        {
            stroka = a;
        }

        public string ChangeLine()
        {
            string answer = "";
            char[] myCharArr = stroka.ToCharArray();
            for (int i = 0; i < myCharArr.Length; i++)
            {
                if (char.IsLower(myCharArr[i])) answer += char.ToUpper(myCharArr[i]);
                else answer += char.ToLower(myCharArr[i]);
            }
            return answer;
        }
    }
}
