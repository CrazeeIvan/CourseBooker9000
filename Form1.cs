using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Booker_9000
{
    public partial class frmMain : Form
    {
        List<Course> courseStorage = new List<Course>();
        List<Course> _items = new List<Course>();
        public static string[] tempLines; //temp string array for manipulating data before saving to the list.


        public frmMain()
        {
            InitializeComponent();
        }
        private void tspExit_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Are you sure you want to exit the Course Booker 9000?\nAny unsaved progress will be lost.", "Confirmation", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //Does nothing if cancel is selected.
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmBookingSeatPlanner frm = new frmBookingSeatPlanner();
            frm.Show();
        }
        private void tspOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string openPath;
            openFileDialog.InitialDirectory = "d:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openPath = openFileDialog.FileName; //Set filepath to Filename selected by the Open File Dialog.
                    if (Path.GetExtension(openPath) == ".txt")
                    {
                        List<string> courseNames = new List<string>();
                        tempLines = File.ReadAllLines(openPath, Encoding.Default); //Copy the opened file into tempLines.
                        for (int i = 0; i < tempLines.Length; i++)
                        {
                            tempLines[i] = tempLines[i].Trim('"'); //The trim method allows for the removal of a designated character from a string.
                        }
                        for (int i = 0; i < tempLines.Length; i += 5)
                        {
                            _items.Add(new Course() 
                            {
                                CourseID = Int32.Parse(tempLines[i]),
                                CourseName = tempLines[i + 1],
                                CourseLevel = tempLines[i + 2],
                                CourseDate = Int32.Parse(tempLines[i + 3]),
                                CoursePlaces = tempLines[i + 4]
                            }
                            );
                            courseNames.Add(tempLines[i+1]);  //Add course names into the courseNames list.
                        }
                        lbxCourseWindow.Items.Clear(); //Clear listbox before adding to it, to ensure that we do not create duplicate entries.
                        courseNames = courseNames.Distinct().ToList<String>(); //remove any duplicate course titles.
                        lbxCourseWindow.DataSource = courseNames; //Populate the listbox with the courseNames list of strings.
                    }
                    else
                    {
                        MessageBox.Show("Error: 001. Incorrect File Format.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: 003. File save error.\nOriginal error: Saving was aborted by user."); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: 002. File open error or dialog cancelled.\nOriginal error: " + ex.Message);
            }
        }
        private void tspSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSaveFileDialog = new SaveFileDialog(); //Create a new instance of SaveFileDialog named dlgSaveFileDialog.
            string savePath; //Create a temporary string to store the path for saving the file.
            dlgSaveFileDialog.InitialDirectory = "d:\\";
            dlgSaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSaveFileDialog.FilterIndex = 2;
            dlgSaveFileDialog.RestoreDirectory = true;
            try
            {
                if ((dlgSaveFileDialog.ShowDialog() == DialogResult.OK))
                {
                    savePath = dlgSaveFileDialog.FileName; //Set filepath to Filename/path selected by Save File Dialog.
                    if (Path.GetExtension(savePath)==".txt")
                    {
                        string createText = ""; //Create temporary string to save the outputs to, so saving to file can be completed with "File.WriteAllText" method.
                        for (int i = 0; i < _items.Count; i++)
                        {//Append all course details from all elements of the list of course class and save to a file.
                            createText += 
                                '"' + _items[i].CourseID.ToString() + '"' + Environment.NewLine //.ToString() method used for CourseID to prevent a bug of the ascii code of " being added to the CourseID integer.
                                + '"' + _items[i].CourseName + '"' + Environment.NewLine
                                + '"' + _items[i].CourseLevel + '"' + Environment.NewLine
                                + '"' + _items[i].CourseDate + '"' + Environment.NewLine
                                + '"' + _items[i].CoursePlaces + '"' + Environment.NewLine;
                        }
                        File.WriteAllText(savePath, createText, Encoding.UTF8); //File Creation is here.
                        MessageBox.Show("File has been saved to " + savePath); //Output confirmation to the user.
                    }
                    else
                    {//Output design specified error code message to the user if the user attempts to save the file in an incorrect format.
                        MessageBox.Show("Error: 001. Incorrect File Format.");    
                    }
                }
                else
                {//Output design specified error code message to the user if saving was aborted.
                    MessageBox.Show("Error: 003. File save error.\nOriginal error: Saving was aborted by user."); 
                }
            }
            catch (Exception ex)
            {//Output design specified error code message to the user if an exception was thrown by the program.
                MessageBox.Show("Error: 001. File incorrect format or missing or dialog cancelled.\nOriginal error: " + ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Are you sure you want to exit the Course Booker 9000?\nAny unsaved progress will be lost.", "Confirmation", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //Does nothing if cancel is selected.
            }
        }
    } //frmMain class ends here.
} //Namespace CourseBooker9000 ends here.