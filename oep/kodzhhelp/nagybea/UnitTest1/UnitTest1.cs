using nagybea;
namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            static void NumberOfCarnivoresTest()
            {
                Wildlife wl = new Wildlife();
                Colony owl = new Colony("owl", 2, new Owl());
                Colony fox = new Colony("fox", 1, new Fox());
                Colony bear = new Colony("bear", 1, new Bear());
                wl.colonies.Add(owl);
                wl.colonies.Add(fox);
                wl.colonies.Add(bear);
                Assert.AreEqual(4, wl.GetNumberOfCarnivores());
            }
            NumberOfCarnivoresTest();

            [TestMethod]
            static void AreAllCarnivoresUnderFourTest()
            {
                Wildlife wl = new Wildlife();
                Colony owl = new Colony("owl", 3, new Owl());
                Colony fox = new Colony("fox", 3, new Fox());
                Colony bear = new Colony("bear", 2, new Bear());
                wl.colonies.Add(owl);
                wl.colonies.Add(fox);
                wl.colonies.Add(bear);
                Assert.IsTrue(wl.AreAllCarnivoresUnderFour());

                Colony lemming = new Colony("lemming", 30, new Lemming());
                wl.colonies.Add(lemming);
                Assert.IsTrue(wl.AreAllCarnivoresUnderFour());

                Colony fox1 = new Colony("fox1", 9, new Fox());
                wl.colonies.Add(fox1);
                Assert.IsFalse(wl.AreAllCarnivoresUnderFour());
            }
            AreAllCarnivoresUnderFourTest();

            [TestMethod]
            static void GetExtinctAnimalTest()
            {
                Wildlife wl = new Wildlife();
                Colony bear = new Colony("bear", 0, new Bear());
                Colony bear1 = new Colony("bear1", 0, new Bear());
                Colony fox = new Colony("fox", 8, new Fox());
                wl.colonies.Add(bear);
                wl.colonies.Add(bear1);
                wl.colonies.Add(fox);

                Assert.AreEqual(2, wl.GetExtinctAnimals().Count);

                wl.colonies.Add(new Colony("rabbit", 0, new Rabbit()));

                Assert.AreEqual(3, wl.GetExtinctAnimals().Count);

            }
            GetExtinctAnimalTest();

            [TestMethod]
            static void ReproductionTest()
            {
                Wildlife wl = new Wildlife();
                Colony owl = new Colony("owl", 10, new Owl());
                Colony fox = new Colony("fox", 10, new Fox());
                Colony bear = new Colony("bear", 10, new Bear());
                Colony lemming = new Colony("lemming", 10, new Lemming());
                Colony lemming1 = new Colony("lemming1", 210, new Lemming());
                Colony rabbit = new Colony("rabbit", 10, new Rabbit());
                Colony rabbit1 = new Colony("rabbit1", 210, new Rabbit());
                Colony moose = new Colony("moose", 10, new Moose());
                Colony moose1 = new Colony("moose", 210, new Moose());

                wl.colonies.Add(owl);
                wl.colonies.Add(fox);
                wl.colonies.Add(bear);
                wl.colonies.Add(lemming);
                wl.colonies.Add(lemming1);
                wl.colonies.Add(rabbit);
                wl.colonies.Add(rabbit1);
                wl.colonies.Add(moose);
                wl.colonies.Add(moose1);


                owl.Reproduction(3);
                owl.Reproduction(13);
                fox.Reproduction(3);
                fox.Reproduction(13);
                bear.Reproduction(8);
                bear.Reproduction(18);
                lemming.Reproduction(2);
                lemming.Reproduction(1);
                rabbit.Reproduction(2);
                rabbit.Reproduction(1);
                moose.Reproduction(4);
                moose.Reproduction(14);

                lemming1.Reproduction(2);
                rabbit1.Reproduction(2);
                moose1.Reproduction(4);

                Assert.AreEqual(14, owl.population);
                Assert.AreEqual(16, fox.population);
                Assert.AreEqual(12, bear.population);
                Assert.AreEqual(20, lemming.population);
                Assert.AreEqual(15, rabbit.population);
                Assert.AreEqual(12, moose.population);

                Assert.AreEqual(30, lemming1.population);
                Assert.AreEqual(20, rabbit1.population);
                Assert.AreEqual(40, moose1.population);
            }
            ReproductionTest();

            [TestMethod]
            static void AttackTest()
            {
                Wildlife wl = new Wildlife();
                Colony owl = new Colony("owl", 100, new Owl());
                Colony fox = new Colony("fox", 100, new Fox());
                Colony bear = new Colony("bear", 100, new Bear());
                Colony lemming = new Colony("lemming", 100, new Lemming());
                Colony rabbit = new Colony("rabbit", 100, new Rabbit());
                Colony moose = new Colony("moose", 100, new Moose());
                wl.colonies.Add(owl);
                wl.colonies.Add(fox);
                wl.colonies.Add(bear);
                wl.colonies.Add(lemming);
                wl.colonies.Add(rabbit);
                wl.colonies.Add(moose);
                owl.Attack(lemming);
                Assert.AreEqual(15, owl.population);
                Assert.AreEqual(70, lemming.population);
                owl.Attack(rabbit);
                Assert.AreEqual(15, owl.population);
                Assert.AreEqual(80, rabbit.population);
                owl.Attack(moose);
                Assert.AreEqual(0, owl.population);
                Assert.AreEqual(100, moose.population);

                fox.Attack(lemming);
                Assert.AreEqual(0, fox.population);
                Assert.AreEqual(66, lemming.population);
                fox.Attack(rabbit);
                Assert.AreEqual(0, fox.population);
                Assert.AreEqual(52, rabbit.population);
                fox.Attack(moose);
                Assert.AreEqual(0, fox.population);
                Assert.AreEqual(100, moose.population);

                bear.Attack(moose);
                Assert.AreEqual(75, moose.population);
                Assert.AreEqual(50, bear.population);
            }
            AttackTest();
        }
    }
}