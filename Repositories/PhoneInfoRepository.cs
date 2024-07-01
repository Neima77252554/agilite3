using Agilite_2.Context;

namespace Agilite_2.Repositories
{
    public class PhoneInfoRepository(PhoneBookContext context)
    {
        private PhoneBookContext _context = context;

        public IEnumerable<PhoneInfo> GetPhoneInfos()
        {
            return _context.PhoneInfos.ToList();
        }

        public PhoneInfo GetPhoneInfo(int id)
        {
            return _context.PhoneInfos.FirstOrDefault(p => p.Id == id);
        }

        public PhoneInfo AddPhoneInfo(PhoneInfo phoneInfo)
        {
            _context.PhoneInfos.Add(phoneInfo);
            _context.SaveChanges();
            return phoneInfo;
        }

        public PhoneInfo UpdatePhoneInfo(int id, PhoneInfo phoneInfo)
        {
            var existingPhoneInfo = _context.PhoneInfos.FirstOrDefault(p => p.Id == id);
            if (existingPhoneInfo != null)
            {
                existingPhoneInfo.FirstName = phoneInfo.FirstName;
                existingPhoneInfo.LastName = phoneInfo.LastName;
                existingPhoneInfo.PhoneNumber = phoneInfo.PhoneNumber;
                _context.SaveChanges();
            }
            return existingPhoneInfo;
        }

        public void DeletePhoneInfo(int id)
        {
            var phoneInfo = _context.PhoneInfos.FirstOrDefault(p => p.Id == id);
            if (phoneInfo != null)
            {
                _context.PhoneInfos.Remove(phoneInfo);
                _context.SaveChanges();
            }
        }
    }
}
