int Faktoriyel(int sayi)
{
    if (sayi == 0) return 1; else return sayi * Faktoriyel(sayi - 1);
}
