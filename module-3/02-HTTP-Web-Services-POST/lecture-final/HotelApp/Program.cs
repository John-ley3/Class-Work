using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    class Program
    {

        static void Main(string[] args)
        {
            CLI cli = new CLI(new APIService("http://localhost:3000/"),new ConsoleService());
            cli.Run();
        }
    }
}
