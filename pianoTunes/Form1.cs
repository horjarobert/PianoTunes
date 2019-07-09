using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Speech.Synthesis;

namespace pianoTunes
{
    public partial class piano : Form
    {
        //Object to all notes
        SoundPlayer c1 = new SoundPlayer();
        SoundPlayer cSharp = new SoundPlayer();
        SoundPlayer d1 = new SoundPlayer();
        SoundPlayer dSharp = new SoundPlayer();
        SoundPlayer e1 = new SoundPlayer();
        SoundPlayer f1 = new SoundPlayer();
        SoundPlayer fS = new SoundPlayer();
        SoundPlayer g1 = new SoundPlayer();
        SoundPlayer gSharp = new SoundPlayer();
        SoundPlayer a1 = new SoundPlayer();
        SoundPlayer aSharp = new SoundPlayer();
        SoundPlayer b1 = new SoundPlayer();
        SoundPlayer c2 = new SoundPlayer();


        public piano()
        {
            InitializeComponent();

            //Path for each note; notice that the file must have the '.wav' extension (I converted each .mp3 to .wav)
            c1.SoundLocation = "C1.wav";
            cSharp.SoundLocation = "C1#.wav";
            d1.SoundLocation = "D1.wav";
            dSharp.SoundLocation = "D1#.wav";
            e1.SoundLocation = "E1.wav";
            f1.SoundLocation = "F1.wav";
            fS.SoundLocation = "fS.wav";
            g1.SoundLocation = "G1.wav";
            gSharp.SoundLocation = "G1#.wav";
            a1.SoundLocation = "A1.wav";
            aSharp.SoundLocation = "A1#.wav";
            b1.SoundLocation = "B1.wav";
            c2.SoundLocation = "C2.wav";

            //My welcome for visitors ... you can also change the text from below, make it in your own way/style
            SpeechSynthesizer well = new SpeechSynthesizer();
            well.Speak("Welcome to pianoTunes! By Horja Robert Emanuel!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Play all notes (the impulse needed)
        private void button1_Click(object sender, EventArgs e)
        {
            c1.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            c2.Play();
        }

        private void labelC1_Click(object sender, EventArgs e)
        {
            c1.Play();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            e1.Play();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            cSharp.Play();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            dSharp.Play();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCsharp_Click(object sender, EventArgs e)
        {
            cSharp.Play();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            d1.Play();
        }

        private void btnDsharp_Click(object sender, EventArgs e)
        {
            dSharp.Play();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            e1.Play();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            f1.Play();
        }

        private void btnFsharp_Click(object sender, EventArgs e)
        {
            fS.Play();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            g1.Play();
        }

        private void btnGsharp_Click(object sender, EventArgs e)
        {
            gSharp.Play();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            a1.Play();
        }

        private void btnAsharp_Click(object sender, EventArgs e)
        {
            aSharp.Play();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            b1.Play();
        }

        private void labelAsharp_Click(object sender, EventArgs e)
        {
            aSharp.Play();

        }

        private void labelDbemol_Click(object sender, EventArgs e)
        {
            cSharp.Play();

        }

        private void labelEbemol_Click(object sender, EventArgs e)
        {
            dSharp.Play();

        }

        private void labelD_Click(object sender, EventArgs e)
        {
            d1.Play();

        }

        private void labelF_Click(object sender, EventArgs e)
        {
            f1.Play();

        }

        private void labelFsharp_Click(object sender, EventArgs e)
        {
            fS.Play();

        }

        private void labelGbemol_Click(object sender, EventArgs e)
        {
            fS.Play();

        }

        private void labelG_Click(object sender, EventArgs e)
        {
            g1.Play();

        }

        private void labelGsharp_Click(object sender, EventArgs e)
        {
            gSharp.Play();

        }

        private void labelAbemol_Click(object sender, EventArgs e)
        {
            gSharp.Play();

        }

        private void labelA_Click(object sender, EventArgs e)
        {
            a1.Play();

        }

        private void labelBbemol_Click(object sender, EventArgs e)
        {
            aSharp.Play();

        }

        private void labelB_Click(object sender, EventArgs e)
        {
            b1.Play();

        }

        private void labelC2_Click(object sender, EventArgs e)
        {
            c2.Play();

        }

        //ToolTip for each note
        private void btnC1_MouseHover(object sender, EventArgs e)
        {
            ToolTip C1 = new ToolTip();
            C1.SetToolTip(this.btnC1, "Click me!");
        }

        private void btnD_MouseHover(object sender, EventArgs e)
        {
            ToolTip D1 = new ToolTip();
            D1.SetToolTip(this.btnD, "Click me!");
        }

        private void btnE_MouseHover(object sender, EventArgs e)
        {
            ToolTip E1 = new ToolTip();
            E1.SetToolTip(this.btnE, "Click me!");
        }

        private void btnF_MouseHover(object sender, EventArgs e)
        {
            ToolTip F1 = new ToolTip();
            F1.SetToolTip(this.btnF, "Click me!");
        }

        private void btnG_MouseHover(object sender, EventArgs e)
        {
            ToolTip G1 = new ToolTip();
            G1.SetToolTip(this.btnG, "Click me!");
        }

        private void btnA_MouseHover(object sender, EventArgs e)
        {
            ToolTip A1 = new ToolTip();
            A1.SetToolTip(this.btnA, "Click me!");
        }

        private void btnB_MouseHover(object sender, EventArgs e)
        {
            ToolTip B1 = new ToolTip();
            B1.SetToolTip(this.btnB, "Click me!");
        }

        private void btnC2_MouseHover(object sender, EventArgs e)
        {
            ToolTip C2 = new ToolTip();
            C2.SetToolTip(this.btnC2, "Click me!");
        }

        private void btnCsharp_MouseHover(object sender, EventArgs e)
        {
            ToolTip Csharp = new ToolTip();
            Csharp.SetToolTip(this.btnCsharp, "Play me!");
        }

        private void btnDsharp_MouseHover(object sender, EventArgs e)
        {
            ToolTip Dsharp = new ToolTip();
            Dsharp.SetToolTip(this.btnDsharp, "Play me!");
        }

        private void btnFsharp_MouseHover(object sender, EventArgs e)
        {
            ToolTip Fsharp = new ToolTip();
            Fsharp.SetToolTip(this.btnFsharp, "Play me!");
        }

        private void btnGsharp_MouseHover(object sender, EventArgs e)
        {
            ToolTip Gsharp = new ToolTip();
            Gsharp.SetToolTip(this.btnGsharp, "Play me!");
        }

        private void btnAsharp_MouseHover(object sender, EventArgs e)
        {
            ToolTip Asharp = new ToolTip();
            Asharp.SetToolTip(this.btnAsharp, "Play me!");
        }
    }
}
