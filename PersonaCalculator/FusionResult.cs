﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaCalculator
{ 
    class FusionResult
    {
        public PersonasContainer DB { get; set; }
        //public Arcana[] Arcanas { get; set; }
        public Persona Parent1 { get; set; }
        public Persona Parent2 { get; set; }
        public Persona Result { get; set; }
        private int[,] ResultKeys = new int[,]
        {
            {1,15,14,19,14,8,4,20,2,12,2,2,12,10,6,15,18,4,5,16,13},
            {15,2,19,9,12,16,14,15,12,4,7,9,20,5,12,20,13,0,18,8,7},
            {14,19,3,10,4,20,5,6,10,14,13,9,19,2,6,9,2,5,18,16,20},
            {19,9,10,4,19,14,9,9,2,2,18,6,15,8,16,3,10,8,15,3,3},
            {14,12,4,19,5,4,9,15,16,3,7,10,4,19,20,19,18,14,2,8,7},
            {8,16,20,14,4,6,14,20,15,9,3,20,14,16,2,5,13,19,4,12,8},
            {4,14,5,13,9,14,7,6,3,2,18,5,19,18,6,6,18,10,13,16,12},
            {20,15,6,9,15,20,6,8,15,9,16,2,14,10,2,19,13,6,20,12,15},
            {2,12,10,2,16,15,3,15,9,12,7,15,3,12,10,2,7,19,12,15,7},
            {12,4,14,2,3,9,2,9,12,10,4,6,19,20,2,9,14,9,4,15,18},
            {2,7,13,18,7,3,18,16,7,4,11,18,14,10,16,5,8,5,7,3,13},
            {2,9,9,6,10,20,5,2,15,6,18,12,6,13,20,10,13,5,9,15,0},
            {12,20,19,15,4,14,19,14,3,19,14,6,13,3,14,9,10,4,3,16,4},
            {10,5,2,8,19,16,18,10,12,20,10,13,3,14,8,18,7,7,3,4,0},
            {6,12,6,16,20,2,6,2,10,2,16,20,14,8,15,10,18,6,13,10,0},
            {15,20,9,3,19,5,6,19,2,9,5,10,9,18,10,16,5,5,4,6,0},
            {18,13,2,10,18,13,18,13,7,14,8,13,10,7,18,5,17,13,3,8,0},
            {4,0,5,8,14,19,10,6,19,9,5,5,4,7,6,5,13,18,5,19,0},
            {5,18,18,15,2,4,13,20,12,4,7,9,3,3,13,4,3,5,19,12,0},
            {16,8,16,3,8,12,16,12,15,15,3,15,16,4,10,6,8,19,12,20,0},
            {13,7,20,3,7,8,12,15,7,18,13,0,4,0,0,0,0,0,0,0,21}
        };

    public FusionResult(Persona parent1, Persona parent2)
        {
            Parent1 = parent1;
            Parent2 = parent2;
        }

        public Persona CheckPersonaResult(Persona p1, Persona p2)
        {
            var arcanaQuery = DB.Personas.Where(p => p.Arcana == CheckArcana(p1, p2));
            double levelAverage = Math.Ceiling((double)(p1.Level + p2.Level) / 2);

            Persona Result = arcanaQuery.Where(p => p.Level >= levelAverage).First();
            return Result;
        }

        public Arcana CheckArcana(Persona p1, Persona p2)
        {
            int resultKey = ResultKeys[p1.Arcana.Id, p2.Arcana.Id];
            if (resultKey == 0)
            {
                return DB.Arcanas.Where(k => k.Id == 1002).First();
            }
            else
            {
                return DB.Arcanas.Where(k => k.Id == resultKey).First();
            }
        }
    }
}
