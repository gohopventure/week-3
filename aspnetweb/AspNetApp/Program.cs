using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace AspNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webHost => 
            {
                webHost.Configure(app => 
                {
                    app.UseRouting();
                    app.UseEndpoints(http => 
                    {
                        http.MapGet("/", async req => 
                        {
                            await req.Response.WriteAsync("<h1>Hello, ASPNET!<h1>");
                        });
                    });
                });
            });

            server.Build().Run();
        }
    }
}
