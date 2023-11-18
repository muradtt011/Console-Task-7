// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Main(string[] args)
    {
        Task1();
    }
    static void Task1()
    {
        /* Verilmish metnde { a}  simvolun sayi { b} simvolun sayinda nece defe coxdur? */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        Console.WriteLine("Simvollari daxil edin");

        char[] element = new char[2];
        for (int i = 0; i < element.Length; i++)
        {
            Console.Write($"simvol[{i + 1}]: ");
            element[i] = Convert.ToChar(Console.ReadLine());
        }
        int count = 0;
        int count1 = 0;
        for (int i = 0; i < metn.Length; i++)
        {
            if (metn[i] == element[0])
            {
                count++;

            }
            if (metn[i] == element[1])
            {
                count1++;
            }


        }
        Console.WriteLine($"{element[0]}  {count}");
        Console.WriteLine($"{element[1]}  {count1}");

    }

    static void Task2()
    {
    /* Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi { a}
    simvoludurmu ? */

    l1:
        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(metn))
        {
            goto l1;
        }
        Console.Write("Herf daxil edin: ");
        string herf = Console.ReadLine();

        bool simvoludur = false;

        for (int i = 0; i < metn.Length; i++)
        {
            if (i % 2 == 0 && metn[i] == herf[0])
            {
                Console.WriteLine("Beli");
                simvoludur = true;
                break;
            }
        }
        if (!simvoludur)
        {
            Console.WriteLine("xeyr");
        }

    }

    static void Task3()
    {
    /* Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b} -ye beraberdir. */

    l1:
        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(metn))
        {
            goto l1;
        }
        Console.Write("Herf daxil edin: ");
        string herf = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < metn.Length; i++)
        {
            if (i % 2 == 0 && metn[i].ToString() == herf)
            {
                Console.WriteLine(metn[i]);
                count++;
            }

        }
        Console.WriteLine(count);

    }

    static void Task4()
    {
        /* Verilmish metnde sol terefden ilk rast gelinen { a}
        simvolunun yeri tek ededdi yoxsa cut ? */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        Console.Write("Simvol daxil edin: ");
        string simvol = Console.ReadLine();
        int indeks = metn.IndexOf(simvol);
        if (indeks >= 0)
        {

            if (indeks % 2 == 0)
            {
                Console.WriteLine("Tek yerdedir");
            }
            else
            {
                Console.WriteLine("Cut");
            }
        }
        else
        {
            Console.WriteLine("Yoxdur");
        }

    }

    static void Task5()
    {
        /* Verilmish metnde sol terefden saydiqda { a},{ b},{ c}
        simollarindan hansi birinci gelir? */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        Console.Write("Simvol daxil edin: ");

        char[] element = new char[3];
        for (int i = 0; i < element.Length; i++)
        {
            Console.Write($"element[{i + 1}]: ");
            element[i] = Convert.ToChar(Console.ReadLine());
        }
        int index = metn.IndexOfAny(element);
        if (index == -1)
        {
            Console.WriteLine("yoxdur");
        }
        else
        {
            Console.WriteLine($"{metn[index]} birinci gelir");
        }

    }

    static void Task6()
    {
        /* Verilmish metnde { a} simvolunun sol terefden ve sag terefden indexleri eydidirmi? */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        Console.Write("Simvol daxil edin: ");
        string simvol = Console.ReadLine();
        int indeks = metn.IndexOf(simvol);
        int index2 = metn.LastIndexOf(simvol);
        int abc = (metn.Length - index2) - 1;

        if (abc == indeks)
        {
            Console.WriteLine("Eynidir");
        }
        else
        {
            Console.WriteLine("Eyni deyil");
        }

    }

    static void Task7()
    {
        /* Verilmish metnde { a} simvolu { b} simvolundan qabaq ve oda { c} simvolundan qabaq gelirmi ? */

        Console.WriteLine("Metn daxil edin");
        string metn = Console.ReadLine();
        char[] simvol = new char[3];
        for (int i = 0; i < simvol.Length; i++)
        {
            simvol[i] = Convert.ToChar(Console.ReadLine());
        }
        int indexA = metn.IndexOf(simvol[0]);
        int indexB = metn.IndexOf(simvol[1]);
        int indexC = metn.IndexOf(simvol[2]);
        if (indexA < indexB && indexB < indexC)
        {
            Console.WriteLine($"Metnde {simvol[0]} simvolu {simvol[1]} simvolundan qabaq ve oda {simvol[2]} simvolundan qabaq gəlir.");
        }
        else
        {
            Console.WriteLine($"Simvollar duzgun deyil");
        }

    }

    static void Task8()
    {
        /* Verilmish metnde ilk qabagima cixan { a}
        simvolundan sonra gelen simvolu 10 defe dalbadal cap et. */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        Console.WriteLine("Simvol daxil edin");
        string simvol = Console.ReadLine();
        int index = metn.IndexOf(simvol) + 1;
        char next = metn[index];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(next);
        }

    }

    static void Task9()
    {
        /* Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.? */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();

        if (!string.IsNullOrEmpty(metn))
        {
            string ilksimvollar = metn.Substring(0, 3);
            string sonuncular = metn.Substring(metn.Length - 3);
            char[] ters = sonuncular.ToCharArray();
            Array.Reverse(ters);
            string strSonUcSimvolTers = new string(ters);

            if (ilksimvollar == strSonUcSimvolTers)
            {
                Console.WriteLine("Bərabərdir");
            }
            else
            {
                Console.WriteLine("Bərabər deyil");
            }
        }
        else
        {
            Console.WriteLine("Metn daxil edin");
        }

    }

    static void Task11()
    {
        /* Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve
        eyni zamanda butun {b} simvollarinin qabagina {a} simvolunu yaz.  */

        Console.Write("Metn daxil edin: ");
        string strMetn = Console.ReadLine();

        Console.WriteLine("Simvollari daxil edin");
        char[] element = new char[2];

        for (int i = 0; i < element.Length; i++)
        {
            Console.Write($"simvol[{i + 1}]: ");
            element[i] = Convert.ToChar(Console.ReadLine());
        }
        int index = 0;
        while (true)
        {
            index = strMetn.IndexOfAny(element, index + 1);
            if (index == -1)
            {
                break;
            }
            if (strMetn[index] == element[0])
            {
                strMetn = strMetn.Insert(index, element[1].ToString());
            }
            else if (strMetn[index] == element[1])
            {
                strMetn = strMetn.Insert(index, element[0].ToString());
            }
            index++;
        }
        Console.WriteLine(strMetn);


    }

    static void Task12()
    {
        /* Verilmish metinde en ilk ve en son { a}
        simvolundan bashqa yerde qalan butun { a}
        simvollarini yox et. */

        Console.Write("Metn daxil edin: ");
        string metin = Console.ReadLine();

        Console.Write("Simvol daxil edin: ");
        string herf = Console.ReadLine();

        int firstIndex = metin.IndexOf(herf);
        if (firstIndex == -1)
        {
            Console.WriteLine("Simvol yoxdur");
            return;
        }

        int lastINdex = metin.LastIndexOf(herf);

        string partOne = metin.Substring(0, firstIndex + 1);

        string partTwo = metin.Substring(firstIndex + 1, lastINdex - firstIndex - 1);

        string partString = metin.Substring(lastINdex, metin.Length - lastINdex);
        //Console.WriteLine(partOne);
        //Console.WriteLine(partTwo);
        //Console.WriteLine(partString);
        partTwo = partTwo.Replace(herf, "");

        metin = string.Concat(partOne, partTwo, partString);
        Console.WriteLine(metin);

    }

    static void Task13()
    {
        /* Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();

        for (int i = 0; i < metn.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(Char.ToLower(metn[i]));
            }
            else
            {
                Console.Write(Char.ToUpper(metn[i]));
            }
        }
    }

    static void Task14()
    {
        /* Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et.*/

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();

        for (int i = 0; i < metn.Length - 1; i++)
        {

            if (i % 2 == 0)
            {
                char x = metn[i + 1];
                metn = metn.Remove(i, 1);
                metn = metn.Insert(i, x.ToString().ToUpper());
            }

        }

        Console.WriteLine(metn);
    }

    static void Task15()
    {
        /* Verilmish metinde ilk ve son simvol eynidirse,
           ve metn daxilinde yanashi gelen {a} simvolu varsa,
           ve metn daxilinde {b} simvolu yoxdursa
           o zaman bu metnde butun {c} simvollari yox et ve
           neticede alinan metn zerkalni olub olmadigini yoxla. */

        Console.Write("Metn daxil edin: ");
        string metn = Console.ReadLine();
        Console.WriteLine("Simvollari daxil edin");

        char[] element = new char[3];
        for (int i = 0; i < element.Length; i++)
        {
            Console.Write($"element[{i + 1}]: ");
            element[i] = Convert.ToChar(Console.ReadLine());
        }

        if (metn[0] == metn[metn.Length - 1])
        {
            if (metn.Contains(element[0].ToString()))
            {
                if (!metn.Contains(element[1].ToString()))
                {
                    metn = metn.Replace(element[2].ToString(), string.Empty);
                }
                else
                {
                    Console.WriteLine($"{element[1]} simvolu var");
                }
            }
            else
            {
                Console.WriteLine("yanasi gelen simvol yoxdur");
            }
        }
        else
        {
            Console.WriteLine("eyni deyil");
        }
        Console.WriteLine(metn);


    }
}