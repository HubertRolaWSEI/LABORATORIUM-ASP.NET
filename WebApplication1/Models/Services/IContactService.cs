using System.Collections.Generic;

namespace WebApplication1.Models.Services
{
    public interface iContactService
    {
        void Add(ContactModel contact);
        void Update(ContactModel contact);
        void Delete(int id);
        List<ContactModel> GetAll();
        ContactModel? GetById(int id);
    }
}