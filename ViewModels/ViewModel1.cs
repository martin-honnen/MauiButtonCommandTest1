using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiButtonCommandTest1.ViewModels
{
    public class ViewModel1 : ObservableObject
    {
        private string command1Result = "Not yet executed!";
        public string Command1Result
        {
            get
            {
                return command1Result;
            }
            set
            {
                SetProperty(ref command1Result, value);
            }
        }
        public ICommand Command1 { get; }

        public ViewModel1() {

            Command1 = new RelayCommand(() => { Command1Result = $"Executed at {DateTime.Now}"; });

 
            Command2 = new AsyncRelayCommand(Command2BodyAsync);

        }

        public ICommand Command2 { get; }

        private async Task<string> Command2BodyAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
            await Task.Delay(3000);
            sw.Stop();
            return $"Command2 run in {sw.Elapsed}";
        }
    }
}
