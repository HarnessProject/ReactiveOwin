using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin.Types;

namespace ReactiveOwin
{
    public class OwinHandlerContext
    {
        public OwinRequest Request { get; set; }
        public OwinResponse Response { get; set; }
        public Func<Task> Next { get; set; }
    }
}
