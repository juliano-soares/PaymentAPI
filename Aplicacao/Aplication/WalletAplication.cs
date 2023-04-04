using Aplicacao.Aplication.Interfaces;
using Dominio.Interfaces;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplication
{
    public class WalletAplication : IWalletAplication
    {
        IWalletAplication _IWallet;
        IWallet _IWalletService;

        public WalletAplication(Interfaces.IWalletAplication IWallet, Dominio.Interfaces.IWallet IWalletService)
        {
            _IWallet = IWallet;
            _IWalletService = IWalletService;
        }

        public async Task<Wallet> CreateAsync(Wallet wallet)
        {
            return await _IWalletService.CreateAsync(wallet);
        }
    }
}
