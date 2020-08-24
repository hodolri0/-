using System;
using System.Collections.Generic;
using System.Linq;

namespace 김서방_찾기
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seoul = { "Jane", "Kim" };
            
            string result = Program.solution(seoul);

            Console.WriteLine(result);
        }
        static public string solution(string[] seoul)
        {
            string answer = "";
            List<string> s = seoul.ToList();
            int c = 0;
            for(int i= 0;i< s.Count; i++)
            {
                if(s[i] == "Kim")
                {
                    c = i;
                    break;
                }
            }
            answer = string.Format("김서방은 {0}에 있다", c.ToString());
            return answer;
        }
    }
}
