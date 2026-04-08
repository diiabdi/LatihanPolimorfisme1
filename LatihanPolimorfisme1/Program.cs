imageProcecsor imageProcecsor = new imageProcecsor();

imageProcecsor.Reize(-20);
imageProcecsor.Reize(80);
imageProcecsor.Reize(150);
imageProcecsor.Reize(100);

imageProcecsor.Reize(124, 234);
imageProcecsor.Reize("A4");
class imageProcecsor
{
    public void Reize(int percentage)     
        {
        if (percentage <= 0)
        {
            Console.WriteLine("Persentase tidak boleh nol atau negatif"); 
        }
        else if (percentage < 100)
        {
            Console.WriteLine($"Mengecilkan gambar menjadi {percentage}");
        }
        else if (percentage > 100)
        {
            Console.WriteLine($"Memperbesar gambar menjadi {percentage}");
        }
        else
        {
             Console.WriteLine("Ukuran gambar tetap");
        }
    }
    public void Reize(int lebar , int tinggi)
    {
        Console.WriteLine($"Mengubah Ukuran Gambar menjadi px {lebar}x{tinggi}");
    }
    public void Reize(string ukuran_kertas)
    {
        Console.WriteLine($"Menyesuaikan Ke format kertas {ukuran_kertas}");
    }
    
}