using System.Text;

namespace AlbumPhotoApp
{
    public static class PhotoAlbumStringOutput
    {
        public static string GetOutput(List<Photo> photoAlbum)
        {
            var photoAlbumStringBuilder = new StringBuilder();

            foreach (var photo in photoAlbum)
            {
                photoAlbumStringBuilder.AppendLine($"[{photo.ID}] {photo.Title}");
            }

            return photoAlbumStringBuilder.ToString();
        }
    }
}
