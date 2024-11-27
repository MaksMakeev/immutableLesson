using System.Collections.Immutable;

namespace immutableLesson
{
    internal class Part
    {
        public List<string> Poem { get; set; }
        public ImmutableList<string> PoemPart { get; set; }
        public Part(ImmutableList<string> poemPart)
        {
            PoemPart = poemPart;
            Poem = new List<string>();
        }
        public void AddPart(List<string> poemStrings)
        {
            foreach (string poemString in PoemPart)
            {
                poemStrings.Add(poemString);
            }
            Poem = poemStrings;
        }

    }
}

