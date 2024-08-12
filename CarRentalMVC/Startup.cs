using CarRentalMVC.Services;

namespace CarRentalMVC;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IMessageSender, EmailMessageSender>();
    }

    public void Configure(IApplicationBuilder app, IHostEnvironment env, IMessageSender messageSender)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync(messageSender.Send());
        });
    }
}

