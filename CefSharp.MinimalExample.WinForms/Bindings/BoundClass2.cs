namespace CefSharp.MinimalExample.WinForms
{
    public class BoundClass2 : IBoundClass
    {
        public string StringProperty => nameof(BoundClass2);

        public string StringMethod()
        {
            return nameof(BoundClass2);
        }
    }
}