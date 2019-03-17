using System;

namespace dev_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var phonemeBuilder = new PhonemeBuilder();
            phonemeBuilder.ShowPhoneme(phonemeBuilder.BuildPhoneme(args[0]));
            Console.ReadLine();
        }
    }
}
