using Rmq.Producer.Api.Contracts;

namespace Rmq.Producer.Api.Services.Interfaces;

public interface IMessageService
{
    Task<JsonRpcResponse> SendMessageAsync(
        JsonRpcRequest request,
        CancellationToken cancellationToken = default);
}

