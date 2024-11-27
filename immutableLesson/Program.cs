using System.Collections.Immutable;

namespace immutableLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var part1 = new List<string>() { "Вот дом,", "Который построил Джек." };
            var immutablePart1 = part1.ToImmutableList();
            var Part1 = new Part1(immutablePart1);

            var part2 = new List<string>() { "А это пшеница,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart2 = part2.ToImmutableList();
            var Part2 = new Part1(immutablePart2);

            var part3 = new List<string>() { "А это веселая птица-синица,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart3 = part3.ToImmutableList();
            var Part3 = new Part1(immutablePart3);

            var part4 = new List<string>() { "Вот кот,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart4 = part4.ToImmutableList();
            var Part4 = new Part1(immutablePart4);

            var part5 = new List<string>() { "Вот пес без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart5 = part5.ToImmutableList();
            var Part5 = new Part1(immutablePart5);

            var part6 = new List<string>() { "А это корова безрогая,", "Лягнувшая старого пса без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart6 = part6.ToImmutableList();
            var Part6 = new Part1(immutablePart6);

            var part7 = new List<string>() { "А это старушка, седая и строгая,", "Которая доит корову безрогую,", "Лягнувшую старого пса без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart7 = part7.ToImmutableList();
            var Part7 = new Part1(immutablePart7);

            var part8 = new List<string>() { "А это ленивый и толстый пастух,", "Который бранится с коровницей строгою,", "Которая доит корову безрогую,", "Лягнувшую старого пса без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart8 = part8.ToImmutableList();
            var Part8 = new Part1(immutablePart8);

            var part9 = new List<string>() { "Вот два петуха,", "Которые будят того пастуха,", "Который бранится с коровницей строгою,", "Которая доит корову безрогую,", "Лягнувшую старого пса без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится", "В доме,", "Который построил Джек." };
            var immutablePart9 = part9.ToImmutableList();
            var Part9 = new Part1(immutablePart9);

            Part2.AddPart(Part1.Poem);
            Part3.AddPart(Part2.Poem);
            Part4.AddPart(Part3.Poem);
            Part5.AddPart(Part4.Poem);
            Part6.AddPart(Part5.Poem);
            Part7.AddPart(Part6.Poem);
            Part8.AddPart(Part7.Poem);
            Part9.AddPart(Part8.Poem);

            foreach (string poemString in Part9.Poem) 
            {
                Console.WriteLine(poemString);
            }
        }
    }
}
