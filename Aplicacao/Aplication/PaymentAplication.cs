using Aplicacao.Aplication.Interfaces;
using Dominio.Interfaces;
using Entidades.Entidades;
using System.Threading.Tasks;

namespace Aplicacao.Aplication
{
    public class PaymentAplication : Interfaces.IPaymentAplication
    {
        IPaymentAplication _IPayment;
        IPayment _IPaymentService;

        public PaymentAplication(Interfaces.IPaymentAplication IPayment, Dominio.Interfaces.IPayment IPaymentService)
        {
            _IPayment = IPayment;
            _IPaymentService = IPaymentService;
        }

        public async Task Adicionar(Payment payment, Wallet wallet)
        {
           await _IPaymentService.Adicionar(payment, wallet);
        }
    }
}
