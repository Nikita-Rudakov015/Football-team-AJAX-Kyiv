﻿namespace Footballers.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(FootballersDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
