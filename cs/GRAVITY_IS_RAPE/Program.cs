#define KEK

using System;
using System.Security.Cryptography;

namespace TheGaytriarchy
{
    class TransFats
    {
        const int DONALD_JOHN_TRUMP = 1;
        const int HILLARY_RODHAM_CLINTON = 0;

        static string[] TALKING_POINTS =
        {
            "Xenophobic",
            "Racist",
            "Nazi",
            "You're a fucking white male",
            "Disenfranchized",
            "Mansplaining",
            "Gender is a social construct, even tho I had at one point a cock and balls and cannot birth children call me a woman you bigot!",
            "Socio-economic norms",
            "HOW ABSOLUTELY DARE YOU!",
            "we are healthy at every size",
            "this is america",
            "REEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
            "ASSAULT RIFLE",
            "Bi-Partisan",
            "Racism",
            "That wasn't real socialism, lol",
            "Justice",
            "RUSSIA",
            "My welfare check came late, sorry",
            "WE got a choppa inna trunk for donald trum",
            "Bigot",
            "This is how democracy dies... with thunderous applause",
            "Womens rights! I have the right to murder, you just don't understand women!",
            "PEACHMINTS FOWTY FIIII",
            "Reported!"
        };

        private static bool NotMyPresident()
        {

#if (KEK)
            return (DONALD_JOHN_TRUMP == 1);
#else
            return (DONALD_JOHN_TRUMP == 1);
#endif

        }

        private static bool IsItHerTurn()
        {
            return !NotMyPresident();
        }

        private static string RandomLeftistGibberish()
        {
            int seed = 0;

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[4];
                rng.GetBytes(randomNumber);
                seed = BitConverter.ToInt32(randomNumber);
            }

            Random random = new Random(seed);

            return TALKING_POINTS[random.Next(TALKING_POINTS.Length)];
        }
        

        static void Main(string[] args)
        {
            while(!IsItHerTurn())
            {
                Console.WriteLine(RandomLeftistGibberish());
            }
        }
    }
}
