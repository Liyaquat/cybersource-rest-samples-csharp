using System.Collections.Generic;

namespace SampleCode.data
{
    public class Configuration
    {
        // initialize dictionary object
        private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

        public Dictionary<string, string> GetConfiguration()
        {
            _configurationDictionary.Add("merchantID", "alconsulting");
            _configurationDictionary.Add("merchantsecretKey", "Wk0CNlPJnaFGv04LINCh0vZQ7ntUZvXktpDa1Tc1O/U=");
            _configurationDictionary.Add("merchantKeyId", "38ebcefb-8e71-4a61-b16a-883af713943b");
            _configurationDictionary.Add("authenticationType", "JWT");
            _configurationDictionary.Add("keysDirectory", "..\\..\\Resource");
            _configurationDictionary.Add("keyFilename", "alconsulting");
            _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
            _configurationDictionary.Add("keyAlias", "alconsulting");
            _configurationDictionary.Add("keyPass", "alconsulting");
            _configurationDictionary.Add("enableLog", "TRUE");
            _configurationDictionary.Add("logDirectory", string.Empty);
            _configurationDictionary.Add("logFileName", string.Empty);
            _configurationDictionary.Add("logFileMaxSize", "5242880");
            _configurationDictionary.Add("timeout", "1000");
            _configurationDictionary.Add("proxyAddress", string.Empty);
            _configurationDictionary.Add("proxyPort", string.Empty);

            return _configurationDictionary;
        }
    }
}
