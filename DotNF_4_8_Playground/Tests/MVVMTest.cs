using DotNF_4_8_Playground.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class MVVMTest : ITestable
    {
        public void Test(TestContext context)
        {
            var view = new View();

            view.UpdateNameButtonClick();
            Console.WriteLine(view.Name);

            view.UpdateNameButtonClick();
            Console.WriteLine(view.Name);
        }
    }

    public class View
    {
        private IViewModel viewModel = new ViewModel();
        public string Name { get; set; }

        public View()
        {
            viewModel.NameUpdated += (sender, name) => Name = name;
        }

        public void UpdateNameButtonClick()
        {
            viewModel.UpdateName();
        }
    }

    public class ViewModel : IViewModel
    {
        public IModel model = new Model1();
        public EventHandler<string> NameUpdated { get; set; }

        public ViewModel()
        {
            model.NameUpdated += (sender, name) => NameUpdated?.Invoke(this, name);
        }

        public void UpdateName()
        {
            model.UpdateName();
        }
    }

    public class Model1 : IModel
    {
        public EventHandler<string> NameUpdated { get; set; }
        public static string[] _names = { "james", "jon", "kim", "tesla", "albert" };
        public int _index = new Random().Next(0, _names.Length);

        public void UpdateName()
        {
            _index++;
            if (_index >= _names.Length) _index = 0;
            NameUpdated?.Invoke(this, _names[_index]);
        }
    }

    public class Model : IModel
    {
        public EventHandler<string> NameUpdated { get; set; }
        private string[] _names = new string[] { "홍길동", "이순신", "유관순", "안중근", "전우치" };
        private int _index = 0;

        public void UpdateName()
        {
            _index++;
            if (_index >= _names.Length) _index = 0;

            NameUpdated?.Invoke(this, _names[_index]);
        }
    }

    public interface IModel
    {
        EventHandler<string> NameUpdated { get; set; }

        void UpdateName();
    }

    public interface IViewModel
    {
        EventHandler<string> NameUpdated { get; set; }

        void UpdateName();
    }
}
