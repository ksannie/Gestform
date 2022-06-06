namespace Gestform;

public class GestformRunner
{
    public void Run(List<int> values)
    {
        for (int i = 0; i < values!.Count; i++)
        {
            string result;
            if (values[i] % 3 == 0 && values[i] % 5 == 0)
            {
                result = "Gestform";
            }
            else if (values[i] % 3 == 0)
            {
                result = "Geste";
            }
            else if (values[i] % 5 == 0)
            {
                result = "Forme";
            }
            else
            {
                result = values[i].ToString();
            }

            Console.WriteLine(result);
        }
    }
}

