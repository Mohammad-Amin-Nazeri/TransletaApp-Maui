
using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Graphics.Platform;
using Trenslite.Class;

namespace TransletaApp
{
    public partial class MainPage : ContentPage
    {
        
            Dictionary<string, string> languageCodes = new Dictionary<string, string>
{
    { "فارسی", "fa" },
    { "انگلیسی", "en" },
     { "عربی", "ar" },
     { "فرانسوی", "fr" },
     { "ایتالیایی", "it" },
    { "آفریکانس", "af" },
    { "آلبانیایی", "sq" },
    { "آمریکایی", "am" },
    { "ارمنی", "hy" },
    { "آذربایجانی", "az" },
    { "باسکی", "eu" },
    { "بلاروسی", "be" },
    { "بنگالی", "bn" },
    { "بوسنیایی", "bs" },
    { "بلغاری", "bg" },
    { "کاتالان", "ca" },
    { "سیبوانو", "ceb" },
    { "چینی (ساده‌شده)", "zh-CN" },
    { "چینی (سنتی)", "zh-TW" },
    { "کرواتی", "hr" },
    { "چکی", "cs" },
    { "دانمارکی", "da" },
    { "هلندی", "nl" },
    { "اسپرانتو", "eo" },
    { "استونیایی", "et" },
    { "فیلیپینی", "tl" },
    { "فنلاندی", "fi" },
    { "گالیسیایی", "gl" },
    { "گرجستانی", "ka" },
    { "آلمانی", "de" },
    { "یونانی", "el" },
    { "گجراتی", "gu" },
    { "هایتیایی", "ht" },
    { "عبری", "he" },
    { "هندی", "hi" },
    { "هندی (قبیله‌ای)", "hmn" },
    { "مجارستانی", "hu" },
    { "ایسلندی", "is" },
    { "ایگبو", "ig" },
    { "اندونزیایی", "id" },
    { "ایرلندی", "ga" },
    { "ژاپنی", "ja" },
    { "جاوه‌ای", "jv" },
    { "قزاقی", "kk" },
    { "خمر", "km" },
    { "کره‌ای", "ko" },
    { "قرقیزی", "ky" },
    { "لاوسی", "lo" },
    { "لتونیایی", "lv" },
    { "لیتوانیایی", "lt" },
    { "مقدونی", "mk" },
    { "مالاگاسی", "mg" },
    { "مالایی", "ms" },
    { "مالایالم", "ml" },
    { "مالتی", "mt" },
    { "مراتی", "mr" },
    { "مغولی", "mn" },
    { "میانماری", "my" },
    { "نپالی", "ne" },
    { "نروژی", "no" },
    { "پشتو", "ps" },
    { "لهستانی", "pl" },
    { "پرتغالی", "pt" },
    { "پنجابی", "pa" },
    { "رومانیایی", "ro" },
    { "روسی", "ru" },
    { "ساموایی", "sm" },
    { "صربی", "sr" },
    { "سیندهای", "sd" },
    { "اسلواکی", "sk" },
    { "اسلوونیایی", "sl" },
    { "سواحلی", "sw" },
    { "سوئدی", "sv" },
    { "تاجیکی", "tg" },
    { "تامیل", "ta" },
    { "تلوگو", "te" },
    { "تایلندی", "th" },
    { "ترکی", "tr" },
    { "اوکراینی", "uk" },
    { "اردو", "ur" },
    { "ازبکی", "uz" },
    { "ویتنامی", "vi" },
    { "ولزی", "cy" },
    { "خوسایی", "xh" },
    { "یوروبایی", "yo" },
    { "زولو", "zu" }
};

