using HerancaComposicao.Entities;
using HerancaComposicao.Enums;
using System;

namespace HerancaComposicao
{
    public class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Department("Design");

            var level = "MidLevel";
            var bs = 1200.00;
            var h1 = new HourContract(new DateTime(2018, 08, 20), 50.00, 20);
            var h2 = new HourContract(new DateTime(2018, 06, 13), 30.00, 18);
            var h3 = new HourContract(new DateTime(2018, 08, 25), 80.00, 10);

            var w1 = new Worker("Alex", Enum.Parse<WorkerLevel>(level.ToUpper()), bs, d1);

            w1.addContract(h1);
            w1.addContract(h2);
            w1.addContract(h3);

            var data = DateTime.Parse("08/2018");
            Console.WriteLine(w1.income(data.Year, data.Month));
        }
    }
}
