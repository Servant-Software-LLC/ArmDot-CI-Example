[assembly: ArmDot.Client.VirtualizeCode(Enable = false)]
[assembly: ArmDot.Client.ObfuscateControlFlow(Enable = true)]
[assembly: ArmDot.Client.ObfuscateNames(Enable = true)]
[assembly: ArmDot.Client.ObfuscateNamespaces(Enable = true)]

namespace MyTestLibrary;

public class Class1
{
    public double SecretSauce() => SecretSauceInternal();

    private double SecretSauceInternal() => Math.Sqrt(64) + 777;
}