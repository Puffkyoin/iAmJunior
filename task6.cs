using System;

class Program
{
    static void Main(string[] args)
    {
        int photosInAlbum = 52;
        int photosInRow = 3;
        int rowsFilled = photosInAlbum / photosInRow;
        int remainderPhotos = photosInAlbum % photosInRow;
        Console.WriteLine($" Заполнено {rowsFilled} строк.\n Остаток фото равен {remainderPhotos}.");
    }
}   
