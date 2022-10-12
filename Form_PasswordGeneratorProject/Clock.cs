using System;
using Timer = System.Windows.Forms.Timer;

namespace Form_PasswordGeneratorProject {
    public class Clock : Singleton<Clock> {
        private readonly Timer _timer = new Timer();
        public event EventHandler Tick;
        public Clock() {
            _timer.Interval = Globals.DelayBetweenFramesInMs();
            _timer.Tick += OnTick;
            _timer.Start();
        }

        private void OnTick(object sender, EventArgs e) {
            if (Tick != null) Tick.Invoke(this, EventArgs.Empty);
        }
        
    }
}