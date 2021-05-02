using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsConsole.Logic.Behavioral;
using DesignPatternsConsole.Logic.Creational;
using DesignPatternsConsole.Logic.Structural;

namespace DesignPatternsConsole.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDecoratorExample()
        {
            var pattern = new DecoratorPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestProxyExample()
        {
            var pattern = new ProxyPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestBridgeExample()
        {
            var pattern = new BridgePattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestCompositeExample()
        {
            var pattern = new CompositePattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestFlyweightExample()
        {
            var pattern = new FlyweightPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestAdapterExample()
        {
            var pattern = new AdapterPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestFacadeExample()
        {
            var pattern = new FacadePattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestPrototypeExample()
        {
            var pattern = new PrototypePattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestFactoryMethodExample()
        {
            var pattern = new FactoryMethodPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestSingletonExample()
        {
            var pattern = new SingletonPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestAbstractFactoryExample()
        {
            var pattern = new AbstractFactoryPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestBuilderExample()
        {
            var pattern = new BuilderPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestStrategyExample()
        {
            var pattern = new StrategyPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestStateExample()
        {
            var pattern = new StatePattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestTemplateMethodExample()
        {
            var pattern = new TemplateMethodPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestChainOfResponsibilityExample()
        {
            var pattern = new ChainOfResponsibilityPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestCommandExample()
        {
            var pattern = new CommandPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestIteratorExample()
        {
            var pattern = new IteratorPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestMediatorExample()
        {
            var pattern = new MediatorPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestObserverExample()
        {
            var pattern = new ObserverPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestVisitorExample()
        {
            var pattern = new VisitorPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestInterpreterExample()
        {
            var pattern = new InterpreterPattern();
            pattern.RunExample();
        }

        [TestMethod]
        public void TestMementoExample()
        {
            var pattern = new MementoPattern();
            pattern.RunExample();
        }
    }
}
