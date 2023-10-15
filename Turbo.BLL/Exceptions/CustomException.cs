using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.BLL.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
    public class BLLAddException : CustomException
    {
        public BLLAddException(string message) : base(message) { }
    }

    public class BLLDeleteException : CustomException
    {
        public BLLDeleteException(string message) : base(message) { }
    }

    public class BLLGetException : CustomException
    {
        public BLLGetException(string message) : base(message) { }
    }

    public class BLLUpdateException : CustomException
    {
        public BLLUpdateException(string message) : base(message) { }
    }
}
