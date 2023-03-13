public class Example
{
    public static void Main()
    {
        // Create the link list.
        string[] family =
            { "Peter", "Louis", "Meg", "Stewie", "Chris"};
        LinkedList<string> familyList = new LinkedList<string>(family);
        Console.WriteLine("Griffin Family:");
        foreach (string familyMem in familyList)
        {
            Console.WriteLine(familyMem);
        }
        Console.WriteLine();

        Console.WriteLine("The first family member in the list is: {0}", familyList.First.Value);
        Console.WriteLine("The last family member in the list is: {0}", familyList.Last.Value);
        Console.WriteLine();

        
        LinkedListNode<string> targetLocation = familyList.Find("Louis");
        familyList.AddAfter(targetLocation, "Brian");
        Console.WriteLine("Full Griffin Family");
        foreach (string familyMem in familyList)
        {
            Console.WriteLine(familyMem);
        }
        Console.WriteLine();
        
        familyList.RemoveLast();

        Console.WriteLine("Updated Griffin Family");
        Console.WriteLine("There are now {0} members in the Griffin family.", familyList.Count);
        foreach (string familyMem in familyList)
        {
            Console.WriteLine(familyMem);
        }
    }

}