namespace Bookstore.Api.Client
{
    public class Configuration
    {
        public static Env Environment { get; set; }
        public static string CustomUrl { get; set; }
        public string Url
        {
            get
            {
                switch (Environment)
                {
                    case Env.Prod:
                        return "https://bookstoreapiblogpost.azurewebsites.net/api";

                    default:
                        return CustomUrl;
                }
            }
        }
    }

    public enum Env
    {
        Prod,
        Custom
    }
}
