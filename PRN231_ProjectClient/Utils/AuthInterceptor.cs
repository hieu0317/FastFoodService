using Grpc.Core;
using Grpc.Core.Interceptors;

namespace PRN231_ProjectClient.Utils
{
    public class AuthInterceptor : Interceptor
    {
        private IHttpContextAccessor httpContextAccessor;

        public AuthInterceptor(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            string token = httpContextAccessor.HttpContext.Session.GetString("token");
            var authorization = new Metadata();
            authorization.Add("Authorization", $"Bearer {token}");
            var opt = context.Options.WithHeaders(authorization);
            var newContext = new ClientInterceptorContext<TRequest, TResponse>(
                context.Method,
                context.Host,
                opt);
            return base.AsyncUnaryCall(request, newContext, continuation);
        }
    }
}
