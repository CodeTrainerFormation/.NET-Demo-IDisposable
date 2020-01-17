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
                    // Nettoyage ressources managées;
                }

                // Nettoyage ressources non managées;

                isDisposed = true;

                //base.Dispose(isDisposing); //uniquement si l'objet hérite d'un autre objet disposable
            }
        }
    }

}
