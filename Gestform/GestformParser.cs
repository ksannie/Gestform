namespace Gestform;

public class GestformParser
{ 
    public bool TryParse(string stringToParse, out List<int> parsedNumbers)
    {
        parsedNumbers = new List<int>();
        
        List<string> numbersAsString = stringToParse.Split(',').ToList();
      
            foreach (var s in numbersAsString)
            {
                if (!int.TryParse(s, out var n) || (n > 1000 || n < -1000))
                {
                    parsedNumbers.Clear();
                    return false;
                }
                parsedNumbers.Add(n);
            }
            return true;
    }
}