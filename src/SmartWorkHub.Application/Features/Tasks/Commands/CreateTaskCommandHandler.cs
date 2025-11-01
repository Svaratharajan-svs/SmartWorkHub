using MediatR;
using SmartWorkHub.Application.Features.Tasks.DTOs;
using SmartWorkHub.Domain.Entities;
using SmartWorkHub.Domain.Interfaces;

namespace SmartWorkHub.Application.Features.Tasks.Commands
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, TaskDto>
    {
        private readonly ITaskRepository _repository;

        public CreateTaskCommandHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<TaskDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var entity = new TaskItem
            {
                Title = request.Title,
                Description = request.Description,
                DueDate = request.DueDate,
                UserId = request.UserId,
                IsCompleted = false
            };

            await _repository.AddAsync(entity);

            return new TaskDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                DueDate = entity.DueDate,
                IsCompleted = entity.IsCompleted,
                UserId = entity.UserId
            };
        }
    }
}
