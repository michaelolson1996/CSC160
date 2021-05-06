using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Match_Game.Controls
{
    public partial class Card : UserControl, INotifyPropertyChanged
    {
        public GameWindow Owner;
        public enum eState {
            Inactive,
            Idle,
            Flipped,
            Matched
        }

        private eState state { get; set; } = eState.Inactive;
        public eState State
        {
            get { return state; }
            set
            {
                if (value != state)
                {
                    state = value;
                    Interactable = (state == eState.Idle);
                    Show = (state == eState.Flipped || state == eState.Matched);
                    NotifyPropertyChanged("State");
                }
            }
        }

        public bool Show
        {
            set
            {
                if (!value)
                {
                    lblSymbol.Visibility = Visibility.Hidden;
                    imgCard.Visibility = Visibility.Visible;
                }
                else
                {
                    lblSymbol.Visibility = Visibility.Visible;
                    imgCard.Visibility = Visibility.Hidden;
                }
            }
        }

        private bool interactable;
        public bool Interactable
        {
            get { return interactable; }
            set
            {
                if (value != interactable)
                {
                    interactable = value;
                    NotifyPropertyChanged("Interactable");
                }
            }
        }

        private string symbol { get; set; }
        public string Symbol
        {
            get { return symbol; }
            set
            {
                if (value != symbol)
                {
                    symbol = value;
                    NotifyPropertyChanged("Symbol");
                }
            }
        }

        public Card()
        {
            this.InitializeComponent();
            DataContext = this;
            this.Loaded += Card_Loaded;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void btnCard_Click(object sender, EventArgs e)
        {
            State = eState.Flipped;
            Owner.SelectCard(this);
        }

        private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void Card_Loaded(object sender, RoutedEventArgs e)
        {
            Owner = (GameWindow) Window.GetWindow(this);
            Owner.RegisterCard(this);
        }
    }
}
