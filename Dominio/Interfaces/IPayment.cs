using Entidades.Entidades;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IPayment
    {
        Task Adicionar(Payment payment, Wallet wallet);
    }

}

