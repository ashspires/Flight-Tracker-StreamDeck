﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightStreamDeck.Logics;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SixLabors.ImageSharp;

namespace FlightStreamDeck.Logics.Tests
{
    [TestClass()]
    public class ImageLogicTests
    {
        [TestMethod()]
        public void GetImageTest()
        {
            ImageLogic images = new ImageLogic();

            string result = images.GetHorizonImage(30, 20, 359);
            
            var path = @"result\export.png";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream fs = File.Create(path))
            {
                var bytes = Convert.FromBase64String(result.Substring(23));
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}