using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace DoctorsManagement.Models
    {
       
  public class GenericRepository<T> : IRepository<T> where T : class
        {
            private readonly DoctorsDbContext context;
            public GenericRepository(DoctorsDbContext ctx)
            {
                this.context = ctx;
            }
            public T Add(T doctor)
            {
                return context.Add(doctor).Entity;
            }
            public T Delete(T doctor)
            {
                return context.Remove(doctor).Entity;
            }
            public T Update(T doctor)
            {
                return context.Update(doctor).Entity;
            }
            public async Task<int> SaveAsync()
            {
                return await context.SaveChangesAsync();
            }
            public async Task<IReadOnlyCollection<T>> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> condition = null)
            {
                if (condition == null)
                    return await context.Set<T>().ToListAsync(); return await context.Set<T>().Where(condition).ToListAsync();
            }
            public async Task<T> GetByIdAsync(int id)
            {
                return await context.Set<T>().FindAsync(id);
            }


        }
    }
