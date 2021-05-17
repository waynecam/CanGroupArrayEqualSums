using System;
using System.Collections.Generic;
using System.Text;

namespace CanGroupArrayEqualSums
{
    public class Result
    {

        public bool CanSplit { get; set; }

        public string Message { get; set; }
        public Result(bool canSplit, string message)
        {
            this.CanSplit = canSplit;
            this.Message = message;

        }
    }
}
