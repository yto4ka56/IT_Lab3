namespace IT_LAB3;
using System.Numerics;

public class Cipher
{
    public static BigInteger p, q, b;

    public static BigInteger[] plaintext, ciphertext; 

    public static void Encrypt()
    {
        BigInteger n = p * q;
        ciphertext = new BigInteger[plaintext.Length];

        for (int i = 0; i < plaintext.Length; i++)
        {
            BigInteger m = plaintext[i];
            ciphertext[i] = m * (m + b) % n;
        }
    }

    public static void Decrypt()
    {
        BigInteger n = p * q;
        ciphertext = new BigInteger[plaintext.Length];

        for (int i = 0; i < plaintext.Length; i++)
        {
            BigInteger c = plaintext[i];
            BigInteger D = (b * b + 4 * c) % n;

            BigInteger mp = Algorithms.FastPow(D, (p + 1) / 4, p);
            BigInteger mq = Algorithms.FastPow(D, (q + 1) / 4, q);

            (BigInteger yp, BigInteger yq) = Algorithms.ExtendedEuclidean(p, q);

            BigInteger[] d = new BigInteger[4];
            d[0] = (yp * p * mq + yq * q * mp) % n;
            if (d[0] < 0) { d[0] += n; }
            d[1] = n - d[0];
            d[2] = (yp * p * mq - yq * q * mp) % n;
            if (d[2] < 0) { d[2] += n; }
            d[3] = n - d[2];

            BigInteger[] m = new BigInteger[4];
            for (int j = 0; j < 4; j++)
            {
                m[j] = ((d[j] - b + ((d[j] - b) % 2 != 0 ? n : 0)) / 2) % n;
                if (m[j] < 0) { m[j] += n; }
                if (m[j] < 256)
                {
                    ciphertext[i] = m[j];
                    break;
                }
            }
        }
    }
}