
using System.Threading.Tasks;

namespace SuperSocket
{
    public abstract class MiddlewareBase : IMiddleware
    {
        public virtual void Start(IServer server)
        {

        }

        public virtual void Shutdown(IServer server)
        {
            
        }
        
        public virtual ValueTask<bool> RegisterSession(IAppSession session)
        {
            return new ValueTask<bool>(true);
        }
    }
}