using System;
using Owin;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace ReactiveOwin
{
    public static class AppBuilderExtensons
    {
        public static IObservable<OwinHandlerContext> AsObservable(this IAppBuilder app)
        {
            var r = new Subject<OwinHandlerContext>();
            app.UseHandlerAsync(async (request, response, next) => await Task.Factory.StartNew(() => r.OnNext(new OwinHandlerContext { Request = request, Response = response, Next = next })));
            return r;
        }
    }
}
