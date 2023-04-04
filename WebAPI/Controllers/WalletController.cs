using Aplicacao.Aplication.Interfaces;
using Entidades.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IWalletAplication _IWalletAplication;
    
        public WalletController(IWalletAplication IWalletAplication)
        {
            _IWalletAplication = IWalletAplication;
        }


        [HttpPost("/wallets")]
        public async Task<IActionResult> Adicionar([FromBody] WalletCreate walletCreate)
        {
            if (string.IsNullOrWhiteSpace(walletCreate.ownerName))
                return Ok("Falta o nome");

            var wallet = new Wallet
            {
                OwnerName = walletCreate.ownerName,
            };

            var result = await _IWalletAplication.CreateAsync(wallet);

            if(result.Errors.Any())
            {
                return BadRequest(result.Errors);
            }

            return Created(result);
        }
    }
}
