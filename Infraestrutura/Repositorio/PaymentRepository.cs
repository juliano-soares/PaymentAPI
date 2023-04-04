using Dominio.Interfaces;
using Entidades.Entidades;
using Infraestrutura.Configuracoes;
using Infraestrutura.Repositorio.Genericos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio
{
    public class PaymentRepository : IPayment
    {
        private readonly DbContextOptions<Context> _optionsbuilder;

        public PaymentRepository()
        {
            _optionsbuilder = new DbContextOptions<Context>();
        }

        public async Task Adicionar(int amount, string date, Wallet wallet)
        {
            try
            {
                using (var data = new Context(_optionsbuilder))
                {
                    await data.Payment.AddAsync(
                        new Payment
                        {
                            Amount = amount,
                            OwnerId = 1,
                            CreatedAt = DateTime.Now,
                        }
                    );
                    await data.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

            }
        }

        /*
        public async Task GetValueDay(DateTime date)
        {
            using (var bd = new Context(_optionsbuilder))
            {
                //return await bd.Payment.Where(date).AsNoTracking().ToListAsync();
                return;
            }
        }
        */
    }
}
