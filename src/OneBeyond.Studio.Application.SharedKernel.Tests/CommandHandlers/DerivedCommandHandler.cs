using System.Collections.Generic;

namespace OneBeyond.Studio.Application.SharedKernel.Tests.CommandHandlers;

public sealed class DerivedCommand1Handler : BaseCommandHandler<DerivedCommand1>
{
    public DerivedCommand1Handler(Queue<string> testableContainer)
        : base(testableContainer)
    {
    }
}

public sealed class DerivedCommand2Handler : BaseCommandHandler<DerivedCommand2>
{
    public DerivedCommand2Handler(Queue<string> testableContainer)
        : base(testableContainer)
    {
    }
}
