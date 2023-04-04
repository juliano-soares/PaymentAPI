using Dominio.Interfaces;
using Entidades.Entidades;
using Entidades.Notificações;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class PaymentService : IPayment
    {
        private readonly IPayment _IPayment;

        public PaymentService(IPayment IPayment)
        {
            _IPayment = IPayment;
        }

        public async Task Adicionar(Payment payment, Wallet wallet)
        {
            // Verifica se a wallet existe


            var amountValidation = payment.ValidarPropriedadeDecimal(payment.Amount, "Amount");

            // O valor máximo para um pagamento é de 1000 reais
            if(payment.Amount > 1000)
            {
                // TODO: Retornar erro de limite máximo para pagamentos
            }

            // Durante o periodo diurno, o limite total é de 4000 reais
            // Durante o periodo noturno, o limite total é de 1000 reais
            // Durante o final de semana, o limite total é de 1000 reais
            
            if(amountValidation)
            {
                payment.CreatedAt = DateTime.Now;
                await _IPayment.Adicionar(payment, wallet);
            }
        }


        public decimal GetPaymentsDaytime(Wallet wallet, DateTime date)
        {
            // Vai retornar o limite total de dia
            return 0;
        }

        public decimal GetPaymentsNocturnal(Wallet wallet, DateTime date)
        {
            // Vai retornar o limite total de noite
            return 0;
        }

        public decimal GetPaymentsWeekend(Wallet wallet, DateTime date)
        {
            // Vai retornar o limite total nos fins de semana
            return 0;
        }

    }
}
