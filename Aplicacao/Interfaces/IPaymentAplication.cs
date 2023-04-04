using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplication.Interfaces
{
    public interface IPaymentAplication
    {
        Task Adicionar(Payment payment, Wallet wallet);
    }
}
