﻿using eTickets.Data;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace EticketsProjects2.Data.Services
{
    public class ActorsService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        async Task<Actor> IActorService.GetByIdAsync(int Id)
        {
            var data = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == Id);
            return data;
        }

        public async Task<Actor>UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
