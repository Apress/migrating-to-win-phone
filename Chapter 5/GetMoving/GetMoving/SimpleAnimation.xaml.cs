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

namespace GetMoving
{
    public partial class SimpleAnimation : PhoneApplicationPage
    {
        string[] textCollection = new string[5] { "number one!", "two seconds", "threeve", "use the fourth", "a fifth is 20%" };
        int textCounter = 0;
        TextBlock currentTextBlock;
        
        public SimpleAnimation()
        {
            InitializeComponent();
            PageFlip.Begin();
            currentTextBlock = PageTitle;
            FadeOut.Completed += new EventHandler(FadeOut_Completed);
            FadeIn.Completed += new EventHandler(FadeIn_Completed);
            FadeOut.Begin();
        }

        void FadeIn_Completed(object sender, EventArgs e)
        {
            FadeOut.Begin();
        }

        void FadeOut_Completed(object sender, EventArgs e)
        {
            FadeOut.Stop();
            FadeIn.Stop();
            currentTextBlock.Text = textCollection[textCounter];
            textCounter++;
            if (textCounter == 5)
            {
                textCounter = 0;

                if (currentTextBlock == PageTitle) currentTextBlock = ApplicationTitle;
                else currentTextBlock = PageTitle;

                Storyboard.SetTarget(FadeIn, currentTextBlock);
                Storyboard.SetTarget(FadeOut, currentTextBlock);
            }

            FadeIn.Begin();
        }
    }
}