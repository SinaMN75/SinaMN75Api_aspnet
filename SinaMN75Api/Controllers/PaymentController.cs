namespace SinaMN75Api.Controllers;

[Route("[controller]")]
public class PaymentController : Controller {
	private readonly IPaymentRepository _paymentRepository;
	private const string ZarinPalMerchantId = "630e2aba-383e-449a-9c45-9eb324ed90fc";

	public PaymentController(IPaymentRepository paymentRepository) => _paymentRepository = paymentRepository;

	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[HttpGet("IncreaseWalletBalance/{amount:double}")]
	public async Task<GenericResponse<string?>> IncreaseWalletBalance(double amount)
		=> await _paymentRepository.IncreaseWalletBalance(amount, ZarinPalMerchantId);

	[ApiExplorerSettings(IgnoreApi = true)]
	[HttpGet("WalletCallBack/{userId}/{amount:int}")]
	[HttpPost("WalletCallBack/{userId}/{amount:int}")]
	public async Task<IActionResult> WalletCallBack(
		string userId,
		int amount,
		string authority,
		string status) {
		GenericResponse i = await _paymentRepository.WalletCallBack(amount, authority, status, userId, ZarinPalMerchantId);
		return RedirectToAction(i.Status == UtilitiesStatusCodes.Success ? nameof(Verify) : nameof(Fail));
	}

	[ApiExplorerSettings(IgnoreApi = true)]
	[HttpGet("Fail")]
	public ActionResult Fail() => View();

	[ApiExplorerSettings(IgnoreApi = true)]
	[HttpGet("Verify")]
	public ActionResult Verify() => View("~/Views/Payment/Verify.cshtml");

	[ApiExplorerSettings(IgnoreApi = true)]
	[HttpGet("CallBack/{productId:guid}")]
	[HttpPost("CallBack/{productId:guid}")]
	public async Task<IActionResult> CallBack(Guid productId, string authority, string status) {
		GenericResponse i = await _paymentRepository.CallBack(productId, authority, status, ZarinPalMerchantId);
		return RedirectToAction(i.Status == UtilitiesStatusCodes.Success ? nameof(Verify) : nameof(Fail));
	}

	[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
	[HttpGet("PayOrderZarinPal/{orderId}")]
	public async Task<GenericResponse<string?>> BuyProduct(Guid orderId) => await _paymentRepository.PayOrderZarinPal(orderId, ZarinPalMerchantId);
}