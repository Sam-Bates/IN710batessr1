﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogPicker.Models
{
    public class Dog
    {
        public string BreedName         { get; set; }
        public string DisplayName       { get; set; }
        public string ImageName         { get; set; }
        public EScale ActivityLevel     { get; set; }
        public EScale SheddingLevel     { get; set; }
        public EScale GroomingLevel     { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public bool GoodWithChildren    { get; set; }
        public bool Drools              { get; set; }
        public ELength CoatLength       { get; set; }
        public ESize Size               { get; set; }
    }
}