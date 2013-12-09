using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace VisualAsterisk.Test.Simulator
{
    public abstract class SimulatorBase
    {
        public SimulatorBase()
        {
            m_Timer = new System.Timers.Timer();
            m_Timer.Interval = 1000;
            m_Timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
        }
        public abstract void Start();
        public abstract void Stop();

        protected abstract void Timer_Elapsed(object sender, ElapsedEventArgs e);

        protected System.Timers.Timer m_Timer;        
    }
}