        public MainPage()
        {
            InitializeComponent();
            OnAppearing();
            App.Current.UserAppTheme = AppTheme.Light;

            double fontSize = GetFontSize();
            if (fontSize > 1 )
            {
                logoText.FontSize = (logoText.FontSize / fontSize);
                tozihLogo.FontSize = (tozihLogo.FontSize / fontSize);
                SwitchLanguages.FontSize = (SwitchLanguages.FontSize / fontSize);
                inputText.FontSize = (inputText.FontSize / fontSize);
                TranslateText.FontSize = (TranslateText.FontSize / fontSize);
                translatedText.FontSize = (translatedText.FontSize / fontSize);
                CopyText.FontSize = (CopyText.FontSize / fontSize);
                ShareText.FontSize = (ShareText.FontSize / fontSize);
                sourceLanguage.FontSize= (sourceLanguage.FontSize / fontSize);
                targetLanguage.FontSize= (targetLanguage.FontSize / fontSize);  
            }


            foreach (var language in languageCodes.Keys)
            {
                sourceLanguage.Items.Add(language);
                targetLanguage.Items.Add(language);
            }
        }

        public float GetFontSize()
        {
            #if ANDROID
            var configuration = Android.App.Application.Context.Resources.Configuration;
            return configuration.FontScale;
            #endif
            return 1;

        }
        private void SwitchLanguages_Clicked(object sender, EventArgs e)
        {
            var tempLanguage = sourceLanguage.SelectedItem;
            sourceLanguage.SelectedItem = targetLanguage.SelectedItem;
            targetLanguage.SelectedItem = tempLanguage;

            inputText.Placeholder = null;
            string selectedLanguage = sourceLanguage.SelectedItem.ToString();

            if (selectedLanguage == "فارسی" || selectedLanguage == "پشتو" || selectedLanguage == "عربی" || selectedLanguage == "عبری" || selectedLanguage == "اردو")
            {
                inputText.HorizontalTextAlignment = TextAlignment.End; // راست‌به‌چپ
            }
            else
            {
                inputText.HorizontalTextAlignment = TextAlignment.Start; // چپ‌به‌راست
            }

            inputText.Placeholder = "متن را وارد کنید";


        }


        // دریافت کد زبان بر اساس ورودی
        public string GetLanguageCode(string language)
        {
            // بررسی اینکه آیا زبان وارد شده در دیکشنری موجود است یا نه
            if (languageCodes.TryGetValue(language, out string code))
            {
                return code; // بازگشت کد زبان
            }
            else
            {
                return "en"; // پیش‌فرض به انگلیسی
            }
        }

        /* Unmerged change from project 'Trenslite (net8.0-android)'
        Before:
                private  void TranslateText_Clicked(object sender, EventArgs e)
                {
        After:
                private  async Task TranslateText_ClickedAsync(object sender, EventArgs e)
                {
        */
        private void TranslateText_Clicked(object sender, EventArgs e)
        {
            OnButtonClickedCombined(sender, e);
            try
            {

                if (sourceLanguage.SelectedIndex != -1 && targetLanguage.SelectedIndex != -1)
                {
                    var current = Connectivity.Current.NetworkAccess;

                    if (current == NetworkAccess.Internet)
                    {
                        translatedText.Scale = 0;
                        translatedText.Opacity = 0;
                        frame2.Scale = 0;
                        frame2.Opacity = 0;
                        copyshera.Scale = 0;
                        copyshera.Opacity = 0;

                        translatedText.IsVisible = true;
                        frame2.IsVisible = true;
                        copyshera.IsVisible = true;


                        transAny();
                        translateClass.trans(inputText.Text, GetLanguageCode(sourceLanguage.SelectedItem.ToString()), GetLanguageCode(targetLanguage.SelectedItem.ToString()));
                        string selectedLanguage = targetLanguage.SelectedItem.ToString();

                        if (selectedLanguage == "فارسی" || selectedLanguage == "پشتو" || selectedLanguage == "عربی" || selectedLanguage == "عبری" || selectedLanguage == "اردو")
                        {
                            translatedText.HorizontalTextAlignment = TextAlignment.End; // راست‌به‌چپ
                        }
                        else
                        {
                            translatedText.HorizontalTextAlignment = TextAlignment.Start; // چپ‌به‌راست
                        }
                        translatedText.Text = translateClass.Translate;

                    }
                    else
                    {
                        DisplayAlert("خطا", "اتصال شما با اینترنت قطع شده است لطفا مجدد تلاش کنید", "باشه"); ;
                    }
                }
                else
                {
                    DisplayAlert("خطا", "لطفا زبان مبدا و مقصد را انتخاب کنید", "باشه");
                }
            }
            catch (Exception)
            {
                DisplayAlert("خطا", "مشکلی پیش آمده لطفا مجدد تلاش کنید", "باشه");
            }


        }

