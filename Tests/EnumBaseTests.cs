﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public class EnumBaseTests<T> : BaseTests where T : Enum
    {
        protected T value;
        protected Type type;
        [TestInitialize]
        public void TestInitialize()
        {
            type = typeof(T);
            value = GetRandom.EnumOf<T>();
        }
    }
}
