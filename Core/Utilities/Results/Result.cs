using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this constructor uses the below constructor as a base
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
