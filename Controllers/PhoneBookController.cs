using Agilite_2.Context;
using Agilite_2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Agilite_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneBookController : ControllerBase
    {

        private readonly ILogger<PhoneBookController> _logger;
        private PhoneInfoRepository _phoneInfoRepository;

        public PhoneBookController(ILogger<PhoneBookController> logger, PhoneInfoRepository phoneInfoRepository)
        {
            _logger = logger;
            _phoneInfoRepository = phoneInfoRepository;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<PhoneInfo> GetAll()
        {
            return _phoneInfoRepository.GetPhoneInfos();
        }

        [HttpGet("{id}", Name = "GetById")]
        public PhoneInfo Get(int id)
        {
            return _phoneInfoRepository.GetPhoneInfo(id);
        }

        [HttpPost(Name = "NewPhoneInfo")]
        public PhoneInfo Post([FromBody] PhoneInfo phoneInfo)
        {
            return _phoneInfoRepository.AddPhoneInfo(phoneInfo);
        }

        [HttpPut("{id}", Name = "UpdatePhoneInfo")]
        public PhoneInfo Put(int id, [FromBody] PhoneInfo phoneInfo)
        {
            return _phoneInfoRepository.UpdatePhoneInfo(id, phoneInfo);
        }

        [HttpDelete("{id}", Name = "DeletePhoneInfo")]
        public void Delete(int id)
        {
            _phoneInfoRepository.DeletePhoneInfo(id);
        }
    }
}
