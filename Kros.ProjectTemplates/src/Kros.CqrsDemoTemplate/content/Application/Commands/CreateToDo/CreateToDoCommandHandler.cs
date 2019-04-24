﻿using Kros.CqrsDemoTemplate.Application.Model;
using Kros.CqrsDemoTemplate.Application.Notifications;
using Kros.Utils;
using Mapster;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kros.CqrsDemoTemplate.Application.Commands
{
    /// <summary>
    /// Create ToDo Command Handler.
    /// </summary>
    public class CreateToDoCommandHandler: IRequestHandler<CreateToDoCommand, int>
    {
        private readonly IToDoRepository _repository;
        private readonly IMediator _mediator;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="repository">ToDo repository.</param>
        /// <param name="mediator">Mediator for publishing events.</param>
        public CreateToDoCommandHandler(IToDoRepository repository, IMediator mediator)
        {
            _repository = Check.NotNull(repository, nameof(repository));
            _mediator = Check.NotNull(mediator, nameof(mediator));
        }

        /// <inheritdoc />
        public async Task<int> Handle(CreateToDoCommand request, CancellationToken cancellationToken)
        {
            var toDo = request.Adapt<ToDo>();
            await _repository.CreateToDoAsync(toDo);
            await _mediator.Publish(new ToDoUpdated(toDo.Id, request.UserId));

            return toDo.Id;
        }
    }
}