using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.FontIcons.Helpers;
using Xamarin.Forms;

namespace Xamarin.FontIcons
{
    public partial class MainPage : ContentPage
    {
        bool _runAnimation;
        string[] _hands = { "\uF255", "\uF256", "\uF257", "\uF258", "\uF259","\uF25A","\uF25B" };

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _runAnimation = true;
            StartAnimation().Forget();
            StartAnimation2().Forget();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _runAnimation = false;
        }

        async Task StartAnimation()
        {
            int i = 0;

            while (_runAnimation)
            {
                var t1 = Heart.ScaleTo(1.3, 200);
                var t2 = HeartFilled.ScaleTo(1.3, 200);
                var t3 = HeartFilled.FadeTo(1, 200);

                await Task.WhenAll(t1, t2, t3);

                var t4 = Heart.ScaleTo(1, 200);
                var t5 = HeartFilled.ScaleTo(1, 200);
                var t6 = HeartFilled.FadeTo(0, 200);

                await Task.WhenAll(t4, t5, t6);

                if (i++ % 2 == 0)
                {
                    await Task.Delay(400);
                }
            }
        }

        async Task StartAnimation2()
        {
            Random random = new Random();

            int lastIndex = -1;
            while (_runAnimation)
            {
                var i = random.Next(0, _hands.Length);
                if (i == lastIndex)
                {
                    // if the char is the same, skip it to avoid visual pauses
                    continue;
                }

                lastIndex = i;
                HandIcon.Text = _hands[i];
                await Task.Delay(300);
            }
        }
    }
}
