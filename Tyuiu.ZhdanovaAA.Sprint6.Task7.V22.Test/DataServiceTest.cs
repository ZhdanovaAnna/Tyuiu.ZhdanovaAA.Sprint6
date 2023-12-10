﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ZhdanovaAA.Sprint6.Task7.V22.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task7.V22.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V22.csv";
            int[,] res = ds.GetMatrix(path);

            int[,] wait = new int[10, 10] { { 0, 5, -13, -2, -11, 19, -8, -2, 16, 20},
                                            {4, -3, -8, 19, 7, 13, -16, 10, 4, 5},
                                            {12, -12, 20, -16, 20, -14, 17, -2, 10, 8},
                                            { 6, -5, -4, 8, -16, -5, -18, -12, 14, -16},
                                            { -8, 18, -17, -8, -4, 111, -12, 9, 2, 11},
                                            {0, -8, -19, 14, 20, 111, 1, -3, 3, 3},
                                            {16, 17, 7, 2, -16, -7, 7, -15, -2, -15},
                                            {4, 7, 6, 15, -1, -19, 15, -4, -17, -11},
                                            { -11, -13, 2, -5, 19, -18, -9, 9, 19, -1 },
                                            { -7, -7, 9, -11, 8, 111, -1, -11, -7, 19 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
