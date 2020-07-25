using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] oStrArrEmployee = new string[3];
            oStrArrEmployee[0] = "Mark";
            oStrArrEmployee[1] = "Devid";
            oStrArrEmployee[2] = "Rachel";

            String[][] oStrArrOfArrJagged = new string[3][];
            oStrArrOfArrJagged[0] = new string[3];
            oStrArrOfArrJagged[1] = new string[1];
            oStrArrOfArrJagged[2] = new string[2];

            oStrArrOfArrJagged[0][0] = "Bachelor";
            oStrArrOfArrJagged[0][1] = "Master";
            oStrArrOfArrJagged[0][2] = "Doctorate";

            oStrArrOfArrJagged[1][0] = "Bachelor";

            oStrArrOfArrJagged[2][0] = "Bachelor";
            oStrArrOfArrJagged[2][1] = "Master";

            for (int i = 0; i < oStrArrOfArrJagged.Length; i++)
            {
                Console.WriteLine(oStrArrEmployee[i]);
                Console.WriteLine("----------------");
                string[] oInnerArr = oStrArrOfArrJagged[i];
                for (int j = 0; j < oInnerArr.Length; j++)
                {
                    Console.WriteLine(oInnerArr[j]);
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
