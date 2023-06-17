
using BtkAkademi.Models;

namespace BtkAkademi
{
    public static class Repository
    {
        private static List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications =>applications; //veri listelemek için çağrılacak

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
    
}