using NUnit.Framework;
using System;
using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Tests.Model
{
    public class WagoTimeTests
    {
        private WagoTime _wagoTime;

        [SetUp]
        public void Setup()
        {
            _wagoTime = new WagoTime();
        }

        [Test]
        public void SetTimeValue_InvalidLength_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("123");
            });
        }
        [Test]
        public void SetTimeValue_InvalidFormat_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("qwer");
            });
        }
        [Test]
        public void SetTimeValue_InvalidTimeBase1_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("t#12g");
            });
        }
        [Test]
        public void SetTimeValue_InvalidTimeBase2_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("t#12ss");
            });
        }
        [Test]
        public void SetTimeValue_InvalidTimeBase3_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("t#12mms");
            });
        }
        [Test]
        public void SetTimeValue_NoTimeBase_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("t#13");
            });
        }
        [Test]
        public void SetTimeValue_NumbersInGroups_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("t#13d23ms");
            });
        }
        [Test]
        public void SetTimeValue_NegativeValue_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("t#-33s");
            });
        }
        [Test]
        public void SetTimeValue_AdditionalCharacters_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
            {
                _wagoTime.SetTimeValue("t##@33s");
            });
        }
        [Test]
        public void SetTimeValue_Valid12Day_12Day()
        {
            _wagoTime.SetTimeValue("t#12d");
            Assert.AreEqual(_wagoTime, new WagoTime() { TimeValue = 12, TimeBase = "d" });
        }
        [Test]
        public void SetTimeValue_Valid1Hour_1Hour()
        {
            _wagoTime.SetTimeValue("t#1h");
            Assert.AreEqual(_wagoTime, new WagoTime() { TimeValue = 1, TimeBase = "h" });
        }
        [Test]
        public void SetTimeValue_Valid543Minute_543Minute()
        {
            _wagoTime.SetTimeValue("T#543m");
            Assert.AreEqual(_wagoTime, new WagoTime() { TimeValue = 543, TimeBase = "m" });
        }
        [Test]
        public void SetTimeValue_Valid230Second_230Second()
        {
            _wagoTime.SetTimeValue("T#230s");
            Assert.AreEqual(_wagoTime, new WagoTime() { TimeValue = 230, TimeBase = "s" });
        }
        [Test]
        public void SetTimeValue_Valid100Milisecond_100Milisecond()
        {
            _wagoTime.SetTimeValue("t#100ms");
            Assert.AreEqual(_wagoTime, new WagoTime() { TimeValue = 100, TimeBase = "ms" });
        }
    }
}
