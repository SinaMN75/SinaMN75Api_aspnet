using Microsoft.EntityFrameworkCore;
using Utilities_aspnet.Entities;
using Utilities_aspnet.Utilities;

namespace SinaMN75Api;

public class AppDbContext : DbContext {
	public AppDbContext(DbContextOptions options) : base(options) { }

	public DbSet<UserEntity> Users { get; set; } = null!;
	public DbSet<ProductEntity> Products { get; set; } = null!;
	public DbSet<TransactionEntity> Transactions { get; set; } = null!;
	public DbSet<ReportEntity> Reports { get; set; } = null!;
	public DbSet<NotificationEntity> Notifications { get; set; } = null!;
	public DbSet<FormEntity> Forms { get; set; } = null!;
	public DbSet<BookmarkEntity> Bookmarks { get; set; } = null!;
	public DbSet<MediaEntity> Media { get; set; } = null!;
	public DbSet<ContentEntity> Contents { get; set; } = null!;
	public DbSet<CategoryEntity> Categories { get; set; } = null!;
	public DbSet<FormFieldEntity> FormFields { get; set; } = null!;
	public DbSet<CommentEntity> Comments { get; set; } = null!;
	public DbSet<OrderEntity> Orders { get; set; } = null!;
	public DbSet<DiscountEntity> Discounts { get; set; } = null!;
	public DbSet<ProductInsight> ProductInsights { get; set; } = null!;
	public DbSet<VisitProducts> VisitProducts { get; set; } = null!;
	public DbSet<ReactionEntity> ReactionEntity { get; set; } = null!;
	public DbSet<SeenUsers> SeenUsers { get; set; } = null!;
	public DbSet<WithdrawEntity> Withdraw { get; set; } = null!;
	public DbSet<PromotionEntity> Promotions { get; set; } = null!;
	public DbSet<GroupChatEntity> GroupChats { get; set; } = null!;
	public DbSet<GroupChatMessageEntity> GroupChatMessages { get; set; } = null!;
	public DbSet<SubscriptionPaymentEntity> SubscriptionPayments { get; set; } = null!;

	protected override void OnModelCreating(ModelBuilder builder) {
		base.OnModelCreating(builder);
		builder.SetupModelBuilder();
		// builder.SeedContent();
	}
}