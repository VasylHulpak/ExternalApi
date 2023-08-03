using MediatR;
using Microsoft.AspNetCore.Mvc;
using YotiApi.Yoti.Commands;

namespace YotiApi.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class YotiController : ControllerBase
{
	private readonly IMediator _mediator;
	public YotiController(IMediator mediator)
	{
		_mediator = mediator;
	}
	
	[HttpPost]
	[Route("CallbackIdentityVerification")]
	public Task CallbackIdentityVerification(CallbackIdentityVerificationCommand command, CancellationToken cancellationToken)
	{
		return _mediator.Send(command, cancellationToken);
	}

	[HttpPost]
	[Route("CallbackAgeVerification")]
	public Task CallbackAgeVerification(CallbackAgeVerificationCommand command, CancellationToken cancellationToken)
	{
		return _mediator.Send(command, cancellationToken);
	}
}
