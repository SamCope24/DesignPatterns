using System;

namespace DesignPatterns.Mediator.Vanilla;

public class BaseComponent
{
    protected IMediator? _mediator;

    public void SetMediator(IMediator mediator) =>
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
}