# Plex Folder Nesting #

**Media folder**
```
/Media
   /Movies
      movie content
   /Music
      music content
   /TV Shows
      television content
```
## Movies ##
```
/Movies
   /Avatar (2009)
      Avatar (2009).mkv
   /Batman Begins (2005)
      Batman Begins (2005).mp4
      Batman Begins (2005).eng.srt
      poster.jpg
```

**Multipart Movies**
```
/Movies
   /The Dark Knight (2008)
      The Dark Knight (2008) - pt1.mp4
      The Dark Knight (2008) - pt2.mp4
```
Notes:

Not all Plex Apps support playback of stacked media
All parts must be of the same file format (e.g. all MP4 or all MKV)
All parts should have identical audio and subtitle streams in the same order
Only stacks up to 8 parts are supported
“Other Videos” libraries or those using the “Plex Video Files Scanner” do not support stacked content.

**Multiple versions**
```
/Movies
   /Pulp Fiction (1994)
      Pulp Fiction (1994) - 1080p.mkv
      Pulp Fiction (1994) - SD.m4v
```
Note: This feature is not intended for situations where you might have, for instance, both a “theatrical” and “director’s cut” version of a movie. Likewise, it is not appropriate for 2D vs 3D versions. Those situations are best handled by Splitting the movie into separate library items.

**Posters**
You might have your own image files for movie posters & backgrounds, subtitles, your own movie “extras”, etc. To use these, ensure they are named and organized, and that the Local Media Assets source is enabled and ordered correctly.

Enable “Local Media Assets”
“Local Media Assets” is an Agent source that loads local media files or embedded metadata for a media item. To do this, ensure the Agent source is enabled and topmost in the list:

Launch the Plex Web App
Choose Settings from the top right of the Home screen
Select your Plex Media Server from the horizontal list
Choose Agents
Choose the Library Type and Agent you want to change
Ensure Local Media Assets is checked
Ensure Local Media Assets is topmost in the list
Related Page: Agents

Local Artwork Assets
Supported File Formats
There are a number of supported custom media items that need to be named correctly so they are detected. The supported image file formats are:

jpg
jpeg
png
tbn
Poster Artwork
Posters are typically displayed for movies on Plex App dashboards, library views, and when looking at details for the movie. Poster art is typically of 1:1.5 aspect ratio. Custom Poster artwork will be detected and used if named and stored as follows:

MovieName (Release Date).ext or
Movie/MovieName (Release Date)/Custom_Poster_Name.ext
Where Custom_Poster_Name is:

cover
default
folder
movie
poster

```
/Movies
   /Avatar (2009)
      Avatar (2009).mkv
      poster.jpg
      poster-2.png
   Batman Begins (2005).mkv
   Batman Begins (2005)-1.jpg
   Batman Begins (2005)-2.tbn
```
```
/Movies
   Avatar (2009)-fanart.jpg
   Avatar (2009).mkv

/Movies
   /Avatar (2009)
      Avatar (2009).mkv
      fanart.jpg
```

## TV Shows##
Series/Episode type TV Shows
To name series/episode based shows:

TV Shows/ShowName/Season XX/ShowName – sXXeYY – Optional_Info.ext
Where:

XX is the season number
YY is the episode number

```
/TV Shows
   /Grey's Anatomy
      /Season 01
         Grey's Anatomy - s01e01.avi
         Grey's Anatomy - s01e02 - The First Cut is the Deepest.avi
         Grey's Anatomy - s01e03.mp4
      /Season 02
         Grey's Anatomy - s02e01.avi
         Grey's Anatomy - s02e02.mkv
         Grey's Anatomy - s02e03.m4v
```
**Multiple episode files**
```1
/TV Shows
   /Heroes
      /Season 02
         Heroes - s02e05-e08.mkv
      /Season 04
         Heroes - s04e01-e02.mkv
         Heroes - s04e03.mkv
```


