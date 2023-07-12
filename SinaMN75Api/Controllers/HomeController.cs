using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utilities_aspnet.Repositories;
using Utilities_aspnet.Utilities;

namespace SinaMN75Api.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    private readonly IPaymentRepository _paymentRepository;

    public HomeController(IPaymentRepository paymentRepository) => _paymentRepository = paymentRepository;

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [HttpGet("IncreaseWalletBalance/{amount:double}")]
    public async Task<GenericResponse<string?>> IncreaseWalletBalance(int amount) => await _paymentRepository.IncreaseWalletBalance(amount);

    [ApiExplorerSettings(IgnoreApi = true)]
    [HttpGet("WalletCallBack/{userId}/{amount:int}")]
    [HttpPost("WalletCallBack/{userId}/{amount:int}")]
    public async Task<IActionResult> WalletCallBack(string userId, int amount, string authority, string status)
    {
        GenericResponse i = await _paymentRepository.WalletCallBack(amount, authority, status, userId);
        return RedirectToAction(i.Status == UtilitiesStatusCodes.Success ? nameof(Verify) : nameof(Fail));
    }

    [ApiExplorerSettings(IgnoreApi = true)]
    [HttpGet("Fail")]
    public ActionResult Fail() => View();

    [ApiExplorerSettings(IgnoreApi = true)]
    [HttpGet("Verify")]
    public ActionResult Verify() => View("~/Views/Home/Verify.cshtml");

    [ApiExplorerSettings(IgnoreApi = true)]
    [HttpGet("CallBack/{productId:guid}")]
    [HttpPost("CallBack/{productId:guid}")]
    public async Task<IActionResult> CallBack(Guid productId, string authority, string status)
    {
        GenericResponse i = await _paymentRepository.CallBack(productId, authority, status);
        return RedirectToAction(i.Status == UtilitiesStatusCodes.Success ? nameof(Verify) : nameof(Fail));
    }

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [HttpGet("PayOrderZarinPal/{orderId}")]
    public async Task<GenericResponse<string?>> BuyProduct(Guid orderId) => await _paymentRepository.PayOrderZarinPal(orderId);

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [HttpGet("PaySubscriptionZarinPal/{subscriptionId:guid}")]
    public async Task<GenericResponse<string?>> UpgradeAccount(Guid subscriptionId) => await _paymentRepository.PaySubscriptionZarinPal(subscriptionId);

    [ApiExplorerSettings(IgnoreApi = true)]
    [HttpGet("CallBackSubscription/{subscriptionId:guid}")]
    [HttpPost("CallBackSubscription/{subscriptionId:guid}")]
    public async Task<IActionResult> WalletCallBack(Guid subscriptionId, string authority, string status)
    {
        GenericResponse i = await _paymentRepository.CallBackSubscription(subscriptionId, authority, status);
        return RedirectToAction(i.Status == UtilitiesStatusCodes.Success ? nameof(Verify) : nameof(Fail));
    }
}