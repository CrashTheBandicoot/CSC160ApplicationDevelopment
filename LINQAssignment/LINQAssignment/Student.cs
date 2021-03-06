﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
        public override string ToString()
        {
            return $"Name: {First} {Last}, ID: {ID}, Scores: {Scores.ListConcat()}";
        }
    }
}