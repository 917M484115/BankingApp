using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade {
    public abstract class FactoryBaseTests<TFactory, TData, TObject, TView> : SealedClassTests<AbstractViewFactory<TData, TObject, TView>>
        where TFactory : AbstractViewFactory<TData, TObject, TView>, new()
        where TData : PeriodData, new()
        where TView : PeriodView, new()
        where TObject : IEntity<TData> {
        protected virtual string[] excludeProperties => System.Array.Empty<string>();
        [TestMethod] public void CreateTest() { }
        [TestMethod] public void CreateObjectTest() {
            var v = random<TView>();
            doBeforeCreateObjectTest(v);
            var o = (obj as TFactory).Create(v);
            areEqualProperties(v, o.Data, excludeProperties);
            doAfterCreateObjectTest(v, o);
        }
        [TestMethod] public void CreateViewTest() {
            var d = random<TData>();
            doBeforeCreateViewTest(d);
            var o = createObject(d);
            var v = (obj as TFactory).Create(o);
            areEqualProperties(d, v, excludeProperties);
            doAfterCreateViewTest(o, v);
        }
        protected virtual void doAfterCreateViewTest(TObject o, TView v) {}
        protected virtual void doAfterCreateObjectTest(TView v, TObject o) {}
        protected virtual void doBeforeCreateViewTest(TData d) { }
        protected virtual void doBeforeCreateObjectTest(TView v) { }
        protected abstract TObject createObject(TData d);
    }
}
