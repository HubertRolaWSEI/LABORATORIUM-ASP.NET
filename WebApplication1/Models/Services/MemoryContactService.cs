using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, ContactModel> _items = new Dictionary<int, ContactModel>();

        public int Add(ContactModel item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<ContactModel> GetAll()
        {
            return _items.Values.ToList();
        }

        public ContactModel? GetById(int id)
        {
            _items.TryGetValue(id, out var item);
            return item;
        }

        public void Update(ContactModel item)
        {
            _items[item.Id] = item;
        }
    }
}