using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Infrastructure
{
    public class ProfileAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            timer.Stop();
            string result = "<div>Elapsed time: "
                            + $"{timer.Elapsed.TotalMilliseconds} ms</div>";
            byte[] bytes = Encoding.UTF8.GetBytes(result);
            context.HttpContext.Response.Body.Write(bytes,0,bytes.Length);
            //var content = context.HttpContext.Response;
            //using (var responseWriter = new StreamWriter(content.Body, Encoding.UTF8))
            //{
            //    responseWriter.Write(result);
            //}
            //base.OnActionExecuted(context);
        }
    }
}
