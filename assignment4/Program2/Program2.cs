using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace assignment4
{
    public class Time
    {

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Time(int hour = 0, int minute = 0, int second = 0)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public override string ToString()
        {
            return Hour + ":" + Minute + ":" + Second;
        }
    }
    class AlarmClock
    {
        public event Action<AlarmClock> Tick;
        public event Action<AlarmClock> Alarm;

        public Time TimeNow { get; set; }
        public Time AlarmTime { get; set; }

        public AlarmClock(int h, int m, int s) 
        {
            Tick += a => Console.WriteLine(a.TimeNow);
            Alarm += a => Console.WriteLine("Alarming!");
            TimeNow = new Time();
            AlarmTime = new Time(h,m,s);
        }

        public void TickAndAlarm() //走时&响铃
        {
            int s = 0;
            Console.WriteLine("The alarmclock starts to tick!");
            while(true)
            {
                DateTime dateTime = DateTime.Now;
                TimeNow = new Time(dateTime.Hour, dateTime.Minute, dateTime.Second);
                Tick(this);
                if(TimeNow.ToString() == AlarmTime.ToString()) { Alarm(this); }
                Thread.Sleep(1000); //挂起一秒
                s++;
                if(s == 100) { break; }
            }
            Console.WriteLine("The alarmclock stops to tick!");
        }
    }

    internal class Program2
    {
        public static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            AlarmClock alarmClock = new AlarmClock(11,28,45);
            alarmClock.TickAndAlarm();
        }
    }
}
