using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cucumber
{
    public class Ip
    {
        private bool _checkIp;
        public Ip()
        {
            _checkIp = true;
        }
        public void CheckIp()
        {
            string ip = Console.ReadLine();
            string[] words = ip.Split(new char[] { '.' });
            for (int i = 0; i < words.Length; i++)
            {
                bool parse = int.TryParse(words[i], out var number);
                if (parse == true)
                {
                    if (number > 255 || number < 0)
                    {
                        _checkIp = false;
                        break;
                    }
                }
                else
                {
                    _checkIp = false;
                    Console.WriteLine("Ошибка 000x1000x011h");
                    break;
                }
            }
            TestIp();
        }
        private void TestIp()
        {
            if (_checkIp == true)
            {
                Console.WriteLine("ip адрес дейcтвительный");
            }
            else
            {
                Console.WriteLine("ip адрес недействительный");
            }
        }
    }
}
