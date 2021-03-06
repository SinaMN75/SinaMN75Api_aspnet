namespace SinaMN75Api.Core;

public class AppDbContext : IdentityDbContext<UserEntity> {
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<ProductEntity> Products { get; set; }
	public DbSet<TransactionEntity> Transactions { get; set; }
	public DbSet<ReportEntity> Reports { get; set; }
	public DbSet<NotificationEntity> Notifications { get; set; }
	public DbSet<FormEntity> Forms { get; set; }
	public DbSet<FollowEntity> Follows { get; set; }
	public DbSet<BookmarkEntity> Bookmarks { get; set; }
	public DbSet<MediaEntity> Media { get; set; }
	public DbSet<TeamEntity> Teams { get; set; }
	public DbSet<VoteEntity> Votes { get; set; }
	public DbSet<VoteFieldEntity> VoteFields { get; set; }
	public DbSet<ContentEntity> Contents { get; set; }
	public DbSet<OtpEntity> Otps { get; set; }
	public DbSet<LocationEntity> Locations { get; set; }
	public DbSet<CategoryEntity> Categories { get; set; }
	public DbSet<FormFieldEntity> FormFields { get; set; }
	public DbSet<ChatEntity> Chats { get; set; }
	public DbSet<CommentEntity> Comments { get; set; }
	public DbSet<BlockEntity> Blocks { get; set; }
	public DbSet<OrderEntity> Orders { get; set; }
	public DbSet<TopProductEntity> TopProducts { get; set; }

}