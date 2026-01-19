using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using OneBeyond.Studio.Core.Mediator;

namespace OneBeyond.Studio.Application.SharedKernel.Tests.CommandHandlers;

public sealed class CommandWithResultHandler : IRequestHandler<CommandWithResult, string>
{
    private readonly Queue<string> _testableContainer;

    public CommandWithResultHandler(Queue<string> testableContainer)
    {
        EnsureArg.IsNotNull(testableContainer, nameof(testableContainer));

        _testableContainer = testableContainer;
    }

    public Task<string> Handle(CommandWithResult request, CancellationToken cancellationToken)
    {
        _testableContainer.Enqueue(GetType().FullName!);
        return Task.FromResult("CommandWithResult EXECUTED");
    }
}
