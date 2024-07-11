using BankingApp.Exceptions;
using BankingApp.Models;
using BankingApp.Models.DTO;
using BankingApp.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {


        private readonly ITransactionServi _transactionService;

        public TransactionController(ITransactionServi transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpPost("Login")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<string>> Login(WithdrawDTO dto)
        {
            try
            {

                var result = await _transactionService.Withdraw(dto);
                return Ok(result);
            }
            catch (UnauthorizedUserException uue)
            {

                return Unauthorized(new ErrorModel(401, uue.Message));
            }
            catch(InsufficientFundsException ife)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorModel(500, ife.Message));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorModel(500, ex.Message)); 
            }

        }




    }
}
