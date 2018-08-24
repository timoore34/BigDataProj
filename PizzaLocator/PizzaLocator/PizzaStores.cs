using Windows.System; 
namespace PizzaLocator
{
    class PizzaStores
        {
            //This is how you tell mongo that this property is the
            //c# equivolent to _id in mongo
            [BsonId]
            public ObjectId ID { get; set; }

            //The mongo object of the same key name
            //will be stored here. Stores the name of the store 
            [BsonElement("name")]
            public string Name { get; set; }

            //The mongo object of the same key name
            //will be stored here. Stores the list
            //of categories the store is in. 
            [BsonElement("categories")]
            public ArrayList<string> Categories { get; set; }

            //The mongo object of the same key name
            //will be stored here. Stores up to the 
            //first 5 reviews in the system for this restruants 
            [BsonElement("top5Reviews")]
            public ArrayList<Reviews> Reviews { get; set; }

            //The mongo object of the same key name
            //will be stored here. Stores the store's city
            [BsonElement("city")]
            public string City { get; set;  }

            //The mongo objet of the same key name
            //will be stored here. Stores the state 
            [BsonElement("state")]
            public string State { get; set;  }


            /// <summary>
            /// ToString Override
            /// </summary>
            /// <returns>How I would like the string to be displayed</returns>
            public override string ToString()
            {
                string reviewsString = "";
                Reviews.ForEach(x => reviewsString += $"\n\t{x.ToString()}");
                string catString = "";
                Categories.ForEach(x => catString += $"\n\t{x}");
                return $"StoreID : {ID}, Name: {Name}, \nReviews: {reviewsString} \nCategories: {catString}";
            } 
        }
}
