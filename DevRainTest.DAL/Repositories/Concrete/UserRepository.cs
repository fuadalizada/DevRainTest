﻿using DevRainTest.DAL.Repositories.Abstract;
using DevRainTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevRainTest.DAL.Repositories.Concrete
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly Microsoft.EntityFrameworkCore.DbContext _context;
        public UserRepository(DbContext.DevRainDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IQueryable<User>> GetByEmail(string email)
        {
            var result = await _context.Set<User>().Include(x => x.UserLoginAttempts).Where(x => x.Email == email).ToListAsync();
            return result.AsQueryable();
        }
    }
}