using Xunit;

namespace AlbumPhotoApp.Tests
{
    public class PhotoAlbumStringOutputTests
    {
        public class GetOutput
        {
            [Fact]
            public void ShouldShowCorrectOutputWhenGivenValidData()
            {            
                var photo =
                    new Photo
                    {
                        ID = 1,
                        Title = "Test"
                    };

                var albumData = new List<Photo> { photo };

                var expectedResult = $"[{photo.ID}] {photo.Title}\r\n";

                var output = PhotoAlbumStringOutput.GetOutput(albumData);

                Assert.Equal(expectedResult, output);
            }
        }
    }
}