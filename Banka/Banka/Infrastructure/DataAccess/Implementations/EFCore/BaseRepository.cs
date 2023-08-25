using Infrastructure.DataAccess.Interfaces;
using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Implementations.EFCore
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> where TEntity : class, IEntity,new() where TContext : DbContext, new()
    {
       
        //Getireceğimiz verileri Get komutu ile ayarlarız item listesini getiririz
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params string[] includeList)
        {
            using (var ctx = new TContext())
            {
                // Veritabanı setini al

                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
                // İlgili varlıkları dahil et

                if (includeList.Length > 0)
                {
                    foreach (var include in includeList)
                    {
                        dbSet = dbSet.Include(include);
                    }
                }
                // Belirtilen koşula gore tek bir varlık dondür

                return await dbSet.SingleOrDefaultAsync(predicate);
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params string[] includeList)
        {
            using (var ctx = new TContext())
            {
                // Veritabanı setini al

                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
                // İlgili varlıkları dahil et

                if (includeList.Length > 0)
                {
                    foreach (var item in includeList)
                    {
                        dbSet = dbSet.Include(item);
                    }
                }
                // Asenkron :Koşul belirtilmemişse, tüm varlıkları getir

                if (predicate == null)
                {
                    return await dbSet.ToListAsync();
                }
                // Belirtilen koşula gore filtrelenmiş varlıkları getir

                return await dbSet.Where(predicate).ToListAsync();
            }
        }

        public async Task<TEntity> InsertAsync(TEntity entity) // Bir varlık (entity) ekler.
        {
            using (var ctx = new TContext())
                {  // TContext sınıfından bir nesne oluştur.
                var entityEntry = await ctx.Set<TEntity>().AddAsync(entity); // Context'e varlığı ekle.
                await ctx.SaveChangesAsync(); // Değişiklikleri kaydet.
                return entityEntry.Entity; // Eklenen varlığı dondür.
            }
        }
        public async Task UpdateAsync(TEntity entity)
        {
            using (var ctx = new TContext())
            {
                ctx.Set<TEntity>().Update(entity);
                await ctx.SaveChangesAsync();
            }
        }
        // Veritabanından kod silmek için kullanılır
        public async Task DeleteAsync(TEntity entity)
        {
            using (var ctx = new TContext())
            {
                ctx.Set<TEntity>().Remove(entity);
                await ctx.SaveChangesAsync();
            }
        }
    }
}
