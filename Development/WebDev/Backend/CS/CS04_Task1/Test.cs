using System.Collections.Generic;

namespace CS04
{
    public class Test
    {
        public void runTest()
        {
            List<IFlyable> listIF = new List<IFlyable>();
            listIF.Add(new Airplane());
            listIF.Add(new Bird());
            listIF.Add(new Eagle());

            foreach (IFlyable itemIF in listIF)
            {
                itemIF.Fly();
            }
        }
    }
}