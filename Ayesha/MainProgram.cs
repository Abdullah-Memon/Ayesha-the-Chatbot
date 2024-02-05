using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using AIMLbot;
using System.IO;

namespace Ayesha
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        // Global functions and Variables
        Bot Ai;
        SpeechRecognitionEngine Default_rec_Engine = new SpeechRecognitionEngine();
        SpeechRecognitionEngine Interface_rec_Engine = new SpeechRecognitionEngine();
        SpeechSynthesizer Ayesha = new SpeechSynthesizer();
        Random smart = new Random();
        int timeout = 0, token = 0;
        bool s = true, active = true;

        /********************* Executing Commands Function *********************/
        private bool ExecuteCommands(string input)
        {
            string output = "output";
            int chk = 0;

            if (input == "open files")
            {
                output = "Opeing files";
                System.Diagnostics.Process.Start("explorer.exe");
                chk = 1;
            }
            else if (input == "search" || token != 0)
            {
                if (token == 0)
                {
                    output = "What do you want to search?";
                    token = 1;
                }
                else
                {
                    System.Diagnostics.Process.Start("www.google.com/searchq=" + input);
                    output = "Searching " + input;
                    token = 0;
                }
                chk = 1;
            }
            else
            {
                chk = 0;
            }

            // Switching between output methods
            if (chk == 0)
                return false;
            else
            {
                label2.Text = output;
                Ayesha.SpeakAsync(output);

                textBox.Text = string.Empty;
                textBox.Focus();

                return true;
            }
        }


        /********************* Main Load Function *********************/
        private void Ayesha_Load(object sender, EventArgs e)
        {
            Ai = new Bot();
            textualbox.Hide();
            Ayesha.SelectVoiceByHints(VoiceGender.Female);
        }
        
        /********************* Voice Commands *********************/
        // Mic Button Coding
        private void micbtn_Click(object sender, EventArgs e)
        {
            if (active)
            {
                micbtn.FillColor = Color.Red;
                active = false;

                Default_rec_Engine.SetInputToDefaultAudioDevice();
                Default_rec_Engine.LoadGrammar(new Grammar(new Choices(File.ReadAllLines(@"Commands\\DefaultCommands.txt"))));
                Default_rec_Engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_Speech);
                Default_rec_Engine.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(rec_Engine);
                Default_rec_Engine.RecognizeAsync(RecognizeMode.Multiple);

                Interface_rec_Engine.SetInputToDefaultAudioDevice();
                Interface_rec_Engine.LoadGrammar(new Grammar(new Choices(File.ReadAllLines(@"Commands\\ResumeListeningCommands.txt"))));
                Interface_rec_Engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Resume_rec_Engine);
            }
            else
            {
                Default_rec_Engine.RecognizeAsyncCancel();
                Interface_rec_Engine.RecognizeAsyncCancel();
                micbtn.FillColor = Color.Green;
                active = true;
            }
        }

        // all outputs will executed from here
        private void Default_Speech(object sender, SpeechRecognizedEventArgs e)
        {
            // first checking my commands
            if (!ExecuteCommands(e.Result.Text))
            {
                Ai.isAcceptingUserInput = true;

                User user = new User("User", Ai);

                Ai.loadSettings();
                Ai.loadAIMLFromFiles();

                Request request = new Request(textBox.Text, user, Ai);

                Result result = Ai.Chat(request);

                Ai.isAcceptingUserInput = false;

                label2.Text = result.Output;
                Ayesha.SpeakAsync(result.Output);

                textBox.Text = string.Empty;
                textBox.Focus();
            }
        }

        // cut the listening section after some time
        private void rec_Engine(object sender, SpeechDetectedEventArgs e)
        {
            timeout = 0;
        }
        // Resume the listenting section after listening specific commands
        private void Resume_rec_Engine(object sender, SpeechRecognizedEventArgs e)
        {
            string input = e.Result.Text;
            if (input == "listen")
            {
                //System.Diagnostics.Process.Start("explorer.exe");
                
            }
        }
        


        /********************* Textual Commands *********************/
        // Sent Button Coding
        private void sentbtn_Click(object sender, EventArgs e)
        {
            string input = textBox.Text;
            if (!ExecuteCommands(textBox.Text.ToLower()))
            {
                Ai.isAcceptingUserInput = true;

                User user = new User("User", Ai);

                Ai.loadSettings();
                Ai.loadAIMLFromFiles();

                Request request = new Request(input, user, Ai);

                Result result = Ai.Chat(request);

                Ai.isAcceptingUserInput = false;

                label2.Text = result.Output;
                Ayesha.SpeakAsync(result.Output);

                textBox.Text = string.Empty;
                textBox.Focus();
            }
            
        }

        // same sent button coding for Enter button
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                object a = new object();
                EventArgs b = new EventArgs();

                sentbtn_Click(a,b);
            }
        }

        // Cross button coding
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Switch button coding
        private void switchbtn_Click(object sender, EventArgs e)
        {
            if (s)
            {
                textualbox.Show();
                micbox.Hide();
                s = false;
            }
            else
            {
                textualbox.Hide();
                micbox.Show();
                s = true;
            }
        }

        // Timer coding
        private void voicetimer_Tick(object sender, EventArgs e)
        {
            if (timeout == 10)
            {
                Default_rec_Engine.RecognizeAsyncCancel();
            }
            if (timeout == 11)
            {
                voicetimer.Stop();
                timeout = 0;
                Interface_rec_Engine.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
