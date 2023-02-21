using System.Net.Http.Json;

namespace AlbumPhotoApp
{
    public class PhotoRepository
    {
        public readonly string url = "https://jsonplaceholder.typicode.com/photos?albumId=";
        public async Task<List<Photo>> getAlbumById(int id)
        {
            using HttpClient client = new();

            var response = await client.GetAsync($"{url}{id}");
            var photos = await response.Content.ReadFromJsonAsync<List<Photo>>() ?? new List<Photo>();

            return response.IsSuccessStatusCode
                ? photos
                : throw new Exception($"Unable to retrieve album content for id: {id}.");
        }
    }
}
