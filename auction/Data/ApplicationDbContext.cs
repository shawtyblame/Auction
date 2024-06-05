using auction.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace auction.API.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Lot> Lots => Set<Lot>();
		public DbSet<FinishedLot> FinishedLots => Set<FinishedLot>();
		public DbSet<Person> Persons => Set<Person>();

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			//PERSON
			builder.Entity<Person>().HasData(
				new Person
				{
					Id = Guid.Parse("8acd2227-d1b5-4e39-a805-6a69f5c1ac2d"),
					Name = "Alex",
					Middlename = "Alexeev",
					Lastname = "Alexeevich",
					PhoneNumber = "84839185327",
					Email = "LexaAlex@gmail.com",
					Tax = 0

				});
			builder.Entity<Person>().HasData(
				new Person
				{
					Id = Guid.Parse("a01f8511-765c-423e-a6df-dbb7fa019cf2"),
					Name = "Sergey",
					Middlename = "Sergeev",
					Lastname = "Sergeevich",
					PhoneNumber = "84291843912",
					Email = "seriy@gmail.com",
					Tax = 0
				});
			builder.Entity<Person>().HasData(
				new Person
				{
					Id = Guid.Parse("9239f33f-f32f-4138-8909-06fca0a6eb6e"),
					Name = "Vova",
					Middlename = "Vovanov",
					Lastname = "Vovanovich",
					PhoneNumber = "85931058214",
					Email = "vovosvo@mail.ru",
					Tax = 0
				});
			//LOT
			builder.Entity<Lot>().HasData(
				new Lot
				{
					Id = Guid.Parse("9303bf06-96f7-4cba-b913-0d2c9616bebd"),
					Name = "Склад 15 квм",
					Description = "Ну типа склад для всего площадью 15 квадратных метров со светом и отоплением и ну чем то еще не помню",
					StartPrice = 110,
					OwnerId = Guid.Parse("a01f8511-765c-423e-a6df-dbb7fa019cf2"),
					StartTime = DateTime.UtcNow,
					EndTime = DateTime.UtcNow.AddDays(5).AddHours(2)

				});
			builder.Entity<Lot>().HasData(
				new Lot
				{
					Id = Guid.Parse("fbd577c2-6b6a-4104-b1fd-0fe3177999c8"),
					Name = "Антиквариат набор",
					Description = "Набор антиквариата крч вот так",
					StartPrice = 40,
					OwnerId = Guid.Parse("9303bf06-96f7-4cba-b913-0d2c9616bebd"),
					StartTime = DateTime.UtcNow.AddDays(-5),
					EndTime = DateTime.UtcNow.AddSeconds(-20),
				});
			//FINISHEDLOTS
			builder.Entity<FinishedLot>().HasData(
				new FinishedLot
				{
					Id = Guid.Parse("f16565dc-e6a0-437e-8db0-459c148b448e"),
					LotId = Guid.Parse(""),
				});
		}
	}
}
