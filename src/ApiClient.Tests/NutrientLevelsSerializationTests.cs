﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using OpenFoodFacts4Net.ApiClient.Data;
using Xunit;

namespace OpenFoodFacts4Net.ApiClient.Tests
{
    public class NutrientLevelsSerializationTests
    {
        [Fact]
        public void Should_Deserialize_NutrientLevels_01()
        {
            string productJson = DataSetHelper.ReadFileContent("NutrientLevels.01.json");
            NutrientLevels nutrientLevels = JsonConvert.DeserializeObject<NutrientLevels>(productJson);

            Assert.Equal(NutrimentLevel.Moderate, nutrientLevels.Salt);
            Assert.Equal(NutrimentLevel.Low, nutrientLevels.SaturatedFat);
            Assert.Equal(NutrimentLevel.High, nutrientLevels.Fat);
            Assert.Equal(NutrimentLevel.Moderate, nutrientLevels.Sugars);
        }
    }
}
