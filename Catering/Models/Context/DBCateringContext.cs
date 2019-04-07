using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Catering.Models
{
    public partial class DBCateringContext : DbContext
    {
        public DBCateringContext() // constructor
        {
        }

        public DBCateringContext(DbContextOptions<DBCateringContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Deliveries> Deliveries { get; set; }
        public virtual DbSet<Dishes> Dishes { get; set; }
        public virtual DbSet<DishesIngredients> DishesIngredients { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Institutions> Institutions { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuDishes> MenuDishes { get; set; }
        public virtual DbSet<Moderators> Moderators { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projects\\Catering\\Catering\\APP_DATA\\databaseCartening.mdf;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Deliveries>(entity =>
            {
                entity.HasKey(e => e.DeliveryId)
                    .HasName("PK__tmp_ms_x__626D8FCE23A0D734");

                entity.Property(e => e.Limit).HasColumnType("money");
            });

            modelBuilder.Entity<Dishes>(entity =>
            {
                entity.HasKey(e => e.DishId)
                    .HasName("PK__Dishes__18834F5071F764EB");

                entity.Property(e => e.DishId).ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DishesIngredients>(entity =>
            {
                entity.HasKey(e => new { e.DishId, e.IngredientId })
                    .HasName("PK__tmp_ms_x__A369A475E6386717");

                entity.HasOne(d => d.Dish)
                    .WithMany(p => p.DishesIngredients)
                    .HasForeignKey(d => d.DishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DishesIng__DishI__628FA481");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.DishesIngredients)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DishesIng__Ingre__6383C8BA");
            });

            modelBuilder.Entity<Ingredients>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK__tmp_ms_x__BEAEB25AC8F8238C");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Institutions>(entity =>
            {
                entity.HasKey(e => e.InstitutionId)
                    .HasName("PK__Institut__8DF6B6AD4A810F13");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__Instituti__CityI__68487DD7");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.DeliveryId)
                    .HasConstraintName("FK__Instituti__Deliv__66603565");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__Instituti__MenuI__6754599E");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuDishes>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.DishId })
                    .HasName("PK__tmp_ms_x__D816E6C5521C7932");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Dish)
                    .WithMany(p => p.MenuDishes)
                    .HasForeignKey(d => d.DishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuDishe__DishI__656C112C");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuDishes)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuDishe__MenuI__6477ECF3");
            });

            modelBuilder.Entity<Moderators>(entity =>
            {
                entity.HasKey(e => e.ModeratorId)
                    .HasName("PK__tmp_ms_x__737FFEA129ADCB2E");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BCF95F88585");

                entity.HasOne(d => d.Institution)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.InstitutionId)
                    .HasConstraintName("FK__Orders__Institut__6A30C649");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserId__693CA210");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tmp_ms_x__1788CC4C22CC317E");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
