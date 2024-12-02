using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TimeTrackerBeta
{
    public partial class MainForm : Form
    {
        private DateTime startTime; //Declares a variable to store when the timer begins.
        private TimeSpan originalTime; //Declares a variable to store the original value of the time indicated in the textbox.
        private string dayOfWeek = DateTime.Now.DayOfWeek.ToString(); //Variable stores the day of the week.
        //Streamwriter and Streamreader for file input and output.
        private StreamWriter writeToFile;
        private StreamReader readFromFile;

        public MainForm()
        {
            InitializeComponent(); //Default initialization method. DO NOT TOUCH!
            switch (dayOfWeek)
            {
                case "Sunday":
                    SundayButton.Checked = true;
                    break;
                case "Monday":
                    MondayButton.Checked = true;
                    break;
                case "Tuesday":
                    TuesdayButton.Checked = true;
                    break;
                case "Wednesday":
                    WednesdayButton.Checked = true;
                    break;
                case "Thursday":
                    ThursdayButton.Checked = true;
                    break;
                case "Friday":
                    FridayButton.Checked = true;
                    break;
                case "Saturday":
                    SaturdayButton.Checked = true;
                    break;
            }
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            //If the timer isn't started, start it. Otherwise, stop it.
            if (TimeTracker.Enabled == false)
            {
                TimerButton.BackgroundImage = Image.FromFile(@"Images\ButtonStop.bmp");
                TimeTracker.Start();
                originalTime = TimeSpan.Parse(GetTimeFromTextBox()); //Obtains the original value in the textbox.
                startTime = DateTime.Now; //Initializes the value of the variable when the timer starts.
            } else
            {
                TimerButton.BackgroundImage = Image.FromFile(@"Images\ButtonStart.bmp");
                TimeTracker.Stop();
            }
        }
        private void TimeTracker_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime; //Calculates the elapsed time since the start/stop button was clicked.
            TimeSpan totalTime = originalTime + elapsedTime; //Adds the elapsed time to the orignal time stored when the timer starts.
            if (SundayButton.Checked) //Updates the value stored in the appropriate Textbox based on which radio button is checked.
            {
                SundayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
            }
            else if (MondayButton.Checked)
            {
                MondayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
            }
            else if (TuesdayButton.Checked)
            {
                TuesdayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
            }
            else if (WednesdayButton.Checked)
            {
                WednesdayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
            }
            else if (ThursdayButton.Checked)
            {
                ThursdayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
            }
            else if (FridayButton.Checked)
            {
                FridayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
            }
            else
            {
                SaturdayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
            }
            AddTimes();
        }
        private string GetTimeFromTextBox()
        {
            //Logic structure checks which radio button is checked and returns text from the appropriate source.
            if (SundayButton.Checked)
            {
                return SundayTime.Text;
            }
            else if (MondayButton.Checked)
            {
                return MondayTime.Text;
            } 
            else if (TuesdayButton.Checked)
            {
                return TuesdayTime.Text;
            }
            else if (WednesdayButton.Checked)
            {
                return WednesdayTime.Text;
            }
            else if (ThursdayButton.Checked)
            {
                return ThursdayTime.Text;
            }
            else if (FridayButton.Checked)
            {
                return FridayTime.Text;
            }
            else
            {
                return SaturdayTime.Text;
            }
        }
        private void AddTimes() //Function to add all the timers and return the total.
        {
            //Initializing the times of the days to add
            TimeSpan sunday = TimeSpan.Parse(SundayTime.Text);
            TimeSpan monday = TimeSpan.Parse(MondayTime.Text);
            TimeSpan tuesday = TimeSpan.Parse(TuesdayTime.Text);
            TimeSpan wednesday = TimeSpan.Parse(WednesdayTime.Text);
            TimeSpan thursday = TimeSpan.Parse(ThursdayTime.Text);
            TimeSpan friday = TimeSpan.Parse(FridayTime.Text);
            TimeSpan saturday = TimeSpan.Parse(SaturdayTime.Text);

            //New TimeSpan to store the totals of all the days of the week.
            TimeSpan total = sunday + monday + tuesday + wednesday + thursday + friday + saturday;
            TotalTime.Text = total.ToString(@"hh\:mm\:ss\.ff");
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveDialog.ShowDialog() == DialogResult.OK) //Opens the SaveDialog and executes if the result is OK.
            {
                var destinationFile = SaveDialog.FileName; //Sets the name of the destination file.
                writeToFile = new StreamWriter(destinationFile);
                //Each value from the textboxes is copied to the new file.
                writeToFile.WriteLine(SundayTime.Text);
                writeToFile.WriteLine(MondayTime.Text);
                writeToFile.WriteLine(TuesdayTime.Text);
                writeToFile.WriteLine(WednesdayTime.Text);
                writeToFile.WriteLine(ThursdayTime.Text);
                writeToFile.WriteLine(FridayTime.Text);
                writeToFile.WriteLine(SaturdayTime.Text);

                writeToFile.Close();
            }
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadDialog.ShowDialog() == DialogResult.OK) //Opens the LoadDialog and executes if the result is OK.
            {
                var sourceFile = LoadDialog.FileName; //Sets the source file to be read from.
                readFromFile = new StreamReader(sourceFile);
                //Reads each time from each line.
                SundayTime.Text = readFromFile.ReadLine();
                MondayTime.Text = readFromFile.ReadLine();
                TuesdayTime.Text = readFromFile.ReadLine();
                WednesdayTime.Text = readFromFile.ReadLine();
                ThursdayTime.Text = readFromFile.ReadLine();
                FridayTime.Text = readFromFile.ReadLine();
                SaturdayTime.Text = readFromFile.ReadLine();

                readFromFile.Close();
                //After reading the times from the file, automatically add the times up using the provided method.
                AddTimes();
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
