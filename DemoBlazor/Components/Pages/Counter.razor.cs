namespace DemoBlazor.Components.Pages
{
    public partial class Counter
    {
        public string name = "John Doe";
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}