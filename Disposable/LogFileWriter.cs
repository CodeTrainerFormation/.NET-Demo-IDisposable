using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disposable
{
    public class LogFileWriter : IDisposable
    {
        protected bool isDisposed = false;

        ~LogFileWriter()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (!isDisposed)
            {
                if (isDisposing)
                {
                    // Clean here your managed resources
                }

                // Clean here your unmanaged resources

                isDisposed = true;

                //base.Dispose(isDisposing); //only if inherits from IDisposable object
            }
        }
    }

}
