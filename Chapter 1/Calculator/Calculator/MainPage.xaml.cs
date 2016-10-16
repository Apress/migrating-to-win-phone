using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Calculator
{
    public partial class MainPage : PhoneApplicationPage
    {
        public enum OperatorTypes
        {
            None,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        OperatorTypes operatorType = OperatorTypes.None;
        bool isNewNumber = false;
        double previousNumber = 0;

        public double DisplayNumber
        {
            get { return ( double ) GetValue( DisplayNumberProperty ); }
            set { SetValue( DisplayNumberProperty, value ); }
        }

        public static readonly DependencyProperty DisplayNumberProperty = DependencyProperty.Register( "DisplayNumber", typeof( double ), typeof( MainPage ), null );

        public MainPage()
        {
            InitializeComponent();
        }

        private void Clear_Click(
            object sender, 
            System.Windows.RoutedEventArgs e)
        {
            DisplayNumber = 0;
        }

        private void NumberButton_Click(
            object sender, 
            System.Windows.RoutedEventArgs e)
        {
            AddToDisplayNumber( 
                double.Parse( (( Button ) sender)
                .Content.ToString() ) );
        }

        private void Add_Click( object sender, System.Windows.RoutedEventArgs e )
        {
            operatorType = OperatorTypes.Addition;
            isNewNumber = true;
        }

        private void Subtract_Click( object sender, System.Windows.RoutedEventArgs e )
        {
            operatorType = OperatorTypes.Subtraction;
            isNewNumber = true;
        }

        private void Multiply_Click( object sender, System.Windows.RoutedEventArgs e )
        {
            operatorType = OperatorTypes.Multiplication;
            isNewNumber = true;
        }

        private void Divide_Click( object sender, System.Windows.RoutedEventArgs e )
        {
            operatorType = OperatorTypes.Division;
            isNewNumber = true;
        }

        private void Equals_Click( object sender, System.Windows.RoutedEventArgs e )
        {
            switch (operatorType)
            {
                case OperatorTypes.Addition:
                    DisplayNumber = previousNumber + DisplayNumber;
                    break;
                case OperatorTypes.Subtraction:
                    DisplayNumber = previousNumber - DisplayNumber;
                    break;
                case OperatorTypes.Multiplication:
                    DisplayNumber = previousNumber * DisplayNumber;
                    break;
                case OperatorTypes.Division:
                    DisplayNumber = previousNumber / DisplayNumber;
                    break;
                default:
                    break;
            }
            isNewNumber = true;
        }
        private void AddToDisplayNumber( double digit )
        {
            if (isNewNumber)
            {
                isNewNumber = false;
                previousNumber = DisplayNumber;
                DisplayNumber = digit;
            }
            else if (DisplayNumber == 0)
            {
                DisplayNumber = digit;
            }
            else
            {
                DisplayNumber = DisplayNumber * 10 + digit;
            }
        }

        protected override void OnNavigatedTo( 
            System.Windows.Navigation.NavigationEventArgs e )
        {
            DataContext = this;
            DisplayNumber = 0;
        }
    }
}