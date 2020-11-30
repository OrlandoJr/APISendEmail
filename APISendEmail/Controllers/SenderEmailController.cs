
using APISendEmail.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace APIEmail.Controllers
{
	public class SenderEmailController : ApiController
	{
		private IEmailService _emailService;

        public SenderEmailController(IEmailService emailService)
        {
           _emailService = emailService;
        }

        [HttpPost]
        public void Post([FromBody]EmailMessage message)
        {
            _emailService.Send(message);
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Teste/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT: api/Teste/5
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Teste/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
