using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places;
using System.Collections.Generic;
using System;

namespace Places.Tests
{
  [TestClass]
  public class DiaryTests
  {
    [TestMethod]
    public void Diary_CreateDiaryClass_TypeOf()
    {
      Diary newDiary = new Diary();
      Assert.AreEqual(typeof(Diary), newDiary.GetType());
    }

    [TestMethod]
    public void Places_CreateObjectWithProperties_CityNameEquals()
    {
      Diary newDiary = new Diary();
      newDiary.CityName = "Phoenix";
      Assert.AreEqual(newDiary.CityName, "Phoenix");
    }

    [TestMethod]
    public void Places_CreateObjectWithProperties_DateEquals()
    {
      Diary newDiary = new Diary();
      newDiary.DateVisited = "March 8th";
      Assert.AreEqual(newDiary.DateVisited, "March 8th");
    }
  }
}