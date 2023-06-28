using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Utilities_aspnet.Entities;
using Utilities_aspnet.Utilities;

namespace SinaMN75Api;

public class AppDbContext : IdentityDbContext<UserEntity> {
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<ProductEntity> Products { get; set; } = null!;
	public DbSet<TransactionEntity> Transactions { get; set; } = null!;
	public DbSet<ReportEntity> Reports { get; set; } = null!;
	public DbSet<NotificationEntity> Notifications { get; set; } = null!;
	public DbSet<FormEntity> Forms { get; set; } = null!;
	public DbSet<BookmarkEntity> Bookmarks { get; set; } = null!;
	public DbSet<MediaEntity> Media { get; set; } = null!;
	public DbSet<ContentEntity> Contents { get; set; } = null!;
	public DbSet<OtpEntity> Otps { get; set; } = null!;
	public DbSet<CategoryEntity> Categories { get; set; } = null!;
	public DbSet<FormFieldEntity> FormFields { get; set; } = null!;
	public DbSet<ChatEntity> Chats { get; set; } = null!;
	public DbSet<CommentEntity> Comments { get; set; } = null!;
	public DbSet<OrderEntity> Orders { get; set; } = null!;
	public DbSet<DiscountEntity> Discounts { get; set; } = null!;
	public DbSet<ProductInsight> ProductInsights { get; set; } = null!;
	public DbSet<VisitProducts> VisitProducts { get; set; } = null!;
	public DbSet<ReactionEntity> ReactionEntity { get; set; } = null!;
	public DbSet<SeenUsers> SeenUsers { get; set; } = null!;
	public DbSet<WithdrawEntity> Withdraw { get; set; } = null!;
	public DbSet<PromotionEntity> Promotions { get; set; } = null!;

	protected override void OnModelCreating(ModelBuilder builder) {
		base.OnModelCreating(builder);
		builder.SetupModelBuilder();
		builder.SeedContent();
	}
}