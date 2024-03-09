using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#F2C4B8") };

            DataModel.PeopleCollection.Add(new People 
            { 
                Name = "Jennie Kim", 
                Age = 28, 
                Description = "Former member of Black Pink.",
                Occupation = "Kpop Idol",
                Image = "https://assets.teenvogue.com/photos/6488a68e5d0a51ab9a6f77c8/4:3/w_3262,h_2446,c_limit/GettyImages-1432875246.jpg"
            });

            DataModel.PeopleCollection.Add(new People
            {
                Name = "Jungkook",
                Age = 26,
                Description = "Member of BTS.",
                Occupation = "Kpop Idol",
                Image = "https://imagevars.gulfnews.com/2021/05/21/BTS-Butter-Jungkook-1-1621591457741_1798e61ffce_large.jpg"
            });

            DataModel.PeopleCollection.Add(new People
            {
                Name = "Kim Yoo-Jung",
                Age = 24,
                Description = "Korean Actress known for the Kdrama series: My Demon.",
                Occupation = "Korean Actress",
                Image = "https://m.media-amazon.com/images/M/MV5BYWVjYzUyYWEtYjU2Ni00Y2JmLWIzNmYtMTRkZWI0NjAzZTA2XkEyXkFqcGdeQXVyNTI5NjIyMw@@._V1_.jpg"
            });

            DataModel.PeopleCollection.Add(new People
            {
                Name = "Gong Yoo",
                Age = 44,
                Description = "A popular Korean Actor known for various Kdrama series.",
                Occupation = "Korean Actor",
                Image = "https://asianwiki.com/images/5/5e/Gong_Yoo-1979-p1.jpeg"
            });

            DataModel.PeopleCollection.Add(new People
            {
                Name = "Bae Suzy",
                Age = 29,
                Description = "A popular Korean Actress known for her aesthetic looks.",
                Occupation = "Korean Actress",
                Image = "https://upload.wikimedia.org/wikipedia/commons/f/fb/Bae_Suzy_2nd_Blue_Dragon_Series_Awards_2.jpg"
            });

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
