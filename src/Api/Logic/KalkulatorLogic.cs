using Api.Models.Tambah;

namespace Api.Logic
{
    public static class KalkulatorLogic
    {
        public static TambahResponse EksekusiFungsiPertambahan(TambahRequest request)
        {
            var response = new TambahResponse();
            response.Hasil = request.Angka1 + request.Angka2;

            return response;
        }
    }
}