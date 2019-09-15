using System;
using System.Collections.Generic;
using System.Text;

namespace My.Dev.Api.Config
{
    public class AppConfiguration
    {
        //This is a conversion operator. It means that you can write this code:

        //XmlBase myBase = new XmlBase();
        //XElement myElement = myBase;

        //And the compiler won't complain! At runtime, the conversion operator will be executed - passing myBase in as the argument,
        //and returning a valid XElement as the result.

        //    It's a way for you as a developer to tell the compiler:
        //"even though these look like two totally unrelated types, there is actually a way to convert from one to the other; just let me
        //handle the logic for how to do it."
        public static implicit operator AppConfiguration(ConfigurationSettings settings)
        {
            return settings.AppConfiguration ?? throw new ArgumentException(nameof(AppConfiguration));
        }
    }
}