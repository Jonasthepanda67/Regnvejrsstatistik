namespace RVS
{
    internal class program
    {
        static void Main(string[] args)
        {
            double[] nedbøruge = new double[7];

            Console.Write("Indtast nedbør for mandag her: ");
            nedbøruge[0] = double.Parse(Console.ReadLine());
            Console.Write("Indtast nedbør for tirsdag her: ");
            nedbøruge[1] = double.Parse(Console.ReadLine());
            Console.Write("Indtast nedbør for onsdag her: ");
            nedbøruge[2] = double.Parse(Console.ReadLine());
            Console.Write("Indtast nedbør for torsdag her: ");
            nedbøruge[3] = double.Parse(Console.ReadLine());
            Console.Write("Indtast nedbør for fredag her: ");
            nedbøruge[4] = double.Parse(Console.ReadLine());
            Console.Write("Indtast nedbør for lørdag her: ");
            nedbøruge[5] = double.Parse(Console.ReadLine());
            Console.Write("Indtast nedbør for søndag her: ");
            nedbøruge[6] = double.Parse(Console.ReadLine());
            Console.Clear();
            for (var i = 0; i < 7; i++)
            {
                int l = i + 1;
                Console.WriteLine("-     Nedbør værdi {0} = {1} mm", l, nedbøruge[i]);
            }
            double ave = nedbøruge.Average();
            Console.WriteLine("\nGennemsnittet er: {0}", Math.Round(ave, 2));
            Console.WriteLine("Den laveste værdi er: {0}", nedbøruge.Min());
            Console.WriteLine("Den største værdi er: {0}", nedbøruge.Max());
        }
    }
}