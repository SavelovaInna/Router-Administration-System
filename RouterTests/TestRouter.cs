using System;
using NUnit.Framework;
using lab3;

namespace RouterTests
{
    [TestFixture]
    public class TestRouter
    {
        Router router;
        InterfaceRouterParametrsServise parametrServise;
        InterfaceRoutingTable routingTable;
        [SetUp]
        public void Before()
        {
            parametrServise = new TestRouterParametrServise();
            routingTable = new TestRoutingTable();
            router = new Router(parametrServise, routingTable);
            router.Load();
        }
        [Test]
        public void TestReset()
        {
            router.Reset();
            Assert.AreSame(((TestRouterParametrServise)parametrServise).mac.Value, "00-00-00-00-00-00");
            Assert.AreSame(((TestRouterParametrServise)parametrServise).interfaces[0].Settings["ip"].Value, "");
            Assert.AreEqual(((TestRoutingTable)routingTable).table.Count, 0);
        }
        [Test]
        public void TestGetMac()
        {
            Assert.AreNotSame(router.GetMac(), null);
        }
        [Test]
        public void TestSetMac()
        {
            router.SetMac("45-45-45-45-45-45");
            Assert.AreSame(((TestRouterParametrServise)parametrServise).mac.Value, "45-45-45-45-45-45");
        }
        [Test]
        public void TestGetInterfases()
        {
            Assert.NotNull(router.GetInterfaces());
        }
        [Test]
        public void TestSaveInterface()
        {
            NetInterface netInterface = router.GetInterfaces()[0];
            netInterface.ChangeSetting("ip", "192.168.2.2");
            netInterface.ChangeSetting("mac", "23-23-23-23-23-23-23");
            router.SaveInterface(netInterface);
            Assert.AreSame(((TestRouterParametrServise)parametrServise).interfaces[0].Settings["ip"].Value,
                "192.168.2.2");
            Assert.AreSame(((TestRouterParametrServise)parametrServise).interfaces[0].Settings["mac"].Value,
               "23-23-23-23-23-23-23");
        }
        [Test]
        public void TestGetRoutingTable()
        {
            Query query = new DestQuery("192.168.1.1");
            Assert.AreEqual(router.GetRoutingTable(query).Count,1);
            query = new DestQuery("5.5.5.5");
            Assert.AreEqual(router.GetRoutingTable(query).Count, 1);
        }
        [Test]
        public void TestAddRoutingRecord()
        {
            RoutingRecord record = new RoutingRecord();
            record.SetParameters("192.168.1.2", "255.255.255.0", "3.3.3.3", 12);
            router.AddRoutingRecord(record);
            Assert.AreEqual(((TestRoutingTable)routingTable).table.Count, 3);
        }
        [Test]
        public void TestDelRoutingRecord()
        {
            RoutingRecord record = new RoutingRecord();
            record.SetParameters("5.5.5.5", "255.0.0.0", "2.2.2.2", 7);
            router.DeleteRoutingRecord(record);
            Assert.AreEqual(((TestRoutingTable)routingTable).table.Count, 1);
        }
        
    }
}
