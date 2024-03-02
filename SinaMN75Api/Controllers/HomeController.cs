using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utilities_aspnet.Repositories;
using Utilities_aspnet.Utilities;

namespace SinaMN75Api.Controllers;

public class HomeController(IPaymentRepository paymentRepository) : Controller {
	public IActionResult Index() => View();

	[ApiExplorerSettings(IgnoreApi = true)]
	[HttpGet("Fail")]
	public ActionResult Fail() => View();

	[ApiExplorerSettings(IgnoreApi = true)]
	[HttpGet("Verify")]
	public ActionResult Verify() => View("~/Views/Home/Verify.cshtml");

	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[HttpGet("IncreaseWalletBalance/{amount:double}")]
	public Task<GenericResponse<string>> IncreaseWalletBalance(int amount) => paymentRepository.IncreaseWalletBalance(amount);

	[ApiExplorerSettings(IgnoreApi = true)]
	[HttpGet("CallBack/{tagPayment}/{id}")]
	[HttpPost("CallBack/{tagPayment}/{id}")]
	public async Task<IActionResult> CallBack(int tagPayment, string id, int success, int status, long trackId) {
		if (status != 2 || success != 1) return RedirectToAction(nameof(Fail));
		await paymentRepository.CallBack(tagPayment, id, trackId);
		return RedirectToAction(nameof(Verify));
	}

	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[HttpGet("PayOrderZarinPal/{orderId}")]
	public async Task<GenericResponse<string?>> PayOrder(Guid orderId) => await paymentRepository.PayOrder(orderId);
}