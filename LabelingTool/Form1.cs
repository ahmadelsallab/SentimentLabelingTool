using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace LabelingTool
{
    public partial class Form1 : Form
    {
        String fileName;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Program.currentTweetIndex + 1) < Program.tweets.Count)
            {
                Program.currentTweetIndex++;
                TweetTextBox.Text = ((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])).text;
                SetRadioButtons(((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (NeutralRadio.Checked)
            {
                ((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])).sentimentLabel = "Neutral";
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            this.fileName = ofd.FileName;
            //MessageBox.Show(ofd.FileName);

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt = 0;
            int cCnt = 0;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Open(ofd.FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            Program.tweets.Clear();
            for (rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
            {
                /*
                //for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                for (cCnt = 1; cCnt <= 4; cCnt++)
                {
                    str = (range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
                    MessageBox.Show(str);

                }
                */
                Tweet t = new Tweet();
                t.ID = (Double)(range.Cells[rCnt, 1] as Excel.Range).Value2;
                t.text = (range.Cells[rCnt, 2] as Excel.Range).Value2.ToString();
                t.relevanceLabel = (range.Cells[rCnt, 3] as Excel.Range).Value2.ToString();
                t.sentimentLabel = (range.Cells[rCnt, 4] as Excel.Range).Value2.ToString();
                Program.tweets.Add(t);
                Program.currentTweetIndex = 0;
                
            }
            if (Program.tweets.Count > 0)
            {
                TweetTextBox.Text = ((Tweet)(Program.tweets.ToArray()[0])).text;
            }
            /*
            switch (((Tweet)(Program.tweets.ToArray()[0])).relevanceLabel)
            {
                case "relevant":
                    RelevantRadio.Checked = true;
                    break;
                case "irrelevant":
                    IrrelevantRadio.Checked = true;
                    break;
            }

            switch (((Tweet)(Program.tweets.ToArray()[0])).sentimentLabel)
            {
                case "Positive":
                    PositiveRadio.Checked = true;
                    break;
                case "Negative":
                    NegativeRadio.Checked = true;
                    break;
                case "Neutral":
                    NeutralRadio.Checked = true;
                    break;

            }
            */
            SetRadioButtons(((Tweet)(Program.tweets.ToArray()[0])));
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (Program.currentTweetIndex - 1 >= 0)
            {
                Program.currentTweetIndex--;
                TweetTextBox.Text = ((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])).text;
                SetRadioButtons(((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])));
            }
        }

        private void RelevantRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (RelevantRadio.Checked)
            {
                ((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])).relevanceLabel = "relevant";
            }
        }

        private void IrrelevantRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (IrrelevantRadio.Checked)
            {
                ((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])).relevanceLabel = "irrelevant";
            }
        }

        private void PositiveRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (PositiveRadio.Checked)
            {
                ((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])).sentimentLabel = "Positive";
            }
        }

        private void NegativeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (NegativeRadio.Checked)
            {
                ((Tweet)(Program.tweets.ToArray()[Program.currentTweetIndex])).sentimentLabel = "Negative";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            //MessageBox.Show(ofd.FileName);

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt = 0;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Open(ofd.FileName, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;

            (range.Cells[1, 1] as Excel.Range).Value2 = "ID";
            (range.Cells[1, 2] as Excel.Range).Value2 = "Tweet Text";
            (range.Cells[1, 3] as Excel.Range).Value2 = "Relevance label";
            (range.Cells[1, 4] as Excel.Range).Value2 = "Sentiment";

            for (rCnt = 2; rCnt <= Program.tweets.Count + 1; rCnt++)
            {
                Tweet t = (Tweet)Program.tweets[rCnt - 2];

                (range.Cells[rCnt, 1] as Excel.Range).Value2 = t.ID;
                (range.Cells[rCnt, 2] as Excel.Range).Value2 = t.text;
                (range.Cells[rCnt, 3] as Excel.Range).Value2 = t.relevanceLabel;
                (range.Cells[rCnt, 4] as Excel.Range).Value2 = t.sentimentLabel;

            }
            xlWorkBook.Save();
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt = 0;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Open(this.fileName,0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            //xlApp.Visible = true;

            for (rCnt = 2; rCnt <= Program.tweets.Count + 1; rCnt++)
            {
                Tweet t = (Tweet)Program.tweets[rCnt - 2];

                (range.Cells[rCnt, 1] as Excel.Range).Value2 = t.ID;
                (range.Cells[rCnt, 2] as Excel.Range).Value2 = t.text;
                (range.Cells[rCnt, 3] as Excel.Range).Value2 = t.relevanceLabel;
                (range.Cells[rCnt, 4] as Excel.Range).Value2 = t.sentimentLabel;

            }

            xlWorkBook.Save();
            
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

        }
        private void SetRadioButtons(Tweet t)
        {
            switch (t.relevanceLabel)
            {
                case "relevant":
                    RelevantRadio.Checked = true;
                    break;
                case "irrelevant":
                    IrrelevantRadio.Checked = true;
                    break;
            }

            switch (t.sentimentLabel)
            {
                case "Positive":
                    PositiveRadio.Checked = true;
                    break;
                case "Negative":
                    NegativeRadio.Checked = true;
                    break;
                case "Neutral":
                    NeutralRadio.Checked = true;
                    break;

            }

        }
    }

    
}
