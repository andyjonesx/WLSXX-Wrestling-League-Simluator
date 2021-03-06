﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.Model.Enumerations;

namespace WLSXX.Model
{
    public class Move
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int LowerDamage { get; set; }
        public int UpperDamage { get; set; }
        public int LowerSelfDamage { get; set; }
        public int UpperSelfDamage { get; set; }
        public int Chance { get; set; }
        public bool CanPin { get; set; }
        public int PinModifier { get; set; }
        public bool CanSubmit { get; set; }
        public int SubmitModifier { get; set; }
        public Attributes RecommendedAttributes { get; set; }
        public LocationEnum WrestlerLocation { get; set; }
        public LocationEnum OpponentLocation { get; set; }
        public LocationEnum WrestlerNewLocation { get; set; }
        public int WrestlerNewLocationChance { get; set; }
        public LocationEnum OpponentNewLocation { get; set; }
        public int OpponentNewLocationChance { get; set; }
        public bool Stunned { get; set; }
        public bool CanStun { get; set; }
        public bool AssignOnly { get; set; }
    }
}
