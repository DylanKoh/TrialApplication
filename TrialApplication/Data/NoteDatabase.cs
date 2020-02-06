using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TrialApplication.Models;

namespace TrialApplication.Data
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public NoteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Notes>().Wait();
        }
        public Task<List<Notes>> GetNotesAsync()
        {
            return _database.Table<Notes>().ToListAsync();
        }
        public Task<Notes> GetNoteAsync(int ID)
        {
            return _database.Table<Notes>().Where(x => x.ID == ID).FirstOrDefaultAsync();
        }
        public Task<int> SaveNoteAsync(Notes note)
        {
            if (note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Notes note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
