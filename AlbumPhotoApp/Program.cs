using AlbumPhotoApp;

class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Album id is required when running this application. Exiting");
            return;
        }

        bool couldParseAlbumIdArg = int.TryParse(args[0], out int albumId);

        if (!couldParseAlbumIdArg)
        {
            Console.WriteLine("Album id should be a number. Exiting.");
            return;
        }

        var photoAlbum = new PhotoRepository().getAlbumById(albumId).Result;
        var photoAlbumOutput = PhotoAlbumStringOutput.GetOutput(photoAlbum);

        Console.WriteLine(photoAlbumOutput);
        Console.WriteLine();
        Console.WriteLine("Press any key to end program.");
        Console.WriteLine();
        Console.ReadKey();
    }
}