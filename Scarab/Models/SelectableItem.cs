using System.ComponentModel;

namespace Scarab.Models
{
    public record SelectableItem<T>(T Item, string DisplayName, bool IsSelected, bool IsExcluded=false) : INotifyPropertyChanged
    {
        private bool _isSelected = IsSelected;
        private bool _isExcluded = IsExcluded;

        public bool IsSelected 
        { 
            get => _isSelected; 
            set
            {
                _isSelected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSelected)));
            }

        }
        public bool IsExcluded
        {
            get => _isExcluded;
            set
            {
                _isExcluded = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsExcluded)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}