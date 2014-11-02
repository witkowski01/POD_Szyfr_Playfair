using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
//using POD_Szyfr_Playfair.Properties.Annotations;
using POD_Szyfr_Playfair.Annotations;


namespace POD_Szyfr_Playfair
{
    public class Playfair: INotifyPropertyChanged
        {

            private string _wejscie, _wyjscie;

          
            public string wejscie
            {
                get { return _wejscie; }
                set
                {
                    if (value != _wejscie)
                    {
                        _wejscie = value;
                        OnPropertyChanged();
                    }
                }
            }

            public string wyjscie
            {
                get { return _wyjscie; }
                set
                {
                    if (value != _wyjscie)
                    {
                        _wyjscie = value;
                        OnPropertyChanged();
                    }
                }
            }

          


            public Playfair()
            {
                //wejscie = "Wejście";
                // wyjscie = "Wyjście";
            }
        
            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
}
