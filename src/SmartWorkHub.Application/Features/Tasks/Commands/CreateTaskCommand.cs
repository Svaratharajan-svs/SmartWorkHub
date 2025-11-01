using MediatR;
using SmartWorkHub.Application.Features.Tasks.DTOs;

namespace SmartWorkHub.Application.Features.Tasks.Commands
{
    public record CreateTaskCommand(
        string Title,
        string Description,
        DateTime DueDate,
        Guid UserId
    ) : IRequest<TaskDto>;
}
