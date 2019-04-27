using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class DataBindClass : INotifyPropertyChanged
    {
        private string _button1Text;
        private string _button2Text;
        private string _button3Text;
        private string _textBlock1Text;
        private string _textBlock2Text;
        private string _textBlock3Text;

        public string Button1Text
        {
            get
            {
                return _button1Text;
            }

            set
            {
                if (value != _button1Text)
                {
                    _button1Text = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Button2Text
        {
            get
            {
                return _button2Text;
            }

            set
            {
                if (value != _button2Text)
                {
                    _button2Text = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Button3Text
        {
            get
            {
                return _button3Text;
            }

            set
            {
                if (value != _button3Text)
                {
                    _button3Text = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TextBlock1Text
        {
            get
            {
                return _textBlock1Text;
            }

            set
            {
                if (value != _textBlock1Text)
                {
                    _textBlock1Text = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TextBlock2Text
        {
            get
            {
                return _textBlock2Text;
            }

            set
            {
                if (value != _textBlock2Text)
                {
                    _textBlock2Text = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TextBlock3Text
        {
            get
            {
                return _textBlock3Text;
            }

            set
            {
                if (value != _textBlock3Text)
                {
                    _textBlock3Text = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
