using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("Array length is less than 3", null);
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }
            var latitude = cells[0];
            // grab the latitude from your array at index 0
            var longitude = cells[1];
            // grab the longitude from your array at index 1
            var locationName = cells[2];
            // grab the name from your array at index 2

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            var dublatitude = double.Parse(latitude);
            var dublongitude = double.Parse(longitude);



            // You'll need to create a TacoBell class
            // that conforms to ITrackable
            var _tacoBell = new TacoBell();


            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var point = new Point();
            point.Latitude = dublatitude;
            point.Longitude = dublongitude;
            _tacoBell.Location = point;
            // _tacoBell.Name = locationName;

            return _tacoBell;
           

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            //return null;
        }
    }
}