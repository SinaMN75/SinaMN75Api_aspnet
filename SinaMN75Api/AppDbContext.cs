using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Utilities_aspnet.Entities;

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

	protected override void ConfigureConventions(ModelConfigurationBuilder b) => b.Conventions.Add(_ => new MaxStringLengthConvention());

	protected override void OnModelCreating(ModelBuilder builder) {
		base.OnModelCreating(builder);
		foreach (IMutableForeignKey fk in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) fk.DeleteBehavior = DeleteBehavior.NoAction;
		builder.Entity<CategoryEntity>().OwnsOne(e => e.JsonDetail, b => b.ToJson());
		builder.Entity<UserEntity>().OwnsOne(e => e.JsonDetail, b => b.ToJson());
		builder.Entity<GroupChatEntity>().OwnsOne(e => e.JsonDetail, b => b.ToJson());
		builder.Entity<MediaEntity>().OwnsOne(e => e.JsonDetail, b => b.ToJson());
		builder.Entity<ProductEntity>().OwnsOne(e => e.JsonDetail, b => b.ToJson());
		builder.Entity<CommentEntity>().OwnsOne(e => e.JsonDetail, b => {
			b.ToJson();
			b.OwnsMany(_ => _.Reacts);
		});
	}
}

public class MaxStringLengthConvention : IModelFinalizingConvention {
	public void ProcessModelFinalizing(IConventionModelBuilder mb, IConventionContext<IConventionModelBuilder> _) {
		foreach (IConventionProperty p in mb.Metadata.GetEntityTypes()
			         .SelectMany(e => e.GetDeclaredProperties().Where(p => p.ClrType == typeof(string)))) p.Builder.HasMaxLength(512);
	}
}