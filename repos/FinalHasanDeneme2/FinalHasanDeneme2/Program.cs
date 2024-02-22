/*class KrediHesabi
{
    public ulong HesapNo;
    public double Limit;
    public string KartSahibi;

}

class dortgen
{
    private string isim;
    public int en;
    public int boy;
    private int En;
    private int Boy;

    public string misim
    {
        get
        {
            return isim;
        }
        set
        {
            isim = value.ToUpper();
        }
    }
    public int mEn
    {
        get
        {
            return En;
        }
        set
        {
            if (value < 1)
            {
                En = 0;
            }
            else
            {
                En = value;
            }
        }
    }
    public int mBoy
    {
        get
        {
            return Boy;
        }
        set
        {
            if (value < 1)
            {
                Boy = 0;
            }
            else
            {
                Boy = value;
            }
        }
    }
    public void EnBoyBelirle(int en, int boy)
    {
        if (en < 0 || boy < 0)
        {
            mEn = 0;
            mBoy = 0;
        }
        else
        {
            this.mEn = en;
            this.mBoy = boy;
        }
    }
    public int alan()
    {
        int sonuc = mEn * mBoy;
        return sonuc;
    }
    public void yaz()
    {
        Console.WriteLine("İsim: {0}", misim);
        Console.WriteLine("En: {0,5}", mEn);
        Console.WriteLine("Boy: {0}", mBoy);
        Console.WriteLine("Alan: {0}", alan());
    }
}
    dortgen d1 = new dortgen();
    d1.boy = 30;
    d1.en = 10;
    d1.mEn = 10;
    d1.mBoy = 30;
    d1.misim = "Dikdörtgen";
    Console.WriteLine(d1.mBoy);
    d1.yaz();
    Console.WriteLine("***********");
    dortgen d2 = new dortgen();
    d2.EnBoyBelirle(100, 50);
    d2.yaz();*/

int a = 10;
byte b = Convert.ToByte(a);
Console.WriteLine(b);