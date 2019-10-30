using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

public class domain : SmartContract
{
    public static void Main()
    {
        Storage.Put(Storage.CurrentContext, "Hello", "World");
    }
}
