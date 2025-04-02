using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

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
        //Regular expression for input validation
        private static string pattern = @"\d\d:\d\d:\d\d\.\d\d"; //\d represents any decimal value. \. is used because otherwise a period represents any character.
        Regex correctFormat = new Regex(pattern);

        public MainForm()
        {
            InitializeComponent(); //Default initialization method. DO NOT TOUCH!
            switch (dayOfWeek) //Checks the appropriate day of the week when the program loads.
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
                DisableControls();
                TimerButton.BackgroundImage = Properties.Resources.ButtonStop;
                TimeTracker.Start();
                originalTime = TimeSpan.Parse(GetTimeFromTextBox()); //Obtains the original value in the textbox.
                startTime = DateTime.Now; //Initializes the value of the variable when the timer starts.
            } else
            {
                EnableControls();
                TimerButton.BackgroundImage = Properties.Resources.ButtonStart;
                TimeTracker.Stop();
                GetAverageTime();
            }
        }
        private void TimeTracker_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime; //Calculates the elapsed time since the start/stop button was clicked.
            TimeSpan totalTime = originalTime + elapsedTime; //Adds the elapsed time to the orignal time stored when the timer starts.
            //Updates the value stored in the appropriate Textbox based on which radio button is checked.
            switch (dayOfWeek) 
            {
                case "Sunday":
                    SundayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
                    break;
                case "Monday":
                    MondayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
                    break;
                case "Tuesday":
                    TuesdayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
                    break;
                case "Wednesday":
                    WednesdayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
                    break;
                case "Thursday":
                    ThursdayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
                    break;
                case "Friday":
                    FridayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
                    break;
                case "Saturday":
                    SundayTime.Text = totalTime.ToString(@"hh\:mm\:ss\.ff");
                    break;
            }
            AddTimes();
        }
        //Event handlers for the radio buttons. Each one changes the value of the dayOfWeek variable.
        private void SundayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayOfWeek = "Sunday";
        }

        private void MondayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayOfWeek = "Monday";
        }

        private void TuesdayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayOfWeek = "Tuesday";
        }

        private void WednesdayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayOfWeek = "Wednesday";
        }

        private void ThursdayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayOfWeek = "Thursday";
        }

        private void FridayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayOfWeek = "Friday";
        }

        private void SaturdayButton_CheckedChanged(object sender, EventArgs e)
        {
            dayOfWeek = "Saturday";
        }
        //Event handlers for all the reset buttons.
        private void SundayReset_Click(object sender, EventArgs e)
        {
            SundayTime.Text = "00:00:00.00";
            AddTimes();
            GetAverageTime();
        }

        private void MondayReset_Click(object sender, EventArgs e)
        {
            MondayTime.Text = "00:00:00.00";
            AddTimes();
            GetAverageTime();
        }

        private void TuesdayReset_Click(object sender, EventArgs e)
        {
            TuesdayTime.Text = "00:00:00.00";
            AddTimes();
            GetAverageTime();
        }

        private void WednesdayReset_Click(object sender, EventArgs e)
        {
            WednesdayTime.Text = "00:00:00.00";
            AddTimes();
            GetAverageTime();
        }

        private void ThursdayReset_Click(object sender, EventArgs e)
        {
            ThursdayTime.Text = "00:00:00.00";
            AddTimes();
            GetAverageTime();
        }

        private void FridayReset_Click(object sender, EventArgs e)
        {
            FridayTime.Text = "00:00:00.00";
            AddTimes();
            GetAverageTime();
        }
        private void SaturdayReset_Click(object sender, EventArgs e)
        {
            SaturdayTime.Text = "00:00:00.00";
            AddTimes();
            GetAverageTime();
        }
        //When each textbox control loses focus, it checks to see if the input is in a format the program can read.
        private void SundayTime_Leave(object sender, EventArgs e)
        {
            if (!correctFormat.IsMatch(SundayTime.Text))
            {
                InvalidFormatErrorMessage();
                SundayTime.Undo();
            }
            AddTimes();
            GetAverageTime();
        }
        private void MondayTime_Leave(object sender, EventArgs e)
        {
            if (!correctFormat.IsMatch(MondayTime.Text))
            {
                InvalidFormatErrorMessage();
                MondayTime.Undo();
            }
            AddTimes();
            GetAverageTime();
        }
        private void TuesdayTime_Leave(object sender, EventArgs e)
        {
            if (!correctFormat.IsMatch(TuesdayTime.Text))
            {
                InvalidFormatErrorMessage();
                TuesdayTime.Undo();
            }
            AddTimes();
            GetAverageTime();
        }
        private void WednesdayTime_Leave(object sender, EventArgs e)
        {
            if (!correctFormat.IsMatch(WednesdayTime.Text))
            {
                InvalidFormatErrorMessage();
                WednesdayTime.Undo();
            }
            AddTimes();
            GetAverageTime();
        }
        private void ThursdayTime_Leave(object sender, EventArgs e)
        {
            if (!correctFormat.IsMatch(ThursdayTime.Text))
            {
                InvalidFormatErrorMessage();
                ThursdayTime.Undo();
            }
            AddTimes();
            GetAverageTime();
        }
        private void FridayTime_Leave(object sender, EventArgs e)
        {
            if (!correctFormat.IsMatch(FridayTime.Text))
            {
                InvalidFormatErrorMessage();
                FridayTime.Undo();
            }
            AddTimes();
            GetAverageTime();
        }
        private void SaturdayTime_Leave(object sender, EventArgs e)
        {
            if (!correctFormat.IsMatch(SaturdayTime.Text))
            {
                InvalidFormatErrorMessage();
                SaturdayTime.Undo();
            }
            AddTimes();
            GetAverageTime();
        }
        //Error message to display if input validation fails.
        private void InvalidFormatErrorMessage()
        {
            string message = "Input is in invalid format. Please enter a time in \"00:00:00.00\" format.";
            string caption = "Invalid format";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show(message, caption, buttons, icon);
        }
        //Input validation for textboxes.
        private string GetTimeFromTextBox()
        {
            //Logic structure checks the day of the week and returns the appropriate value.
            switch (dayOfWeek)
            {
                case "Sunday":
                    return SundayTime.Text;
                case "Monday":
                    return MondayTime.Text;
                case "Tuesday":
                    return TuesdayTime.Text;
                case "Wednesday":
                    return WednesdayTime.Text;
                case "Thursday":
                    return ThursdayTime.Text;
                case "Friday":
                    return FridayTime.Text;
                case "Saturday":
                    return SaturdayTime.Text;
                default: //Default value so all code paths return some value for the function.
                    return null;
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

        private void GetAverageTime()
        {
            List<TimeSpan> timesRecorded = new List<TimeSpan>(); //Initializes the list to store used times.
            //Adds only times that are not set to the default value.
            if (SundayTime.Text != "00:00:00.00")
            {
                timesRecorded.Add(TimeSpan.Parse(SundayTime.Text));
            }
            if (MondayTime.Text != "00:00:00.00")
            {
                timesRecorded.Add(TimeSpan.Parse(MondayTime.Text));
            }
            if (TuesdayTime.Text != "00:00:00.00")
            {
                timesRecorded.Add(TimeSpan.Parse(TuesdayTime.Text));
            }
            if (WednesdayTime.Text != "00:00:00.00")
            {
                timesRecorded.Add(TimeSpan.Parse(WednesdayTime.Text));
            }
            if (ThursdayTime.Text != "00:00:00.00")
            {
                timesRecorded.Add(TimeSpan.Parse(ThursdayTime.Text));
            }
            if (FridayTime.Text != "00:00:00.00")
            {
                timesRecorded.Add(TimeSpan.Parse(FridayTime.Text));
            }
            if (SaturdayTime.Text != "00:00:00.00")
            {
                timesRecorded.Add(TimeSpan.Parse(SaturdayTime.Text));
            }
            TimeSpan averageTime = new TimeSpan();
            if (timesRecorded.Count == 0) //Will set AverageTime to the default if no elements exist.
            {
                AverageTime.Text = "00:00:00.00";
            } else //If elements exist in timeRecorded, runs this code.
            {
                foreach (var item in timesRecorded) //Each non-default value is added to averageTime.
                {
                    averageTime += item;
                }
                double averageMilliseconds = averageTime.TotalMilliseconds / timesRecorded.Count; //Converts averageTime to milliseconds to get the average.
                averageTime = TimeSpan.FromMilliseconds(averageMilliseconds); //Sets averageTime to the average after calculations.
                AverageTime.Text = averageTime.ToString(@"hh\:mm\:ss\.ff");
            }
        }
        private void DisableControls() //Method to disable controls when the timer starts.
        {
            SundayButton.Enabled = false;
            MondayButton.Enabled = false;
            TuesdayButton.Enabled = false;
            WednesdayButton.Enabled = false;
            ThursdayButton.Enabled = false;
            FridayButton.Enabled = false;
            SaturdayButton.Enabled = false;
            menuStrip1.Enabled = false;
            SundayReset.Enabled = false;
            MondayReset.Enabled = false;
            TuesdayReset.Enabled = false;
            WednesdayReset.Enabled = false;
            ThursdayReset.Enabled = false;
            FridayReset.Enabled = false;
            SaturdayReset.Enabled = false;
        }
        private void EnableControls() //Re-enables the controls after the timer stops.
        {
            SundayButton.Enabled = true;
            MondayButton.Enabled = true;
            TuesdayButton.Enabled = true;
            WednesdayButton.Enabled = true;
            ThursdayButton.Enabled = true;
            FridayButton.Enabled = true;
            SaturdayButton.Enabled = true;
            menuStrip1.Enabled = true;
            SundayReset.Enabled = true;
            MondayReset.Enabled = true;
            TuesdayReset.Enabled = true;
            WednesdayReset.Enabled = true;
            ThursdayReset.Enabled = true;
            FridayReset.Enabled = true;
            SaturdayReset.Enabled = true;
        }
        //Event handlers for toolstrip controls.
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
