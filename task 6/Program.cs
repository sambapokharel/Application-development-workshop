public class List
{
    public static void Main(string[] args)
    {
        List<string> fruits = new List<string>()
{
"Apple",
"Banana",
"Orange",
};
        // Add a new fruit to the list
        fruits.Add("Mango");
        //Removing 1 fruit from the list
        fruits.Remove("Banana");
        //Print all fruits in the list using foreach loop
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        //Dictionary of friuts
        Dictionary<int, string> fruitDict = new Dictionary<int, string>()
{
{1, "Apple"},
{2, "Orange"},
{3, "Mango"},
};
        // Add a new fruit to the dictionary
        fruitDict.Add(4, "Strawberry");
        //Print all key value pair
        foreach (KeyValuePair<int, string> kvp in fruitDict)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
    }
}