﻿using CyberSource.Api;
using CyberSource.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersource_rest_samples_dotnet.Samples.RecurringBillingSubscriptions
{
    public class ActivateSubscription
    {
        public static InlineResponse2009 Run()
        {
            try
            {
                var subscriptionId = CancelSubscription.Run().Id;
                var configDictionary = new Configuration().GetConfiguration();
                var clientConfig = new CyberSource.Client.Configuration(merchConfigDictObj: configDictionary);

                var apiInstance = new SubscriptionsApi(clientConfig);
                var result = apiInstance.ActivateSubscription(subscriptionId);
                Console.WriteLine(result);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception on calling the API : " + e.Message);
                return null;
            }
        }
    }
}
