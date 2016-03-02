namespace ConsoleApplication2
{
    class Dontkniwadapter: DontKniw, ICanDoThis
    {
        private DontKniw dontknow;

        public Dontkniwadapter(DontKniw thisin)
        {
            this.dontknow = thisin;
        }

        public void dothis()
        {
            dontknow.cantdothis();
        }
    }
}