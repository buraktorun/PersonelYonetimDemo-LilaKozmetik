using Business.Interface;
using Business.Repository;
using DataAccess.Entity;

namespace Business.Service
{
    public class PersonelService
    {
        private readonly IGenericRepository<Personel> _personelRepo;

        public PersonelService()
        {

            _personelRepo = new GenericRepository<Personel>();
        }

        public async Task<List<Personel>> GetAllAsync()
        {

            return await _personelRepo.GetAllAsync();
        }

        public async Task AddAsync(Personel personel)
        {


            if (string.IsNullOrWhiteSpace(personel.Ad))
            {
                throw new Exception("Personel adı boş olamaz.");
            }



            if (personel.Maas < 0)
            {
                throw new Exception("Maaş 0'dan küçük olmamalı.");
            }

            await _personelRepo.AddAsync(personel);
            await _personelRepo.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var personel = await _personelRepo.GetByIdAsync(id);


            if (personel != null)
            {
                _personelRepo.Delete(personel);
                await _personelRepo.SaveAsync();
            }
        }
    }
}