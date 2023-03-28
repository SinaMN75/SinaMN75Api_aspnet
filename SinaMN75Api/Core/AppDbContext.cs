﻿namespace SinaMN75Api.Core;

public class AppDbContext : IdentityDbContext<UserEntity>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TransactionEntity> Transactions { get; set; }
    public DbSet<ReportEntity> Reports { get; set; }
    public DbSet<NotificationEntity> Notifications { get; set; }
    public DbSet<FormEntity> Forms { get; set; }
    public DbSet<FollowEntity> Follows { get; set; }
    public DbSet<BookmarkEntity> Bookmarks { get; set; }
    public DbSet<MediaEntity> Media { get; set; }
    public DbSet<VoteEntity> Votes { get; set; }
    public DbSet<VoteFieldEntity> VoteFields { get; set; }
    public DbSet<ContentEntity> Contents { get; set; }
    public DbSet<OtpEntity> Otps { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<FormFieldEntity> FormFields { get; set; }
    public DbSet<ChatEntity> Chats { get; set; }
    public DbSet<CommentEntity> Comments { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<DiscountEntity> Discounts { get; set; }
    public DbSet<ProductInsight> ProductInsights { get; set; }
    public DbSet<VisitProducts> VisitProducts { get; set; }
    public DbSet<ChatReaction> ChatReactions { get; set; }
    public DbSet<ChatReacts> ChatReacts { get; set; }
    public DbSet<CommentReacts> CommentReacts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.ClientCascade;
        }
    }
}

