using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AbbTools
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        // Объявление глобальных переменных

        List<string> mass = new List<string>();
        bool rTextBoxChangeDirecFromFocused = false;
        bool rTextBoxChangeDirecToFocused = false;
        public static string popMenuRTBname;

        Point _LastPoint = Point.Empty;
        Point mouseCord = Point.Empty;
        object mouseSender;

        //********************************************************



        private void button6_Click(object sender, EventArgs e)
        {
            rTextBoxChangeDirecTo.Clear();
            ChangeDirection.StartChangeDirection(rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
        }



        public MainForm()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            InitializeComponent();
        }



        private void popMenuCut_Click_1(object sender, EventArgs e)
        {
            string rtbName = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl.Name;

            TextOperations rtb = new TextOperations(rtbName, rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Cut();
        }

        private void popMenuDel_Click(object sender, EventArgs e)
        {
            string rtbName = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl.Name;
            TextOperations rtb = new TextOperations(rtbName, rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Del();
            switch (rtbName)
            {
                case "rTextBoxChangeDirecFrom":
                    rTextBoxChangeDirecFrom.Text = rtb.rtb.Text;
                    break;
                case "rTextBoxChangeDirecTo":
                    rTextBoxChangeDirecTo.Text = rtb.rtb.Text;
                    break;
                default:
                    break;
            }
        }

        private void popMenuCopy_Click(object sender, EventArgs e)
        {
            string rtbName = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl.Name;

            TextOperations rtb = new TextOperations(rtbName, rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Copy();
        }

        private void popMenuPast_Click(object sender, EventArgs e)
        {
            string rtbName = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl.Name;
            TextOperations rtb = new TextOperations(rtbName, rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Paste();
            switch (rtbName)
            {
                case "rTextBoxChangeDirecFrom":
                    rTextBoxChangeDirecFrom.Text = rtb.rtb.Text;
                    break;
                case "rTextBoxChangeDirecTo":
                    rTextBoxChangeDirecTo.Text = rtb.rtb.Text;
                    break;
                default:
                    break;
            }
        }

        private void popMenuSelectAll_Click(object sender, EventArgs e)
        {
            string sourceControl = ((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl.Name;
            switch (sourceControl)
            {
                case "rTextBoxChangeDirecFrom":
                    rTextBoxChangeDirecFrom.Focus();
                    rTextBoxChangeDirecFrom.Select(0, rTextBoxChangeDirecFrom.TextLength);
                    break;
                case "rTextBoxChangeDirecTo":
                    rTextBoxChangeDirecTo.Focus();
                    rTextBoxChangeDirecTo.Select(0, rTextBoxChangeDirecTo.TextLength);
                    break;
                default:
                    break;
            }
        }

        private void btnSCut_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecFrom", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Cut();
        }

        private void btnTCut_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecTo", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Cut();
        }

        private void btnSDel_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecFrom", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Del();
            rTextBoxChangeDirecFrom.Text = rtb.rtb.Text;
        }

        private void btnTDel_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecTo", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Del();
            rTextBoxChangeDirecTo.Text = rtb.rtb.Text;
        }

        private void btnSCopy_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecFrom", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Copy();
        }

        private void btnTCopy_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecTo", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Copy();
        }

        private void btnSPaste_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecFrom", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Paste();
            rTextBoxChangeDirecFrom.Text = rtb.rtb.Text;
        }

        private void btnTPaste_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecTo", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.Paste();
            rTextBoxChangeDirecTo.Text = rtb.rtb.Text;
        }

        private void btnSSelectAll_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecFrom", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.SelectAll();
            rTextBoxChangeDirecFromFocused = true;
        }

        private void btnTSelectAll_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecTo", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.SelectAll();
            rTextBoxChangeDirecToFocused = true;
        }

        private void btnSClearAll_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecFrom", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.ClearAll();
        }

        private void btnTClearAll_Click(object sender, EventArgs e)
        {
            TextOperations rtb = new TextOperations("rTextBoxChangeDirecTo", rTextBoxChangeDirecFrom, rTextBoxChangeDirecTo);
            rtb.ClearAll();
        }

        // ***********************************************************************************************

        // При нажатии мышкой на поле rTextBoxChangeDirecFrom происходит выделение\сброс выделения текста
        private void rTextBoxChangeDirecFrom_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        // При нажатии мышкой на поле rTextBoxChangeDirecTo происходит выделение\сброс выделения текста
        private void rTextBoxChangeDirecTo_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void richTextBoxSelectOnOff(RichTextBox tb, bool flag)
        {
            if (flag)
            {
                tb.Focus();
                tb.Select(0, tb.TextLength);
            }
            else
                tb.Select(0, 0);
        }

        // Копирование текста richTextBox при нажатии мышкой на поле
        private void richTextBoxCopy(object sender, int x, int y)
        {
            RichTextBox rtb = (RichTextBox)sender;
            ToolTip tt = new ToolTip();
            tt.Show("Copied", rtb, x + 5, y, 1000);
            rtb.Copy();
        }

        private void rTextBoxChangeDirecFrom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left )
            {
                if (_LastPoint != e.Location)
                {
                    _LastPoint = e.Location;
                    timer1.Stop();
                }
            }
        }

        private void rTextBoxChangeDirecTo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_LastPoint != e.Location)
                {
                    _LastPoint = e.Location;
                    timer2.Stop();
                }
            }
        }

        private void rTextBoxChangeDirecFrom_MouseDown(object sender, MouseEventArgs e)
        {
            _LastPoint = e.Location;
            timer1.Start();
            rTextBoxChangeDirecFromFocused = false;

            if (e.Button == MouseButtons.Left)
            {
                rTextBoxChangeDirecFromFocused = !rTextBoxChangeDirecFromFocused;
                if (!rTextBoxChangeDirecFromFocused)
                {
                    richTextBoxSelectOnOff(rTextBoxChangeDirecFrom, rTextBoxChangeDirecFromFocused);
                }
                else
                {
                    // Заполнение глобальных переменных 
                    // для вывода текста "Скопировано" при нажатии
                    mouseCord.X = e.X;
                    mouseCord.Y = e.Y;
                    mouseSender = sender;
                }
            }
        }

        private void rTextBoxChangeDirecTo_MouseDown(object sender, MouseEventArgs e)
        {
            _LastPoint = e.Location;
            timer2.Start();
            rTextBoxChangeDirecToFocused = false;

            if (e.Button == MouseButtons.Left)
            {
                rTextBoxChangeDirecToFocused = !rTextBoxChangeDirecToFocused;
                if (!rTextBoxChangeDirecToFocused)
                {
                    richTextBoxSelectOnOff(rTextBoxChangeDirecTo, rTextBoxChangeDirecToFocused);
                }
                else
                {
                    // Заполнение глобальных переменных 
                    // для вывода текста "Скопировано" при нажатии
                    mouseCord.X = e.X;
                    mouseCord.Y = e.Y;
                    mouseSender = sender;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            richTextBoxSelectOnOff(rTextBoxChangeDirecFrom, rTextBoxChangeDirecFromFocused);
            // вывод текста "Скопировано" при нажатии
            richTextBoxCopy(mouseSender, mouseCord.X, mouseCord.Y);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            richTextBoxSelectOnOff(rTextBoxChangeDirecTo, rTextBoxChangeDirecToFocused);
            // вывод текста "Скопировано" при нажатии
            richTextBoxCopy(mouseSender, mouseCord.X, mouseCord.Y);
        }




    }

    /// <summary>
    /// Класс для опции по изменению последовательности строк
    /// </summary>
    public class ChangeDirection
    {
        public static void StartChangeDirection(RichTextBox rtbFrom, RichTextBox rtbTo)
        {
            string[] arrayAux = rtbFrom.Lines;
            string[] arrayNew = new string[arrayAux.Length];
            int k = arrayAux.Length-1;
            for (int i = 0; i < arrayAux.Length; i++)
            {
                arrayNew[k] = arrayAux[i];
                k = k - 1; 
            }
            rtbTo.AppendText(string.Join("\r\n", arrayNew));
        }
    }

    public class TextOperations
    {
        public static string rtbName { get; set; }
        public RichTextBox rtb { get; set; }
        private int StartPosDel { get; set; }
        private int LenSelection { get; set; }

        public TextOperations(string name, RichTextBox rtb1, RichTextBox rtb2)
        {
            if (name == rtb1.Name) rtb = rtb1;
            if (name == rtb2.Name) rtb = rtb2;
        }

        public void Copy()
        {
            rtb.Copy();
        }

        public void SelectAll()
        {
            rtb.Focus();
            rtb.Select(0, rtb.TextLength);
        }

        public void Del()
        {
            StartPosDel = rtb.SelectionStart;
            LenSelection = rtb.SelectionLength;
            rtb.Text = rtb.Text.Remove(StartPosDel, LenSelection);
        }

        public void Paste()
        {
            rtb.Paste();
        }

        public void Cut()
        {
            rtb.Cut();
        }

        public void ClearAll()
        {
            rtb.Clear();
        }
    }
}
