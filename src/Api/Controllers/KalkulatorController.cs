using Api.Logic;
using Api.Models.Tambah;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class KalkulatorController : ControllerBase
    {
        [HttpPost]
        public TambahResponse Tambah(TambahRequest request)
        {
            var response = KalkulatorLogic.EksekusiFungsiPertambahan(request);

            return response;
        }
    }
}