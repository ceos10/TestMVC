using System;
using TestMVC.Models;

namespace TestMVC.Business
{
    public class Service
    {
        public ResultModel Process(string ucid)
        {
            return new ResultModel { CustomerId = 11010, Ucid = ucid, LanguageId = "en-us" };
        }
    }
}
