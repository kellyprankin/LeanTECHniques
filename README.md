# Requirements to build
- .NET 7 SDK installed

# Building the app
- Open a terminal and navigate to the project root folder and enter the following command:

  - `dotnet build -c Release`

# Running the app
- Note: Relies on having built the app as mentioned above
- Open a terminal and navigate to the project root folder and enter the following command:

    - `cd AlbumPhotoApp\bin\Release\net7.0`

- Next, run the following command, but replace {albumId} with the album *number* you would like to retrieve and display the information for:

    - `./photo-album {albumId}`
