using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    { //Get okuma Set yazma
        bool Success { get; }
        string Message { get; }
    }
}
