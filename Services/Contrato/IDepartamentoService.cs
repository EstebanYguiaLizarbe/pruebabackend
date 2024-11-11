using WebApplication1.Models;

namespace WebApplication1.Services.Contrato
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetList();
    }
}
