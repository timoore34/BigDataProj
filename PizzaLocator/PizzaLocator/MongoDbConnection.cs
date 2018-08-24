using Windows.System;
using Windows.System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLocator
{
    class MongoDbConnection
    {

        #region Main Method 
        static void Main(string[] args)
        {
            //This is how to connect to your mongo instance.
            //You will probably need to change the ipAddress part of this string to match the
            //ipAddress of your linux system. you can keep the port the same.
            //If you are having trouble connecting then run the command
            //"mongod --host (linux ipAddress)" and make sure you have an instance of mongo running.
            MongoClient client = new MongoClient("mongodb://192.168.152.129:27017");

            //Creates the database if it doesnt already exist.
            //Gets the db.
            IMongoDatabase db = client.GetDatabase("PLDatabase");
            try 
            {
                //Drops these collections if they exist.
                //You can comment out this try catch if you want.
                //I just didn't want so just keep adding to my db every time
                //while I was testing.
                db.DropCollection("PizzaStores");
                db.DropCollection("Reviews");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

 
        }
        #endregion 

        #region StaticVariables
        private static List<Reviews> reviewList = new List<Reviews>();
        private static List<PizzaStores> listOfStores = new List<PizzaStores>(); 
        #endregion

        #region Importing Data
        /// <summary>
        /// Populates the static variables region with the data from yelp
        /// </summary>
        /// Might be easier to import the data manual before connecting, will come back to this
        private static void DataImport()
        { 
        }
        #endregion

        #region Query
        #endregion 
    }
}
