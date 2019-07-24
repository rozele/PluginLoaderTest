using System.Composition;
using Microsoft.CognitiveServices.Speech;
using Models;

namespace TestPlugin
{
    [Export(typeof(ITest))]
    public class Test : ITest
    {
        void ITest.Test()
        {
            var speechConfig = SpeechConfig.FromSubscription("key", "region");
        }
    }
}
