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

        public static string[] readText;
        List<string> courseNames = new List<string>(); 
        List<Course> myCourseList = new List<Course>();
        List<Course> _items = new List<Course>(); 


        public frmMain()
        {
            InitializeComponent();
            Course myTempCourse = new Course();
          /*  Course myCourse = new Course();
            int courseID = 0;
            int courseDate = 0;
            string courseLevel = "";
            string courseName = "";
            string coursePlaces = "FFFFFFFFFFFF";*/ 
        }

        private void tspExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> _courseNames = new List<string>(); //Create a new temp list of strings which is used to buffer the inputs from the textbox

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            //Create a new temp list of strings which is used to buffer the inputs from the textbox before 
            _items.Add(new Course(){CourseID = 100, CourseDate = 20201992, CourseLevel = "Advanced", CourseName="C++", CoursePlaces="BBBFFFBBBFFF"});
            _items.Add(new Course(){CourseID = 99, CourseDate = 13061992, CourseLevel = "Beginner", CourseName="Java", CoursePlaces="BBBBBBFFFFFF"});
            _items.Add(new Course(){CourseID = 98, CourseDate = 04041992, CourseLevel = "Intermediate", CourseName="Python", CoursePlaces="FFFBBBFFFBBB"});
            lbxCourseWindow.Items.Clear(); //clear the listbox so we dont add to the list if open file is used more than once
            for (int i=0;i<_items.Count;i++)
            {
                lbxCourseWindow.Items.Add(_items[i].CourseName);
            }

            /*foreach (Int16 courseNames in _items.)
            {
                lbxCourseWindow.Items.Add(courseNames2); //add the course titles to the listbox
            }

            /* parts.Add(new Part() {PartName="crank arm", PartId=1234});
            _items.Add("" + txtCourseName.Text); //Add these
            _items.Add("" + txtDate.Text);
            _items.Add("" + txtCost.Text);

            lbxCourseWindow.DataSource = _items;
            /*
            // This text is added only once to the file. 
            if (File.Exists(path))
            {
                MessageBox.Show("Error: File already exists!");
            }
            else
            {
                // Create a file to write to. 
                string createText = "";
                createText += '"' + txtCourseName.Text + '"' + Environment.NewLine + '"' + txtDate.Text + '"' + Environment.NewLine + '"' + txtCost.Text + '"' + Environment.NewLine;
                File.WriteAllText(path, createText, Encoding.UTF8);
            }*/
        }
        private void tspOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string openPath;
            openFileDialog.InitialDirectory = "d:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openPath = openFileDialog.FileName; //Set filepath to Filename selected by Open File Dialog
                    readText = File.ReadAllLines(openPath);

                    for (int i = 0; i < readText.Length; i += 4)
                    {
                        //courseNames.Add(fileLines[i]);  //add just the course titles into courseNames list                
                    }

                    lbxCourseWindow.Items.Clear(); //clear the listbox so we dont add to the list if open file is used more than once

                    foreach (string item in courseNames)
                    {
                        lbxCourseWindow.Items.Add(item); //add the course titles to the listbox
                    }
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Error: 002. File open error or dialog cancelled. Original error: " + ex.Message);
                }
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
            if ((dlgSaveFileDialog.ShowDialog() == DialogResult.OK))
            {
                try
                {
                    savePath = dlgSaveFileDialog.FileName; //Set filepath to Filename/path selected by Save File Dialog.
                    if (Path.GetExtension(savePath)==".txt")
                    {
                        string createText = ""; //Create temporary string to save the outputs to, so saving to file can be completed with "File.WriteAllText" method.
                        for (int i = 0; i < _items.Count; i++)
                        {
                            createText += //Append all course details from all elements of the list of classes and save to a file.
                                '"' + _items[i].CourseName + '"' + Environment.NewLine
                                + '"' + _items[i].CourseID + '"' + Environment.NewLine
                                + '"' + _items[i].CourseLevel + '"' + Environment.NewLine
                                + '"' + _items[i].CourseDate + '"' + Environment.NewLine
                                + '"' + _items[i].CoursePlaces + '"' + Environment.NewLine;
                        }
                        File.WriteAllText(savePath, createText, Encoding.UTF8);
                        MessageBox.Show("File has been saved to " + savePath); //Output confirmation to the user.
                    }
                    else
                    {
                        MessageBox.Show("Error: 001. Incorrect File Format. Original error: "); 
                        //Output design specified error code message to the user if an exception was thrown by the program.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: 001. File incorrect format or missing or dialog cancelled. Original error: " + ex.Message); //Output design specified error code message to the user if an exception was thrown by the program.
                }
            }
            else 
            {
                MessageBox.Show("Error: 003. File save error. Original error: Saving was aborted by user."); //Output design specified error code message to the user if saving was aborted.
            }
        }
    } //frmMain class ends here.
} //Namespace CourseBooker9000 ends here.