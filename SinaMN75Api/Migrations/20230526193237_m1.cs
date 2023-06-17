using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TitleTr1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TitleTr2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryJsonDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountPercent = table.Column<int>(type: "int", nullable: true),
                    NumberUses = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupChat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatorUserId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GroupChatJsonDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeenUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fk_GroupChat = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Fk_UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk_GroupChatMessage = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeenUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FormFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OptionList = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormFields_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormFields_FormFields_ParentId",
                        column: x => x.ParentId,
                        principalTable: "FormFields",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Suspend = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    MeliCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShebaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headline = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    AppUserName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AppPhoneNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AppEmail = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AccessLevel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Region = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    State = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Wallet = table.Column<double>(type: "float", nullable: true),
                    Point = table.Column<double>(type: "float", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Badge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    MutedChats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireUpgradeAccount = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AgeCategory = table.Column<int>(type: "int", nullable: false),
                    VisitedProducts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookmarkedProducts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowingUsers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowedUsers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlockedUsers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    GroupChatEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserJsonDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_GroupChat_GroupChatEntityId",
                        column: x => x.GroupChatEntityId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryEntityGroupChatEntity",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupChatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntityGroupChatEntity", x => new { x.CategoriesId, x.GroupChatsId });
                    table.ForeignKey(
                        name: "FK_CategoryEntityGroupChatEntity_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryEntityGroupChatEntity_GroupChat_GroupChatsId",
                        column: x => x.GroupChatsId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pelak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryEntityUserEntity",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntityUserEntity", x => new { x.CategoriesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CategoryEntityUserEntity_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryEntityUserEntity_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ReadMessage = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_FromUserId",
                        column: x => x.FromUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_ToUserId",
                        column: x => x.ToUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chats_Chats_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupChatMessage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GroupChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ForwardedMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeenUsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChatMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupChatMessage_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupChatMessage_GroupChatMessage_ForwardedMessageId",
                        column: x => x.ForwardedMessageId,
                        principalTable: "GroupChatMessage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupChatMessage_GroupChatMessage_ParentId",
                        column: x => x.ParentId,
                        principalTable: "GroupChatMessage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupChatMessage_GroupChat_GroupChatId",
                        column: x => x.GroupChatId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupChatMessage_SeenUsers_SeenUsersId",
                        column: x => x.SeenUsersId,
                        principalTable: "SeenUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Otps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Otps_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Withdraw",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShebaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    WithdrawState = table.Column<int>(type: "int", nullable: true),
                    ApplicantUserEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicantUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminUserEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdminUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Withdraw", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Withdraw_AspNetUsers_AdminUserEntityId",
                        column: x => x.AdminUserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Withdraw_AspNetUsers_ApplicantUserEntityId",
                        column: x => x.ApplicantUserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    DiscountCode = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductUseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PayNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: true),
                    DiscountPrice = table.Column<double>(type: "float", nullable: true),
                    DiscountPercent = table.Column<int>(type: "int", nullable: true),
                    SendPrice = table.Column<double>(type: "float", nullable: true),
                    SendType = table.Column<int>(type: "int", nullable: true),
                    PayType = table.Column<int>(type: "int", nullable: true),
                    PayDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductOwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_ProductOwnerId",
                        column: x => x.ProductOwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    State = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Boosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<double>(type: "float", nullable: true),
                    VoteCount = table.Column<double>(type: "float", nullable: true),
                    DiscountPercent = table.Column<int>(type: "int", nullable: true),
                    VisitsCount = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: true),
                    DiscountPrice = table.Column<double>(type: "float", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AgeCategory = table.Column<int>(type: "int", nullable: true),
                    ProductState = table.Column<int>(type: "int", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SeenUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teams = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChatEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupChatEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupChatMessageEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductJsonDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Chats_ChatEntityId",
                        column: x => x.ChatEntityId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_GroupChatMessage_GroupChatMessageEntityId",
                        column: x => x.GroupChatMessageEntityId,
                        principalTable: "GroupChatMessage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_GroupChat_GroupChatEntityId",
                        column: x => x.GroupChatEntityId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Authority = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GatewayName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PaymentId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ShebaNumber = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    JsonDetail = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    RefId = table.Column<long>(type: "bigint", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bookmarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FolderName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookmarks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookmarks_Bookmarks_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Bookmarks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookmarks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookmarks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryEntityProductEntity",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntityProductEntity", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryEntityProductEntity_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryEntityProductEntity_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommentJsonDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Comment_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Comment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SeenStatus = table.Column<int>(type: "int", nullable: true),
                    Visited = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatorUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayType = table.Column<int>(type: "int", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeCategories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    States = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Users = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GroupChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotion_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Promotion_GroupChat_GroupChatId",
                        column: x => x.GroupChatId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Promotion_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reaction = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reaction_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reaction_Chats_ChatsId",
                        column: x => x.ChatsId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reaction_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VisitProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VisitProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatorUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupChatMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_GroupChatMessage_GroupChatMessageId",
                        column: x => x.GroupChatMessageId,
                        principalTable: "GroupChatMessage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_GroupChat_GroupChatId",
                        column: x => x.GroupChatId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupChatMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookmarkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MediaJsonDetail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Bookmarks_BookmarkId",
                        column: x => x.BookmarkId,
                        principalTable: "Bookmarks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_GroupChatMessage_GroupChatMessageId",
                        column: x => x.GroupChatMessageId,
                        principalTable: "GroupChatMessage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_GroupChat_GroupChatId",
                        column: x => x.GroupChatId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UseCase = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FormFieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Forms_Categories_CategoryEntityId",
                        column: x => x.CategoryEntityId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Forms_FormFields_FormFieldId",
                        column: x => x.FormFieldId,
                        principalTable: "FormFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Forms_OrderDetail_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Forms_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductsInsight",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInsight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsInsight_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductsInsight_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductsInsight_Reaction_ReactionId",
                        column: x => x.ReactionId,
                        principalTable: "Reaction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GroupChatEntityId",
                table: "AspNetUsers",
                column: "GroupChatEntityId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_CategoryId",
                table: "Bookmarks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_ParentId",
                table: "Bookmarks",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_ProductId",
                table: "Bookmarks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_UserId",
                table: "Bookmarks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEntityGroupChatEntity_GroupChatsId",
                table: "CategoryEntityGroupChatEntity",
                column: "GroupChatsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEntityProductEntity_ProductsId",
                table: "CategoryEntityProductEntity",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEntityUserEntity_UsersId",
                table: "CategoryEntityUserEntity",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_FromUserId",
                table: "Chats",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ParentId",
                table: "Chats",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ToUserId",
                table: "Chats",
                column: "ToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ParentId",
                table: "Comment",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_CategoryId",
                table: "FormFields",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_ParentId",
                table: "FormFields",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_CategoryEntityId",
                table: "Forms",
                column: "CategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_FormFieldId",
                table: "Forms",
                column: "FormFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_OrderDetailId",
                table: "Forms",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_ProductId",
                table: "Forms",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_UserId",
                table: "Forms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_ForwardedMessageId",
                table: "GroupChatMessage",
                column: "ForwardedMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_GroupChatId",
                table: "GroupChatMessage",
                column: "GroupChatId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_ParentId",
                table: "GroupChatMessage",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_SeenUsersId",
                table: "GroupChatMessage",
                column: "SeenUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_UserId",
                table: "GroupChatMessage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_BookmarkId",
                table: "Media",
                column: "BookmarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_CategoryId",
                table: "Media",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ChatId",
                table: "Media",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_CommentId",
                table: "Media",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ContentId",
                table: "Media",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_GroupChatId",
                table: "Media",
                column: "GroupChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_GroupChatMessageId",
                table: "Media",
                column: "GroupChatMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_NotificationId",
                table: "Media",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ProductId",
                table: "Media",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_UserId",
                table: "Media",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CreatorUserId",
                table: "Notifications",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ProductId",
                table: "Notifications",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AddressId",
                table: "Order",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductOwnerId",
                table: "Order",
                column: "ProductOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_CategoryId",
                table: "OrderDetail",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Otps_UserId",
                table: "Otps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ChatEntityId",
                table: "Products",
                column: "ChatEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupChatEntityId",
                table: "Products",
                column: "GroupChatEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupChatMessageEntityId",
                table: "Products",
                column: "GroupChatMessageEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInsight_ProductId",
                table: "ProductsInsight",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInsight_ReactionId",
                table: "ProductsInsight",
                column: "ReactionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInsight_UserId",
                table: "ProductsInsight",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_GroupChatId",
                table: "Promotion",
                column: "GroupChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_ProductId",
                table: "Promotion",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_UserId",
                table: "Promotion",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_ChatsId",
                table: "Reaction",
                column: "ChatsId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_ProductId",
                table: "Reaction",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reaction_UserId",
                table: "Reaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ChatId",
                table: "Reports",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CommentId",
                table: "Reports",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CreatorUserId",
                table: "Reports",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_GroupChatId",
                table: "Reports",
                column: "GroupChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_GroupChatMessageId",
                table: "Reports",
                column: "GroupChatMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ProductId",
                table: "Reports",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrderId",
                table: "Transactions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProducts_ProductId",
                table: "VisitProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitProducts_UserId",
                table: "VisitProducts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Withdraw_AdminUserEntityId",
                table: "Withdraw",
                column: "AdminUserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Withdraw_ApplicantUserEntityId",
                table: "Withdraw",
                column: "ApplicantUserEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CategoryEntityGroupChatEntity");

            migrationBuilder.DropTable(
                name: "CategoryEntityProductEntity");

            migrationBuilder.DropTable(
                name: "CategoryEntityUserEntity");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Otps");

            migrationBuilder.DropTable(
                name: "ProductsInsight");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "VisitProducts");

            migrationBuilder.DropTable(
                name: "Withdraw");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "FormFields");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Bookmarks");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Reaction");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "GroupChatMessage");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SeenUsers");

            migrationBuilder.DropTable(
                name: "GroupChat");
        }
    }
}
