namespace FurnitureFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFurnitureFactory chairFactory = new ChairFactory();
            IFurnitureFactory tableFactory = new TableFactory();
            IFurnitureFactory sofaFactory = new SofaFactory();

            FurnitureClient client1 = new FurnitureClient(chairFactory);
            client1.CreateAndAssembleFurniture();

            FurnitureClient client2 = new FurnitureClient(tableFactory);
            client2.CreateAndAssembleFurniture();

            FurnitureClient client3 = new FurnitureClient(sofaFactory);
            client3.CreateAndAssembleFurniture();

           

        }
    }
}