using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

List<Type> types = new()
{
    typeof(sbyte),
    typeof(byte),
    typeof(short),
    typeof(ushort),
    typeof(int),
    typeof(uint),
    typeof(long),
    typeof(ulong),
    /*typeof(Int128),
    typeof(UInt128),
    typeof(Half),*/
    typeof(float),
    typeof(double),
    typeof(decimal)
};

WriteLine(new string('-', 86));
WriteLine($"{"Type",-8}{"Byte(s) of memory",-10}{"Min",23}{"Max",38}");
WriteLine(new string('-', 86));
foreach (Type type in types)
{
    Write($"{type.Name.ToLower(),-8}");
    Write($"{Marshal.SizeOf(type).ToString(), -10}");
    Write($"{type.GetField("MinValue").GetValue(null).ToString(),30}");
    WriteLine($"{type.GetField("MaxValue").GetValue(null).ToString(),38}");
}
WriteLine(new string('-', 86));
