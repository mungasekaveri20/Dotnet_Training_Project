using System;

class value_ref
{
    static void Main()
    {
        int valueTypeVar = 10;
        Console.WriteLine("Value type before method call: " + valueTypeVar);
        ChangeValueType(valueTypeVar);
        Console.WriteLine("Value type after method call: " + valueTypeVar);

        int[] referenceTypeVar = { 10 };
        Console.WriteLine("Reference type before method call: " + referenceTypeVar[0]);
        ChangeReferenceType(referenceTypeVar);
        Console.WriteLine("Reference type after method call: " + referenceTypeVar[0]);
    }

    static void ChangeValueType(int value)
    {
        value = 20;
    }

    static void ChangeReferenceType(int[] reference)
    {
        reference[0] = 20;
    }
}
