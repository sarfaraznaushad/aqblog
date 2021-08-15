using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AQBlog.Domain.Abstract;
using AQBlog.Model;

namespace AQBlog.Domain.Concrete
{
    public class ParentRepository<T> : IParentRepository<T> where T : ParentEntity
    {
        internal AQContext context;
        internal DbSet<T> dbSet;

        public ParentRepository(AQContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public IQueryable<T> Table => this.dbSet;

        public Task<bool> AnyAsync(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            return this.dbSet.Count();
        }

        public int Count(Expression<Func<T, bool>> where)
        {
            return this.dbSet.Where(where).Count();
        }

        public Task<int> CountAsync()
        {
            return this.dbSet.CountAsync();
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> where)
        {
            return this.dbSet.Where(where).CountAsync();
        }

        public void Delete(T entity)
        {
            this.dbSet.Remove(entity);
            this.context.SaveChanges();
        }

        public void Delete(IEnumerable<T> entities)
        {
            this.dbSet.RemoveRange(entities);
            this.context.SaveChanges();
        }

        public async Task<T> DeleteAsync(T entity)
        {
            this.dbSet.Remove(entity);
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> DeleteAsync(IEnumerable<T> entities)
        {
            this.dbSet.RemoveRange(entities);
            await this.context.SaveChangesAsync();
            return entities;
        }

        public IList<T> FindByFilterDefinition(Expression<Func<T, bool>> expression)
        {
            return this.dbSet.Where(expression).ToList();
        }

        public T GetById(string id)
        {
            return this.dbSet.Find(id);
        }

        public T Insert(T entity)
        {
            this.dbSet.Add(entity);
            this.context.SaveChanges();
            return entity;
        }

        public void Insert(IEnumerable<T> entities)
        {
            this.dbSet.AddRange(entities);
            this.context.SaveChanges();
        }

        public async Task<T> InsertAsync(T entity)
        {
            await this.dbSet.AddAsync(entity);
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> InsertAsync(IEnumerable<T> entities)
        {
            await this.dbSet.AddRangeAsync(entities);
            await this.context.SaveChangesAsync();
            return entities;
        }

        public T Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
            return entity;
        }

        public void Update(IEnumerable<T> entities)
        {
            dbSet.AttachRange(entities);
            context.Entry(entities).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            dbSet.Attach(entity);
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> UpdateAsync(IEnumerable<T> entities)
        {
            dbSet.AttachRange(entities);
            context.Entry(entities).State = EntityState.Modified;
            await this.context.SaveChangesAsync();
            return entities;
        }
    }
}
