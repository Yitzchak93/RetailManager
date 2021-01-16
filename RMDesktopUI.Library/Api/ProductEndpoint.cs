using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RMDesktopUI.Library.Models;

namespace RMDesktopUI.Library.Api
{
    public class ProductEndpoint : IProductEndpoint
    {
        private IAPIHelper _apiHelper;
        public ProductEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;

        }
        public async Task<List<ProductModel>> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Product"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsAsync<List<ProductModel>>();
                    return await result;
                }
                else
                {
                    // TODO: 1M Insead of just throwing an exception I throw exception with response.ReasonPrase
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
