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
  }
}