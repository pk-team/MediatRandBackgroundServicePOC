using MediatR;

namespace BackgroundMetiatR.Application;

public class CreateUserCommandHandler(ILogger<CreateUserCommandHandler> logger) : IRequestHandler<CreateUserCommand, CreateUserCommandResult>
{
    private readonly ILogger<CreateUserCommandHandler> _logger = logger;

    public async Task<CreateUserCommandResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"InvokeHandler invoked {request.Email}");
        await Task.Delay(0);
        var userId = new Random().Next(1, 1000);
        return new CreateUserCommandResult(userId, request.Email);
    }
}

public record CreateUserCommand(string Email): IRequest<CreateUserCommandResult>;
public record CreateUserCommandResult(int Id, string Email);