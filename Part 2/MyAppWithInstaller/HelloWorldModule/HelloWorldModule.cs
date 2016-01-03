using Shared;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        public string WhoAreYou()
        {
            return "Hello World Module";
        }
    }
}
