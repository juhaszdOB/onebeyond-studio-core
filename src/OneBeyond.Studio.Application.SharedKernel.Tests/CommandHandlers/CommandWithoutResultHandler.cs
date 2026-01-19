using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using OneBeyond.Studio.Core.Mediator;

namespace OneBeyond.Studio.Application.SharedKernel.Tests.CommandHandlers;

public sealed class CommandWithoutResultHandler : IRequestHandler<CommandWithoutResult>
{
    private readonly Queue<string> _testableContainer;

    public CommandWithoutResultHandler(Queue<string> testableContainer)
    {
        EnsureArg.IsNotNull(testableContainer, nameof(testableContainer));

        _testableContainer = testableContainer;
    }

    public Task Handle(CommandWithoutResult request, CancellationToken cancellationToken)
    {
        _testableContainer.Enqueue(GetType().FullName!);
        return Task.FromResult(true);
    }
}
