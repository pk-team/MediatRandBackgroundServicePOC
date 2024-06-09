namespace BackgroundMetiatR;

public static class DependencyInjection {
    public static IServiceCollection AddApi(this IServiceCollection services) {
        services.AddMediatR(o => {
            o.RegisterServicesFromAssemblies([typeof(DependencyInjection).Assembly]);
        });
        services.AddHostedService<CreateUserBackgroundService>();
        services.AddLogging(config => config.AddConsole());
        return services;
    }
}