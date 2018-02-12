using System.Threading.Tasks;

namespace CefSharp.MinimalExample.WinForms
{
    public class BoundClass1 : IBoundClass
    {
        public string StringProperty => nameof(BoundClass1);

        public BoundClass2 ObjectProperty => new BoundClass2();

        public string StringMethod()
        {
            return nameof(BoundClass1);
        }

        public BoundClass2 ObjectMethod()
        {
            return new BoundClass2();
        }
    }
}