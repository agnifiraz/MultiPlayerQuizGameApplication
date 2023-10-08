﻿/*
 * File name: QuestionLibrary.cs
 * Author: Dhanashri, Ivan, Agnita 
 * Creation Date: 03 April, 2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameLibrary
{
    internal static class QuestionLibrary
    {
        //All questions add to the list
        public static readonly List<Question> AllQuestions = new List<Question>
        {                        //Question                        // Answer            // Options
            new Question("How many Infinity Stones are there?","6", new List<string>{"3","5","10"}),
            new Question("Which was René Magrittes first surrealist painting?", "Not to Be Reproduced", new List<string>{"Personal Values", "The Lovers", "The Lost Jockey"}),
            new Question("What 90s boy band member bought Myspace in 2011?", "Justin Timberlake", new List<string>{"Nick Lachey", "Shawn Stockman", "AJ McLean"}),
            new Question("What is the most visited tourist attraction in the world?", "Eiffel Tower", new List<string>{"Statue of Liberty", "Great Wall of China", "Colosseum"}),
            new Question("Whats the name of Hagrids pet spider?", "Aragog", new List<string>{"Nigini", "Crookshanks", "Mosag"}),
            new Question("Whats the heaviest organ in the human body?", "Liver", new List<string>{"Brain", "Skin", "Heart"}),
            new Question("Who made the third most 3-pointers in the Playoffs in NBA history?", "Lebron James", new List<string>{"Kevin Durant", "JJ Reddick", "Kyle Korver"}),
            new Question("Which of these EU countries does not use the euro as its currency?", "Denmark", new List<string>{"Poland", "Sweden", "All of the above"}),
            new Question("Which US city is the sunniest major city and sees more than 320 sunny days each year?", "Phoenix", new List<string>{"Miami", "San Francisco", "Austin"}),
            new Question("What type of food holds the world record for being the most stolen around the globe?", "Cheese", new List<string>{"Wagyu beef", "Coffee", "Chocolate"}),
            new Question("What element does the chemical symbol Au stand for?", "Gold", new List<string>{"Silver", "Magnesium", "Salt"}),
            new Question("What is the highest-grossing Broadway show of all time?", "Hamilton", new List<string>{"The Lion King", "Wicked", "Kinky Boots"}),
            new Question("On average, how many seeds are located on the outside of a strawberry?", "200", new List<string>{"100", "400", "500"}),
            new Question("Which fast food restaurant has the largest number of retail locations in the world?", "McDonalds", new List<string>{"Jack In The Box", "Chipotle", "Subway"}),
            new Question("Where is recognized as the location of the hottest temperature ever recorded on Earth?", "Death Valley, California", new List<string>{"Mitribah, Kuwait", "Yuma, Arizona", "Key West, Florida"}),
            new Question("What is the oldest soft drink in the United States?", "Dr. Pepper", new List<string>{"Coca Cola", "Pepsi", "Canada Dry Ginger Ale"}),
            new Question("What river passes through New Orleans, Louisiana?", "Mississippi River", new List<string>{"Orleans River", "Atchafalaya River", "Colorado River"}),
            new Question("In what country do more than half of people believe in elves?", "Iceland", new List<string>{"Norway", "Russia", "Holland"}),
            new Question("What is the name of the coffee shop in the sitcom Friends?", "Central Perk", new List<string>{"Java Park", "Central Park Coffee", "Central Park Roastery"}),
            new Question("Which pop star burnt down her home gym with candles?", "Britney Spears", new List<string>{"Kim Kardashian", "Lady Gaga", "Zendaya"}),
            new Question("What is the highest-grossing video game franchise to date?", "Pokemon", new List<string>{"Mario", "Call of Duty", "Street Fighter"}),
            new Question("“Cirque du Soleil” started in what country?", "Canada", new List<string>{"France", "USA", "Russia"}),
            new Question("Which countrys national animal is a unicorn?", "Scotland", new List<string>{"Denmark", "New Zealand", "France"}),
            new Question("What are the two highest-grossing films of all time?", "Avatar and Avengers: End Game", new List<string>{"Avengers: End Game and Star Wars: Episode VII  The Force Awakens", "Avengers: Infinity War and Titanic", "Furious 7 and Avatar"}),
            new Question("Which Avenger other than Captain America was able to pick up Thors Mjolnir in the Marvel movies?", "Vision", new List<string>{"Wanda", "Spiderman", "Doctor Strange"}),
            new Question("What is the main ingredient in a falafel?", "Chickpea", new List<string>{"Lentil", "Broccoli", "Split pea"}),
            new Question("What color dresses do Chinese women traditionally wear on their wedding day?", "Red", new List<string>{"Blue", "Gold", "White"}),
            new Question("What is yellowtail fish called in Japanese?", "Hamachi", new List<string>{"Ahi", "Ikura", "Maguro"}),
            new Question("What sport has been played on the moon?", "Golf", new List<string>{"Frisbee", "Soccer", "Bocce ball"}),
            new Question("What is the highest-grossing holiday movie of all time?", "Home Alone", new List<string>{"Elf", "Die Hard", "Its A Wonderful Life"}),
            new Question("What was the first cash crop in America?", "Tobacco", new List<string>{"Corn", "Sugar Cane", "Grapes"}),
            new Question("Mycology is the scientific study of what?", "Fungi", new List<string>{"Cancer cells", "Flowers", "Blood"}),
            new Question("What animal is the closest living relative of a human?", "Bonobos", new List<string>{"Gorillas", "Monkeys", "Homo sapiens"}),
            new Question("What does the meaning of the word “zodiac” in Ancient Greek?", "Circle of animals", new List<string>{"Circle of personalities", "Circle of stars", "Circle of futures"}),
            new Question("Aries, Sagittarius, and Leo are three zodiac signs in which triplicity?", "Fire", new List<string>{"Air", "Water", "Earth"}),
            new Question("The first vaccine was for which disease?", "Smallpox", new List<string>{"Chickenpox", "Polio", "Measles"}),
            new Question("Which Beatle made Elton John the godfather of his son?", "John Lennon", new List<string>{"Paul McCartney", "Ringo Starr", "George Harrison"}),
            new Question("What lobster organ is made into a delicacy known as “tomalley”?", "Liver", new List<string>{"Claw", "Tail", "Antennae"}),
            new Question("The villains in the 2007 version of the movie “Transformers” are known as what?", "Decepticons", new List<string>{"Storm Troopers", "Death Eaters", "Sentinels"}),
            new Question("Which cereal grain is the most commonly used in beer?", "Barley", new List<string>{"Wheat", "Hops", "Rice"}),
            new Question("“Indiana Jones and the Kingdom of the Crystal Skull” is based on whose story idea?","George Lucas", new List<string>{"Michael Bay","Ernest Hemingway","Tim Burton"}),
            new Question("What country are the Galapagos Islands located in?","Ecuador", new List<string>{"Belize","Brazil","Colombia"}),
            new Question("Which sea creature has three hearts?","Octopus", new List<string>{"Shark","Jellyfish","Stingray"}),
            new Question("Pupusas are from what country?","El Salvador", new List<string>{"Mexico","Brazil","Poland"}),
            new Question("What is the name of the talkative parrot in “Aladdin”?","Iago", new List<string>{"Pascal","Meeko","Abu"}),
            new Question("On “Friends”, what is Ross occupation?","Paleontologist", new List<string>{"Meteorologist","News Anchor","Teacher"}),
            new Question("What is Ricks last name in “Rick and Morty”?","Sanchez", new List<string>{"Smith","Guetterman","Noopers"}),
            new Question("Where did the croissant originate?","Austria", new List<string>{"France","Turkey","Tokyo"}),
            new Question("In what U.S. state does “Breaking Bad” take place?","New Mexico", new List<string>{"Utah","Missouri","Texas"}),
            new Question("What country is Shakira from?","Colombia", new List<string>{"Mexico","Puerto Rico","Paraguay"}),
            new Question("Which of these retailers is the oldest operating?","Brooks Brothers (opened in 1818)", new List<string>{"Macys","Kiehls","Saks Fifth Avenue"}),
            new Question("Mount Olympus is the highest mountain in what country?","Greece", new List<string>{"Italy","Spain","Portugal"}),
            new Question("Which country ranks first in cereal consumption per capita?","Ireland", new List<string>{"USA","Italy","Philippines"}),
            new Question("From which country do French fries originate?","Belgium", new List<string>{"France","USA","England"}),
            new Question("What sport is referred to as the “sport of kings”?","Polo", new List<string>{"Bocce Ball","Cricket","Rugby"}),
            new Question("Who was the first Disney Princess?","Snow White", new List<string>{"Cinderella","Aurora","Jasmine"}),
            new Question("What year was In-N-Out Burger founded?","1948", new List<string>{"1968","1975","1985"}),
            new Question("How many islands are in Hawaii?","137", new List<string>{"4","7","48"}),
            new Question("What is the national alcoholic beverage of America?","Bourbon", new List<string>{"Rye","Whiskey","Cognac"}),
            new Question("What is Bruno Mars real name?","Peter Gene Hernandez", new List<string>{"Michael Nguyen-Stevenson","Ray Aguirre","Bruno Maritza"}),
            new Question("What was the very first Pixar movie?","Toy Story", new List<string>{"Wall-E","Monsters, Inc.","A Bugs Life"}),
            new Question("What was the ancient Goddess of Love?", "Venus", new List<string>{"Athena", "Helen", "Hera"}),
            new Question("What are imitation crab sticks made of?", "Whitefish", new List<string>{"Cuttlefish", "Tofu", "Calamari"}),
            new Question("Which ocean is the Bermuda Triangle in?", "Atlantic Ocean", new List<string>{"Pacific Ocean", "Caribbean Ocean", "Indian Ocean"}),
            new Question("Where is Kanye West from?", "Chicago, Illinois", new List<string>{"Boston, Massachusetts", "Detroit, Michigan", "Los Angeles, California"}),
            new Question("What is the smallest country in the world?", "The Vatican City", new List<string>{"Luxembourg", "Palau", "San Marino"}),
            new Question("What animal species is the only male that gets pregnant?", "Seahorse", new List<string>{"Dolphin", "Elephant Seal", "Sea Turtle"}),
            new Question("Who was the first woman to ever be inducted into the Rock and Roll Hall of Fame?", "Aretha Franklin", new List<string>{"Dolly Parton", "Janis Joplin", "Joni Mitchell"}),
            new Question("What is the hardest natural substance in the world?", "Diamond", new List<string>{"Granite", "Marble", "Iron"}),
            new Question("Which “Wonders Of The World” is still in existence?", "Pyramids of Giza", new List<string>{"Temple of Artemis", "Hanging Gardens of Babylon", "Statue of Zeus"}),
            new Question("Who painted the Mona Lisa?", "Leonardo da Vinci", new List<string>{"Michelangelo", "Vincent van Gogh", "Rembrandt"}),
            new Question("Which company was the first to reach 1 trillion dollars?", "Apple", new List<string>{"Microsoft", "Amazon", "Google"}),
            new Question("Which animal has the largest eyes?", "Giant squid", new List<string>{"Blue whale", "Ostrich", "Elephant"}),
            new Question("From what country did jazz originate?", "USA", new List<string>{"France", "Canada", "Germany"}),
            new Question("What aerobic Latin dance workout craze launched its own clothing line in 2007?", "Zumba", new List<string>{"Jazzercise", "Masala Bhangra", "Feel The Heat"}),
            new Question("Which store, known for its giant furniture warehouses, sold an estimated 150 million Swedish meatballs in 2013?", "IKEA", new List<string>{"Pottery Barn", "Living Spaces", "CB2"}),
            new Question("Can you name the national dog breed of France?", "French Bulldog", new List<string>{"Bichon Frise", "Poodle", "Shih Tzu"}),
            new Question("What cup size, meaning “thirty” in Italian, was introduced by Starbucks in 2011 for 31-ounce cold beverages?", "Trenta", new List<string>{"Venti", "Venta", "Trenti"}),
            new Question("Which animal kills the most humans annually?", "Mosquitoes", new List<string>{"Bees", "Sharks", "Alligators"}),
            new Question("Which losing team did billionaire Mark Cuban buy for 285 million in 2000, and eventually lead to an NBA championship in 2011?", "Dallas Mavericks", new List<string>{"Cleveland Cavaliers", "Boston Celtics", "Golden State Warriors"}),
            new Question("In 1998, Jeff Bezos made a deal with British film fan Col Needham to purchase what movie-related site for $55 million?", "IMDb", new List<string>{"Fandango", "Rotten Tomatoes", "Plex TV"}),
            new Question("What country is the worlds largest coffee bean producer?","Brazil", new List<string>{"Tanzania","Mexico","Hawaii"}),
            new Question("What alcoholic spirit is found in all four of these cocktails: Gimlet, Negroni, Aviation, and Tom Collins?","Gin", new List<string>{"Vodka","Whiskey","Cognac"}),
            new Question("Poutine, often referred to as Canadas national dish, consists of french fries, gravy, and which other ingredient?","Cheese curds", new List<string>{"Mustard","Tortilla chips","Parmesan shavings"}),
            new Question("What was the main dish at medieval Christmas feasts?","Roasted Pig", new List<string>{"Turkey","Peacock","Cornish Hen"}),
            new Question("“Eating good in the neighborhood” is the slogan of what restaurant chain?","Applebees", new List<string>{"Texas Roadhouse","Chilis","TGIF"}),
            new Question("Agar-agar is a jelly obtained by boiling several kinds of what edible food stuff together?","Seaweed", new List<string>{"Horse hooves","Tapioca","Collagen"}),
            new Question("A delicacy in Scotland, haggis is served inside what animal part?","Sheeps stomach", new List<string>{"Crabs shell","Pigs trotter","Cows intestine"}),
            new Question("Often used to add a flavorful boost to sushi, wasabi has a flavor very similar to what?","Horseradish", new List<string>{"Worcestershire sauce","Jalapeno","Mayonnaise"}),
            new Question("Steak tartare is served in what way?","Raw", new List<string>{"Grilled","On the bone","Sliced"}),
            new Question("From what country did Prawn Crackers (Krupuk) originate?","Indonesia", new List<string>{"China","The Philippines","Japan"}),
            new Question("In what country was The Lord of the Rings trilogy shot?","New Zealand", new List<string>{"Croatia","Iceland","Ireland"}),
            new Question("In Thor: Love and Thunder, what is the name of Thors new axe called?","Stormbreaker", new List<string>{"Bowcaster","Jarnbjorn","Thunderstrike"}),
            new Question("Which Tropic Thunder character was based on the combination of Russel Crowe, Daniel Day-Lewis and Colin Farrell?","Kirk Lazarus", new List<string>{"Tugg Speedman","Les Grossman","Alpa Chino"}),
            new Question("In 2015, which European city hosted the first Lollapalooza concert outside of the USA?","Berlin", new List<string>{"Barcelona","Madrid","Budapest"}),
            new Question("Which of New York Citys five boroughs is the most populous, with over 2.5 million people in 2014?","Brooklyn", new List<string>{"Queens","Manhattan","Staten Island"}),
            new Question("Can you name the capital of Mexico?","Mexico City", new List<string>{"Oaxaca","Chihuahua","Havana"}),
            new Question("Who is Taylor Swifts “We Are Never Getting Back Together” allegedly about?","Jake Gyllenhaal", new List<string>{"Harry Styles","Taylor Lautner","John Mayer"})
        };
    }
}
