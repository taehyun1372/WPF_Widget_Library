using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.ComponentModel;

namespace Widget_Library.Widgets
{
    public class DigitalSensorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Brush _strokeColor;
        public Brush StrokeColor
        { 
            get
            {
                return _strokeColor;
            }
            set
            {
                _strokeColor = value;
                OnPropertyChanged(nameof(StrokeColor));
            }
        }

        public DigitalSensorViewModel()
        {
            StrokeColor = Brushes.Black;
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
