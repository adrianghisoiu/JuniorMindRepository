using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlarmClock
{
    [TestClass]
    public class AlarmClock
    {
        [TestMethod]
        public void TestTooSeeIfTheAlarmIsOn()
        {
            Alarm[] alarm = new Alarm[] { new Alarm( 5, Days.Monday | Days.Friday | Days.Saturday) };
            Assert.IsTrue(FindIfTheAlarmIsOn(alarm, Days.Monday, 5));
        }


        [Flags]
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }

        struct Alarm
        {
            public Days day;
            public int hour;

            public Alarm(int hour, Days day)
            {
                this.hour = hour;
                this.day = day;
            }
        }

        bool FindIfTheAlarmIsOn(Alarm[] clockAlarm, Days day, int hour)
        {
            for (int i = 0; i < clockAlarm.Length; i++)
            {
                if (((clockAlarm[i].day & day) != 0) && ((clockAlarm[i].hour & hour) != 0))
                    return true;
            }

            return false;
        }
    }
}