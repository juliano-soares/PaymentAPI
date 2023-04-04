using Dominio.Interfaces;
using Entidades.Entidades;
using Infraestrutura.Configuracoes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio
{
    public class WalletRepository :  IWallet
    {
        private readonly DbContextOptions<Context> _optionsbuilder;

        public WalletRepository()
        {
            _optionsbuilder = new DbContextOptions<Context>();
        }

        public async Task CreateAsync(Wallet wallet)
        {
            try
            {
                using (var data = new Context(_optionsbuilder))
                {
                    Wallet alreadyExist = await data.Wallet.Where(u=>u.OwnerName.Equals(wallet.OwnerName, StringComparison.OrdinalIgnoreCase)).AsNoTracking().FirstOrDefaultAsync();

                    if(alreadyExist != null)
                    {
                        return;
                    }

                    await data.Wallet.AddAsync(
                        new Wallet
                        {
                            OwnerName = wallet.OwnerName,
                        }    
                    );
                    await data.SaveChangesAsync();
                }
            } 
            catch (Exception ex)
            {
                //new Error(ex.Message);
            }
        }
    }
}
