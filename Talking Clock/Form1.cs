using System;
using System.Windows.Forms;

namespace Talking_Clock
{
    public partial class talkingClock : Form
    {
        public talkingClock()
        {
            InitializeComponent();
        }

        private void textBox_in_TextChanged(object sender, EventArgs e)
        {
            // Declare variables and defaults
            String[] input = { "" },
                hourName = { "twelve", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven" },

                minuteName = { "o'clock", "oh one", "oh two", "oh three", "oh four", "oh five", "oh six", "oh seven", "oh eight", "oh nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
                "twenty", "twenty-one", "twenty-two", "twenty-three", "twenty-four", "twenty-five", "twenty-six", "twenty-seven", "twenty-eight", "twenty-nine",
                "thirty", "thirty-one", "thirty-two", "thirty-three", "thirty-four", "thirty-five", "thirty-six", "thirty-seven", "thirty-eight", "thirty-nine",
                "forty", "forty-one", "forty-two", "forty-three", "forty-four", "forty-five", "forty-six", "forty-seven", "forty-eight", "forty-nine",
                "fifty", "fifty-one", "fifty-two", "fifty-three", "fifty-four", "fifty-five", "fifty-six", "fifty-seven", "fifty-eight", "fifty-nine", };

            String output = "Please enter a correctly formated time", noon = " am";

            int hour = 0, minute = 0;

            // Check if input contains ":", other wise it isn't proper input
            if (textBox_in.Text.Contains(":"))
            {
                input = textBox_in.Text.Split(':');

                // Check for hour
                if (!input[0].Equals(""))
                {
                    hour = int.Parse(input[0]);
                }

                // Check for minute
                if (!input[1].Equals(""))
                {
                    minute = int.Parse(input[1]);
                }

                if (hour >= 12)
                    noon = " pm";

                // Append all the strings together, also "fixes" input that is too large
                output = "It's " + hourName[hour % 12] + " " + minuteName[minute % 60] + noon;
            }

            textBox_out.Text = output;
        }
    }
}
