using BackgroundMetiatR.Application;
using MediatR;

public class CreateUserBackgroundService(IMediator mediator, ILogger<CreateUserBackgroundService> logger) : BackgroundService
{
    private readonly ISender _sender = mediator;
    private readonly ILogger<CreateUserBackgroundService> _logger = logger;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            string email = "jojo@gmail.com"; ;
            var result =  await _sender.Send(new CreateUserCommand(email), stoppingToken);
            _logger.LogInformation($"BG User created  {result.Id} - {result.Email}");
            await Task.Delay(5000, stoppingToken);
        }
    }
}