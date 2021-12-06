using BlazorAppTutoral.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTutoral.Data
{
    public class ContactService
    {
        private readonly DatabaseContext _db;
        public ContactService(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<List<Contact>> GetContactListAsync() => await _db.Contacts.OrderByDescending(c => c.IsSelected).ToListAsync();

        public bool AppendContact(Contact contact)
        {
            try
            {
                _db.Contacts.Add(contact);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public bool DeleteContact(int id)
        {
            var contact = _db.Contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null)
            {
                return false;

            }

            _db.Contacts.Remove(contact);
            _db.SaveChanges();
            return true;
        }
    }
}
