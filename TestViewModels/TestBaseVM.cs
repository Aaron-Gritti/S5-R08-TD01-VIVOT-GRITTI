using ViewModels;

namespace TestViewModels
{
    class FakeVM : BaseVM
    {
        public void Test()
        {
            NotifyPropChanged("Toto");
        }
    }

    public class TestBaseVM
    {
        private string? lastPropertyChanged;
        
        [Fact]
        public void TestNotify()
        {
            FakeVM vM = new FakeVM();
            vM.PropertyChanged += VM_PropertyChanged;
            vM.Test();
            Assert.Equal("Toto", lastPropertyChanged);
        }

        private void VM_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            lastPropertyChanged = e.PropertyName;
        }
    }
}