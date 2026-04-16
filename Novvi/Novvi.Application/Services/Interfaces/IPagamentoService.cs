using Novvi.Application.DTOs;


namespace Novvi.Application.Services.Interfaces;

public interface IPagamentoService
{
    IReadOnlyCollection<PagamentoResponse> GetAll();


}