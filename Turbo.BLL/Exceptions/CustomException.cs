using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Runtime.Serialization;

namespace Turbo.BLL.Exceptions
{
    [Serializable]
    public class CustomException : Exception
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));
            base.GetObjectData(info, context);
        }
    }

    [Serializable]
    public class BllAddException : CustomException
    {
        public BllAddException(string message) : base(message) { }
        protected BllAddException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class BllDeleteException : CustomException
    {
        public BllDeleteException(string message) : base(message) { }
        protected BllDeleteException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class BllGetException : CustomException
    {
        public BllGetException(string message) : base(message) { }
        protected BllGetException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class BllUpdateException : CustomException
    {
        public BllUpdateException(string message) : base(message) { }
        protected BllUpdateException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

