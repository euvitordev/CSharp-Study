namespace C_Sharp_Study.Algoritmos
{
    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;

            foreach (bool sheep in sheeps)
            {
                if (sheep == true) count++;
            }

            return count;
        }
    }
}
