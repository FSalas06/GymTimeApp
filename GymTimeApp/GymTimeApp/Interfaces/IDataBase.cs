using System;
namespace GymTimeApp.Interfaces
{
    public interface IDataBase
    {
		/// <summary>
        /// Gets the database path.
        /// </summary>
        /// <returns>The database path.</returns>
		string GetDatabasePath();
    }
}
