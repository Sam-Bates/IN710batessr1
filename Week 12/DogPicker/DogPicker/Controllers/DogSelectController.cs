﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DogPicker.Models;
namespace DogPicker.Controllers
{
    public class DogSelectController : Controller
    {
        List<Dog> dogList;
        const int MATCHINGPOINT = 10;
        const int CLOSEMATCH = 5;
        // GET: DogSelect
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ChooseDog()
        {
            return View();// return the choosing view
        }
        [HttpPost]
        public ActionResult ChooseDog(bool GoodWithChildren, bool Drools, ELength Coatlength, ESize Size, EScale ActivityLevel, EScale SheddingLevel, EScale GroomingLevel, EScale IntelligenceLevel)
        {
            dogList = makeDatabase();

            //create a half-baked dog that has all the parameters the user would prefer
            Dog idealDog = new Dog();
            idealDog.GoodWithChildren = GoodWithChildren;
            idealDog.Drools = Drools;
            idealDog.CoatLength = Coatlength;
            idealDog.Size = Size;
            idealDog.ActivityLevel = ActivityLevel;
            idealDog.SheddingLevel = SheddingLevel;
            idealDog.GroomingLevel = GroomingLevel;
            idealDog.IntelligenceLevel = IntelligenceLevel;


            idealDog = calculateIdealDog(idealDog, dogList);

            return View("resultView", idealDog);
        }
        private Dog calculateIdealDog(Dog dog, List<Dog> dogList)
        {
            int[] scores = new int[dogList.Count];
            int count = 0;
            //loop through the dog list and caluclate a score for each dog
            foreach (var currDog in dogList)
            {
                scores[count] += calculateScore((int)currDog.ActivityLevel, (int)dog.ActivityLevel);
                scores[count] += calculateScore((int)currDog.SheddingLevel, (int)dog.SheddingLevel);
                scores[count] += calculateScore((int)currDog.GroomingLevel, (int)dog.GroomingLevel);
                scores[count] += calculateScore((int)currDog.IntelligenceLevel, (int)dog.IntelligenceLevel);
                scores[count] += calculateScoreBool(currDog.GoodWithChildren, dog.GoodWithChildren);
                scores[count] += calculateScoreBool(currDog.Drools, dog.Drools);
                scores[count] += calculateScore((int)currDog.CoatLength, (int)dog.CoatLength);
                scores[count] += calculateScore((int)currDog.Size, (int)dog.Size);
                count++;
            }

            //get the max value's index
            int maxIndex = -1, maxValue = -1, i = 0;
            foreach (int currIndex in scores)
            {
                if ((maxIndex < 0) || (currIndex > maxValue))
                {
                    maxValue = currIndex;
                    maxIndex = i;
                }
                i++;
            }

            return dogList[maxIndex];
        }
        public int calculateScore(int currdogValue, int newdogValue)
        {
            //check if the value is the same or if it is close
            if (newdogValue == 0)
            {
                return MATCHINGPOINT;
            }
            if (currdogValue == newdogValue)
            {
                return MATCHINGPOINT;
            }
            if (currdogValue == newdogValue + 1 || currdogValue == newdogValue - 1)
            {
                return CLOSEMATCH;
            }
            return 0;//no points
        }
        public int calculateScoreBool(bool currdogBool, bool newdogBool)
        {
            if (currdogBool == newdogBool)
            {
                return MATCHINGPOINT;
            }
            return 0;//no points
        }
        private List<Dog> makeDatabase()
        {
            List<Dog> newDatabase = new List<Dog>();

            Dog afghanHound = new Dog();
            afghanHound.BreedName = "afghanHound";
            afghanHound.DisplayName = "Afghan Hound";
            afghanHound.ActivityLevel = EScale.High;
            afghanHound.CoatLength = ELength.Long;
            afghanHound.Drools = false;
            afghanHound.GoodWithChildren = false;
            afghanHound.GroomingLevel = EScale.High;
            afghanHound.IntelligenceLevel = EScale.Low;
            afghanHound.SheddingLevel = EScale.High;
            afghanHound.Size = ESize.Large;
            afghanHound.ImageName = "AfghanHound.jpg";
            newDatabase.Add(afghanHound);


            Dog bassetHound = new Dog();
            bassetHound.BreedName = "BassetHound";
            bassetHound.DisplayName = "Basset Hound";
            bassetHound.ActivityLevel = EScale.Medium;
            bassetHound.CoatLength = ELength.Short;
            bassetHound.Drools = true;
            bassetHound.GoodWithChildren = true;
            bassetHound.GroomingLevel = EScale.Low;
            bassetHound.IntelligenceLevel = EScale.Medium;
            bassetHound.SheddingLevel = EScale.Low;
            bassetHound.Size = ESize.Medium;
            bassetHound.ImageName = "BassetHound.jpg";
            newDatabase.Add(bassetHound);

            Dog beagle = new Dog()
            {
                BreedName = "Beagle",
                DisplayName = "Beagle",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "Beagle.jpg"
            };
            newDatabase.Add(beagle);

            Dog bichonFrise = new Dog()
            {
                BreedName = "BichonFrise",
                DisplayName = "Bichon Frise",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Small,
                ImageName = "Bichonfrise.jpg"
            };
            newDatabase.Add(bichonFrise);



            Dog borzoi = new Dog()
            {
                BreedName = "Borzoi",
                DisplayName = "Borzoi",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "Borzoi.jpg"
            };
            newDatabase.Add(borzoi);

            Dog bulldog = new Dog()
            {
                BreedName = "Bulldog",
                DisplayName = "Bull Dog",
                ActivityLevel = EScale.Medium,
                CoatLength = ELength.Short,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Low,
                Size = ESize.Medium,
                ImageName = "Bulldog.jpg"
            };
            newDatabase.Add(bulldog);


            Dog cav = new Dog()
            {
                BreedName = "CavalierKingCharlesSpaniel",
                DisplayName = "Cavalier King Charles Spaniel",
                ActivityLevel = EScale.Medium,
                CoatLength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "CavalierKingCharlesSpaniel.jpg"
            };
            newDatabase.Add(cav);


            Dog chowchow = new Dog()
            {
                BreedName = "Chowchow",
                DisplayName = "Chow Chow",
                ActivityLevel = EScale.Medium,
                CoatLength = ELength.Long,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "Chowchow.jpg"
            };
            newDatabase.Add(chowchow);

            Dog dalmation = new Dog()
            {
                BreedName = "Dalmation",
                DisplayName = "Dalmation",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Short,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Low,
                Size = ESize.Large,
                ImageName = "Dalmation.jpg"
            };
            newDatabase.Add(dalmation);

            Dog goldenRetriever = new Dog()
            {
                BreedName = "GoldenRetriever",
                DisplayName = "Golden Retriever",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Large,
                ImageName = "GoldenRetriever.jpg"
            };
            newDatabase.Add(goldenRetriever);

            Dog maltese = new Dog()
            {
                BreedName = "Maltese",
                DisplayName = "Maltese",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Miniature,
                ImageName = "Maltese.jpg"
            };
            newDatabase.Add(maltese);

            Dog newfoundland = new Dog()
            {
                BreedName = "Newfoundland",
                DisplayName = "Newfoundland",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "newfoundland.jpg"
            };
            newDatabase.Add(newfoundland);

            Dog oldEnglishSheepdog = new Dog()
            {
                BreedName = "OldEnglishSheepdog",
                DisplayName = "Old English Sheepdog",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = EScale.High,
                IntelligenceLevel = EScale.Medium,
                SheddingLevel = EScale.High,
                Size = ESize.Giant,
                ImageName = "OldEnglishSheepdog.jpg"
            };
            newDatabase.Add(oldEnglishSheepdog);

            Dog pug = new Dog()
            {
                BreedName = "Pug",
                DisplayName = "Pug",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Low,
                IntelligenceLevel = EScale.Low,
                SheddingLevel = EScale.Low,
                Size = ESize.Miniature,
                ImageName = "Pug.jpg"
            };
            newDatabase.Add(pug);


            Dog westHighlandWhiteTerrier = new Dog()
            {
                BreedName = "WestHighlandWhiteTerrier",
                DisplayName = "West Highland White Terrier",
                ActivityLevel = EScale.High,
                CoatLength = ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = EScale.Medium,
                IntelligenceLevel = EScale.High,
                SheddingLevel = EScale.Medium,
                Size = ESize.Small,
                ImageName = "WestHighlandWhiteTerrier.jpg"
            };
            newDatabase.Add(westHighlandWhiteTerrier);

            return newDatabase;
        }
    }
}