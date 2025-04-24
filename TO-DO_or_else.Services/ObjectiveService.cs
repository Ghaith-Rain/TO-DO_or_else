using TO_DO_or_else.Data;
using TO_DO_or_else.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace TO_DO_or_else.Services
{
    public class ObjectiveService
    {
        private readonly AppDbContext _context;

        public ObjectiveService(AppDbContext context)
        {
            _context = context;
        }

        public List<Objective> GetAllObjectives()
        {
            return _context.Objectives.ToList();
        }
    }
}
