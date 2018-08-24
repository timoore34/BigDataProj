using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLocator
{
    class Reviews
    {
        //This is how you tell mongo that this property is the
        //c# equivolent to _id in mongo
        [BsonId]
        public ObjectId ID { get; set; }

        //The mongo object of the same key name
        //will be stored here. Ties the reviews
        //to the pizza placces... like a foreign key
        [BsonElement("bussinessID")]
        public ObjectId BussinessID { get; set; }

        //The mongo object of the same key name
        //will be stored here. Stores the contents
        //of the reviews
        [BsonElement("text")]
        public string ReviewText { get; set; }

        //The mongo object of the same key name
        //will be stored here. Stores the date it was created
        [BsonElement("date")]
        public string CreationDate { get; set; }

        //The mongo object of the same key name
        //will be stored here. Stores the amount of stars given
        [BsonElement("stars")]
        public int Stars { get; set;  } 

        //This is how I want the review to be printed
        //in the console or wherever it is being seen/logged.
        public override string ToString()
        {
            return $"ReviewID : {ID}, BussinessID: {BussinessID}, Review: {ReviewText}, Rating: {Stars}";
        }
    } 
} 
