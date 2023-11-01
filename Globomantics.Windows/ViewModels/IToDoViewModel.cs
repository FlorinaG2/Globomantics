
using Globomantic.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Globomantics.Windows.ViewModels
{

    public class IToDoViewModel : IViewModel
    {
        #region Public
        public Action<string>? ShowAlert { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action<string>? ShowError { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Func<IEnumerable<string>>? ShowOpenFileDialog { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Func<string>? ShowSaveFileDialog { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Func<string, bool>? AskForConfirmation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion
        IEnumerable<ToDo>? AvailableParentTask { get; set; } 
        ICommand DelegateCommand { get; }
        ICommand SaveCommand { get; }
        Task SaveAsync();
        private void UpdateModel(ToDo model);
        
    }
}
