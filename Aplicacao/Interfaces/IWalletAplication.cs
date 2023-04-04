using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplication.Interfaces
{
    public interface IWalletAplication
    {
        Task CreateAsync(Wallet wallet);
    }
}
