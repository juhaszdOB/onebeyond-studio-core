using OneBeyond.Studio.Core.Mediator;

namespace OneBeyond.Studio.Application.SharedKernel.Tests.CommandHandlers;

public sealed record CommandWithResult : IRequest<string>
{
}
