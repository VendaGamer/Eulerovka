using System.Diagnostics;

namespace Eulerovka;

public partial class OknikoPravdy : Form
{
    public OknikoPravdy()
    {
        InitializeComponent();
        long a = 200;
        var ab = Eulerada.EulerovaPrvocisla(a);
        foreach (var ok in ab)
        {
            Console.WriteLine(ok);
        }
    }
    
}