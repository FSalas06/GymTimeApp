using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GymTimeApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GymTimeApp.LocalData
{
	public class ServicesDataBase<T> : IServicesDataBase<T> where T : class
    {
		DataBase bd;

        public ServicesDataBase()
        {
			bd = App.DB;
        }

		public virtual async Task<T> AddToTableAsync(T data)
		{
			await bd.Set<T>().AddAsync(data);
            await bd.SaveChangesAsync();
            return data;
		}

		public virtual async Task<bool> DeleteById(int id)
		{
			var entity = await GetByIdAsync(id);
            bd.Set<T>().Remove(entity);
            await bd.SaveChangesAsync();
            return true;
		}

		public virtual async Task<List<T>> GetTableAsync()
		{
			return await bd.Set<T>().ToListAsync();
		}

		public virtual async Task<T> GetByIdAsync(int id)
		{
			return await bd.Set<T>().FindAsync(id);
		}

		public virtual async Task<T> UpdateTable(T id)
		{
			bd.Set<T>().Update(id);
            await bd.SaveChangesAsync();
            return id;
		}
	}
}
