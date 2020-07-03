using RPG.API.Database;

namespace RPG.API.IntegrationTests.Utilities
{
    static class InMemoryDbSetup
    {
        public static void AddDummyPlayer(ApplicationDbContext db)
        {
            db.Add(Dummies.GetDummyPlayer());
            db.SaveChanges();
        }

        public static void AddDummyPlayers(ApplicationDbContext db)
        {
            db.AddRange(Dummies.GetDummyPlayers());
            db.SaveChanges();
        }

        public static void ClearDbContext(ApplicationDbContext db)
        {
            db.RemoveRange(db.Players);
        }
    }
}
