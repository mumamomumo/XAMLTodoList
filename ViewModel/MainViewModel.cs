using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace TodoListAppThingButItDoesntWork.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            tasks = new ObservableCollection<TaskItem>();
        }
        [ObservableProperty]
        public string? text;

        [ObservableProperty]
        ObservableCollection<TaskItem> tasks;



        [RelayCommand]
        void AddTask()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            else
            {

                Tasks.Add(new TaskItem(Text));
                Text = String.Empty;
            }
        }

        [RelayCommand]
        void RemoveTask(TaskItem item)
        {
            Tasks.Remove(item);
        }
    }

    public record TaskItem(string TaskName, bool IsChecked = false);
}
