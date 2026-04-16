using Novvi.Application.DTOs;


namespace Novvi.Application.Services.Interfaces;

public interface IPedidoService
{
    IReadOnlyCollection<PedidoResponse> GetAll();

    PedidoResponse? GetById(Guid id);

    PedidoResponse Create(PedidoRequest request);
    
    bool Delete(Guid id);
}