        private void CopyText_Clicked(object sender, EventArgs e)
        {
            OnButtonClickedCombined(sender, e);
            if (!string.IsNullOrWhiteSpace(translatedText.Text))
            {
                Clipboard.SetTextAsync(translateClass.Translate);
                DisplayAlert("کپی شد", "ترجمه در کلیپ‌بورد کپی شد", "باشه");
            }
        }

        private void ShareText_Clicked(object sender, EventArgs e)
        {
             OnButtonClickedCombined(sender, e);
            if (!string.IsNullOrWhiteSpace(translateClass.Translate))
            {
                Share.RequestAsync(new ShareTextRequest
                {
                    Text = translateClass.Translate,
                    Title = "اشتراک‌گذاری ترجمه"
                });
            }
        }

        private void inputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (inputText.Text != "" && inputText.Text != " ")
            {
                translatedText.IsEnabled = true;
            }
            else
            {
                translatedText.IsEnabled = false;
            }
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Example: animate button and frame when the page appears

            // Start with scale zero and opacity zero
            TranslateText.Scale = 0;
            TranslateText.Opacity = 0;

            frame1.Scale = 0;
            frame1.Opacity = 0;

            logoAndName.Scale = 0;
            logoAndName.Opacity = 0;

            GridSelect.Scale = 0;
            GridSelect.Opacity = 0;

            frame2.Scale = 0;
            frame2.Opacity = 0;

            inputText.Scale = 0;
            inputText.Opacity = 0;



            TranslateText.Scale = 0;
            TranslateText.Opacity = 0;

            inputText.Scale = 0;
            inputText.Opacity = 0;


            copyshera.Scale = 0;
            copyshera.Opacity = 0;




            // Apply animation for the button with fade and scale


            await logoAndName.ScaleTo(1, 1500, Easing.SpringOut);
            await logoAndName.FadeTo(1, 1000);

            await GridSelect.ScaleTo(1, 200, Easing.SpringOut);
            await GridSelect.FadeTo(1, 300);


            await frame1.ScaleTo(1, 300, Easing.SpringOut);
            await frame1.FadeTo(1, 400);

            await inputText.ScaleTo(1, 200, Easing.SpringOut);
            await inputText.FadeTo(1, 400);

            await TranslateText.ScaleTo(1, 200, Easing.SpringOut);  // Scale animation
            await TranslateText.FadeTo(1, 400);  // Fade animation


           



            // Apply similar animation for the frame
          



        }

        public async void transAny()
        {

            await translatedText.ScaleTo(1, 300, Easing.SpringOut);
            await translatedText.FadeTo(1, 400);

            await frame2.ScaleTo(1, 200, Easing.SpringOut);
            await frame2.FadeTo(1, 300);

            await copyshera.ScaleTo(1, 1000, Easing.SpringOut);
            await copyshera.FadeTo(1, 900);
        }

        private async void OnButtonClickedCombined(object sender, EventArgs e)
        {
            var button = sender as Button;

            // Combine scaling, rotation and fading animations
            await Task.WhenAll(
                button.ScaleTo(0.94, 100),  // Shrink slightly

                button.FadeTo(3, 500)     // Fade out slightly
            );

            // Return to original state
            await Task.WhenAll(
                button.ScaleTo(1, 100),

                button.FadeTo(1, 500)
            );
        }

        private void sourceLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputText.Placeholder = null;
            string selectedLanguage = sourceLanguage.SelectedItem.ToString();

            if (selectedLanguage == "فارسی" || selectedLanguage == "پشتو" || selectedLanguage == "عربی" || selectedLanguage == "عبری" || selectedLanguage == "اردو")
            {
                inputText.HorizontalTextAlignment = TextAlignment.End; // راست‌به‌چپ
            }
            else
            {
                inputText.HorizontalTextAlignment = TextAlignment.Start; // چپ‌به‌راست
            }

            inputText.Placeholder = "متن را وارد کنید";
        }

        private void AboutButt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
