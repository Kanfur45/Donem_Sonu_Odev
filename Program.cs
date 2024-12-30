namespace Donem_Sonu_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string formatHata = "Lütfen uygun formatta sayı giriniz:";
            string OverflowHata = "Girilen sayı değeri tanımsız";
            string notDegeriHata = "Lütfen 0-100 aralığında not girişi yapınız:";

            double vizenotu = 0;
            double finalnotu = 0;
            double notortalama = 0;

            double sinifnotortalama = 0;
            double enkucuk = 0;
            double enbuyuk = 0;

            string[] tablobaslik = new string[]
            {
                    "Numara",
                    "Ad",
                    "Soyad",
                    "Vize Notu",
                    "Final Notu",
                    "Ortalama",
                    "Harf Notu"
            };

            try
            {
                Console.Write("Kaç öğrenci kaydetmek istiyorsunuz: ");
                int ogrencisayisi = Convert.ToInt32(Console.ReadLine());


                double[] ortalamatoplam = new double[ogrencisayisi];



                string[,] dizi = new string[ogrencisayisi + 1, tablobaslik.Length];

                for (int i = 0; i < tabloBaslik.Length; i++)
                {
                    dizi[0, i] = tabloBaslik[i];
                }


                for (int i = 0; i < ogrencisayisi; i++)
                {
                    Console.Write($"{i + 1}. Öğrencinin Numarasını Giriniz: ");
                    dizi[i + 1, 0] = int.Parse(Console.ReadLine()).ToString();
                    Console.Write($"{i + 1}. Öğrencinin Adını Giriniz: ");
                    dizi[i + 1, 1] = Console.ReadLine().Trim();

                    Console.Write($"{i + 1}. Öğrencinin Soyadını Giriniz: ");
                    dizi[i + 1, 2] = Console.ReadLine().Trim();

                    while (true)
                    {
                        try
                        {
                            Console.Write($"{i + 1}. Öğrencinin Vize Notunu Giriniz: ");
                            dizi[i + 1, 3] = Console.ReadLine();
                            vizenotu = Convert.ToDouble(dizi[i + 1, 3]);

                            if (vizenotu > 100 || vizeNotu < 0)
                            {
                                Console.WriteLine(notdegerihatası);
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(formathatası);
                        }
                        catch (Exception hata)
                        {
                            Console.WriteLine($"Beklenmeyen bir hata oluştu: {hata.Mesajı}");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write($"{i + 1}. Öğrencinin final notunu giriniz: ");
                            dizi[i + 1, 4] = Console.ReadLine();
                            finalnotu = Convert.ToDouble(dizi[i + 1, 4]);

                            if (finalnotu > 100 || finalnotu < 0)
                            {
                                Console.WriteLine(notdegerihatası);
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(formathata);
                        }
                        catch (Exception hata)
                        {
                            Console.WriteLine($"Beklenmeyen bir hata oluştu: {hata.Mesajı}");
                        }
                    }

                    notortalama = vizenotu * 0.40 + finalnotu * 0.60;
                    dizi[i + 1, 5] = notortalama.ToString();
                    ortalamatoplam[i] = notortalama;

                    if (notortalama >= 85) { dizi[i + 1, 6] = "AA"; }
                    else if (notortalama >= 75) { dizi[i + 1, 6] = "BA"; }
                    else if (notortalama >= 60) { dizi[i + 1, 6] = "BB"; }
                    else if (notortalama >= 50) { dizi[i + 1, 6] = "CB"; }
                    else if (notortalama >= 40) { dizi[i + 1, 6] = "CC"; }
                    else if (notortalama >= 30) { dizi[i + 1, 6] = "DC"; }
                    else if (notortalama >= 20) { dizi[i + 1, 6] = "DD"; }
                    else if (notortalama >= 10) { dizi[i + 1, 6] = "FD"; }
                    else { dizi[i + 1, 6] = "FF"; }

                    Console.WriteLine(" ");
                }

                enkucuk = ortalamaToplam.Min();
                enbuyuk = ortalamaToplam.Max();
                sinifnotortalama = ortalamatoplam.Average();

                for (int i = 0; i < ogrencisayisi + 1; i++)
                {
                    for (int j = 0; l < tablobaslik.Length; l++)
                    {
                        Console.Write(dizi[i, l] + " ");
                    }
                    Console.WriteLine(" ");
                }

                Console.WriteLine($"\nSınıf Ortalaması: {sinifnotortalama}\nEn Düşük Not: {enkucuk}\nEn Yüksek Not: {enbuyuk}");
            }
            catch (FormatException)
            {
                Console.WriteLine(formathata);
            }
            catch (OverflowException)
            {
                Console.WriteLine(overflowhata);
            }
            catch (Exception hata)
            {
                Console.WriteLine($"Beklenmeyen bir hata oluştu: {hata.Mesajı}");
            }
        }
    }
}