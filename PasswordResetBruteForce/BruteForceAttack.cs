using System;
using System.Text;
using System.Threading.Tasks;

public static class BruteForceAttack
{
    private static readonly char[] Characters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

    public static (string, TimeSpan) BruteForcePassword(string EnPassword,string Password, int maxThreads)
    {
        var startTime = DateTime.Now;
        string foundPassword = null;

        ParallelOptions parallelOptions = new ParallelOptions
        {
            MaxDegreeOfParallelism = maxThreads
        };

        Parallel.ForEach(Characters, parallelOptions, (character, state) =>
        {
            var result = BruteForceRecursive(EnPassword,Password, character.ToString(), 3); // Max length 3 for demo
            if (result != null)
            {
                foundPassword = result;
                state.Stop();
            }
        });

        var executionTime = DateTime.Now - startTime;
        return (foundPassword, executionTime);
    }

    private static string BruteForceRecursive(string EnPassword,string Password, string currentGuess, int maxLength)
    {
        if (currentGuess.Length > maxLength)
            return null;

        if (PasswordManager.EncryptPassword(Password,currentGuess) == EnPassword)
            return currentGuess;

        foreach (var character in Characters)
        {
            var result = BruteForceRecursive(EnPassword,Password, currentGuess + character, maxLength);
            if (result != null)
                return result;
        }

        return null;
    }
}
