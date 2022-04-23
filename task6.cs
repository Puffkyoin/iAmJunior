using System;

class Program
{
    static void Main(string[] args)
    {
        int photosInAlbum = 52;
        int photosInRow = 3;
        int rowsFilled = photosInAlbum / photosInRow;
        int remainder = photosInAlbum % photosInRow;
        Console.WriteLine($" Заполнено {rowsFilled} строк.\n Остаток фото равен {remainder}.");
    }
}   