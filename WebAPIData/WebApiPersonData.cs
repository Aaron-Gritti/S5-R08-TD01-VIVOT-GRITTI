using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData
{
    public class WebApiPersonData : PersonData
    {
        private HttpClient _httpClient;

        public WebApiPersonData()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://iutdijon.u-bourgogne.fr/intra/iq/webservices/annuaire/api.php");
        }

        public Task AddPerson(Person p)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            HttpResponseMessage rep = await _httpClient.GetAsync(_httpClient.BaseAddress);
           var JsonResponse = await rep.Content.ReadAsStringAsync();
        }

        public Task RemovePerson(Person p)
        {
            throw new NotImplementedException();
        }
    }
}
