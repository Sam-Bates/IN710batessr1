using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;
        delegate void updateForm();//create void delegate
        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
        }
        public void setSpinBox()//this gets bound to the updateForm delegate
        {
            spinBox.Value++;  
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            if (spinBox.InvokeRequired)//check if it's not thread safe?
            {
                updateForm d = new updateForm(setSpinBox);//attach method to delegate
                spinBox.Invoke(d);//call the invoke method and pass in only the delegate because there is no data to send.
            }
            else
            {
                setSpinBox();
            }
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        delegate void updateForm(DateTime dt);//create delegate that takes in dateTime signature
        private ListBox listBox;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }
        public void setDateTime(DateTime dt)//method that will be bound to updateForm delegate
        {
            listBox.Items.Add(dt.ToString());  
        }
        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            DateTime dt = e.currentTime;//metronomeEventArgs comes with dateTime, so set it
            if (listBox.InvokeRequired)//not entirely sure what this means but I know I need it.
            {
                updateForm d = new updateForm(setDateTime);//attach setDateTime method to the delegate
                listBox.Invoke(d, dt);//call the invoke method and pass in the delegate(that has the setDateTime attached) and pass in the dateTime object
            }
            else
            {
                setDateTime(dt);
            }
        }
    }
}
