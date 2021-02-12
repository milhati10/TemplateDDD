using Flunt.Notifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace $safeprojectname$.Notifications
{
    public class NotificationFilter : IAsyncResultFilter
    {
        private readonly Notifiable _notificationContext;

        public NotificationFilter(Notifiable notificationContext)
        {
            _notificationContext = notificationContext;
        }
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            if (_notificationContext.Invalid)
            {
                var error = new Error(_notificationContext.Notifications.Select(s => s.Message), HttpStatusCode.BadRequest);

                context.HttpContext.Response.StatusCode = error.Status;
                context.HttpContext.Response.ContentType = "application/json";

                var notifications = JsonConvert.SerializeObject(error);
                await context.HttpContext.Response.WriteAsync(notifications);

                return;
            }

            await next();
        }
    }
}
