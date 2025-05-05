static bool ArrayDuplicates(int[] myarr)
{
    Dictionary<int, int> duplicates = new Dictionary<int, int>();
    for (int i = 0; i < myarr.Length; i++)
    {
        if (duplicates.ContainsKey(myarr[i]))
        {
            return true;
        }
        else
        {
            duplicates[myarr[i]] = 1;
        }
    }
    return false;
}

Console.WriteLine(ArrayDuplicates([1,2,3,4]));
Console.WriteLine(ArrayDuplicates([1,4,3,3,6,8,9]));