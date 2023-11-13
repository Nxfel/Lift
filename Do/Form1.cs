using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do
{
    public partial class Form1 : Form
    {
        private DataSet dataSet;
        private MySqlDataAdapter dataAdapter;
        private MySqlConnection connection;
        private BackgroundWorker backgroundWorker;
        private ProgressBarForm progressBarForm;

        public Form1()
        {
            InitializeComponent();

            // Initialize the DataSet and DataAdapter
            dataSet = new DataSet();
            dataAdapter = new MySqlDataAdapter();

            // Initialize the MySqlConnection with your connection string
            connection = new MySqlConnection("Server=localhost;Port=3306;Database=sectionb;Uid=root;Pwd=root;");

            // Set the dataAdapter's SelectCommand and connection
            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM logs", connection);

            // Fill the dataSet with data from the database
            dataAdapter.Fill(dataSet, "logs");

            // Initialize the progress bar form
            progressBarForm = new ProgressBarForm();

            // Initialize the BackgroundWorker
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker1_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;


            // Initialize the progress bar form
            progressBarForm = new ProgressBarForm();

        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progress bar in the ProgressBarForm
            progressBarForm.UpdateProgress(e.ProgressPercentage, $"Working: {e.ProgressPercentage}%");
        }



        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Background work is completed
            progressBarForm.Close(); // Close the progress bar form
            this.Show(); // Show Form1
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Perform your long-running tasks here
            for (int i = 1; i <= 100; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                // Simulate work
                System.Threading.Thread.Sleep(10);

                // Report progress
                backgroundWorker.ReportProgress(i);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // Show the progress bar form
            progressBarForm.WindowState = FormWindowState.Normal; // Ensure the window state is normal
            progressBarForm.Show();

            // Run the background worker when the form loads
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }


        }




        private void button1_Click(object sender, EventArgs e)//open
        {
            


        }

        private void button2_Click(object sender, EventArgs e)//close
        {
            Global.DOOR_STATE = 2;
            timer1.Start();

            // Stop timer2 when the door is closed
            timer2.Stop();

            timer3.Stop();

            timer4.Start();
            timer5.Start();
            timer8.Start();

            LogEvent("door closed");

        }

        private void button3_Click(object sender, EventArgs e)//stop
        {
            timer2.Stop();
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)//floor 1
        {
            Global.DOOR_STATE = 1;
            timer3.Start();
            LogEvent("moved to floor1");




            // Close the doors at floor0 (pictureBox1 and pictureBox2)
            timer1.Stop();
            timer2.Stop();
            LogEvent("doors closed at floor0");


        }

        private void button6_Click(object sender, EventArgs e)//floor 0
        {
            //Global.DOOR_STATE = 2;

            timer3.Start();



            LogEvent("moved to floor0");

        }

        private void button7_Click(object sender, EventArgs e)//down call
        {
            Global.DOOR_STATE = 2;
            timer3.Start();

        }

        private void button8_Click(object sender, EventArgs e)//up call
        {
            Global.DOOR_STATE = 1;
            timer3.Start();


        }



        private void timer1_Tick(object sender, EventArgs e)//left door
        {
            int leftLimit = 70;   // The left boundary
            int rightLimit = 226; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the left
                if (pictureBox1.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer1.Stop();
                }

                else
                {
                    // Continue moving to the left
                    pictureBox1.Left -= 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the right
                if (pictureBox1.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer1.Stop();
                }

                else
                {
                    // Continue moving to the right
                    pictureBox1.Left += 5;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)//right door
        {

            int leftLimit = 226;  // The left boundary
            int rightLimit = 400; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the right when the door is open
                if (pictureBox2.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer2.Stop();
                }
                else
                {
                    // Continue moving to the right
                    pictureBox2.Left += 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the left when the door is closed
                if (pictureBox2.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer2.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox2.Left -= 5;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)//floor 1 and 0
        {


            if (Global.DOOR_STATE == 1)
            {
                if (pictureBox3.Top <= 100)
                {
                    // Elevator reached the top limit, stop the timer
                    timer3.Stop();

                    // Start timer4 and timer5 to open the doors
                    timer4.Start();
                    timer5.Start();

                    // Optionally, you can log an event when the doors open
                    LogEvent("Doors opened");
                }
                else
                {
                    pictureBox3.Top -= 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                if (pictureBox3.Bottom >= 674)
                {
                    // Elevator reached the bottom limit, stop the timer
                    timer3.Stop();

                    // Start timer6 and timer7 to close the doors
                    timer6.Start();
                    timer7.Start();

                    // Optionally, you can log an event when the doors close
                    LogEvent("Doors closed");
                }
                else
                {
                    pictureBox3.Top += 5;
                }
            }

        }



        private void timer4_Tick(object sender, EventArgs e)
        {
            int leftLimit = 70;   // The left boundary
            int rightLimit = 226; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the left
                if (pictureBox4.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer4.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox4.Left -= 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the right
                if (pictureBox4.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer4.Stop();
                }
                else
                {
                    // Continue moving to the right
                    pictureBox4.Left += 5;
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {


            int leftLimit = 226;  // The left boundary
            int rightLimit = 400; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the right
                if (pictureBox5.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer5.Stop();
                }
                else
                {
                    // Continue moving to the right
                    pictureBox5.Left += 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the left
                if (pictureBox5.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer5.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox5.Left -= 5;
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int leftLimit = 70;   // The left boundary
            int rightLimit = 226; // The right boundary

            // Always move to the left if the timer is active
            if (pictureBox1.Left <= leftLimit)
            {
                // Stop when reaching the left boundary
                timer6.Stop();
            }
            else
            {
                // Continue moving to the left
                pictureBox1.Left -= 5;
            }

        }
        private void timer7_Tick(object sender, EventArgs e)
        {

            int leftLimit = 226;  // The left boundary
            int rightLimit = 400; // The right boundary

            // Always move to the right if the timer is active
            if (pictureBox2.Right >= rightLimit)
            {
                // Stop when reaching the right boundary
                timer7.Stop();
            }
            else
            {
                // Continue moving to the right
                pictureBox2.Left += 5;
            }


        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            int leftLimit = 226;  // The left boundary
            int rightLimit = 400; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the right
                if (pictureBox2.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer8.Stop();
                }
                else
                {
                    // Continue moving to the right
                    pictureBox2.Left += 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the left
                if (pictureBox2.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer8.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox2.Left -= 5;
                }
            }
        }


        //
        //











        //database


        private void button5_Click(object sender, EventArgs e)//display
        {
            try
            {
                // Check if there are any records in the dataset
                if (dataSet.Tables["logs"].Rows.Count == 0)
                {
                    // If there are no records, create an empty DataTable and display it
                    DataTable emptyTable = new DataTable();
                    // Add columns to the empty table (assuming you have "date," "time," and "event" columns)
                    emptyTable.Columns.Add("date");
                    emptyTable.Columns.Add("time");
                    emptyTable.Columns.Add("event");

                    // Display the empty table in dataGridView1
                    dataGridView1.DataSource = emptyTable;
                }
                else
                {
                    // Filter the dataset to exclude "Auto-increment reset" records
                    var filteredRows = dataSet.Tables["logs"].Select("event <> 'Auto-increment reset'", "", DataViewRowState.CurrentRows);
                    DataTable filteredTable = filteredRows.CopyToDataTable();

                    // Sort the filtered data by time in ascending order
                    DataView sortedView = filteredTable.DefaultView;
                    sortedView.Sort = "time ASC";

                    // Display the sorted data in dataGridView1
                    dataGridView1.DataSource = sortedView;

                    // Hide the "SN" column
                    dataGridView1.Columns["SN"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void InsertLogData(string logDate, string logTime, string logEvent)
        {
            // Insert log data to the DataSet
            DataRow newRow = dataSet.Tables["logs"].NewRow();
            newRow["date"] = logDate;
            newRow["time"] = logTime;
            newRow["event"] = logEvent;
            dataSet.Tables["logs"].Rows.Add(newRow);

            // Update the database
            UpdateDatabase();
        }

        private void LogEvent(string eventDescription)
        {
            string logDate = DateTime.Now.ToString("yyyy-MM-dd");//date
            string logTime = DateTime.Now.ToString("HH:mm:ss"); // time Includes seconds
            InsertLogData(logDate, logTime, eventDescription);
        }

        private void UpdateDatabase()
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Create a DeleteCommand for the data adapter
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                // Update the database with changes from the DataSet
                dataAdapter.Update(dataSet, "logs");

                // Reset the auto-increment counter
                ResetAutoIncrement();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void ResetAutoIncrement()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    // Open the database connection if it's not already open
                    connection.Open();
                }

                // Check if the auto-increment reset log already exists in the dataset
                DataRow[] existingRows = dataSet.Tables["logs"].Select("event = 'Auto-increment reset'");

                if (existingRows.Length == 0)
                {
                    // Create a new row
                    DataRow newRow = dataSet.Tables["logs"].NewRow();
                    newRow["date"] = DateTime.Now.ToString("yyyy-MM-dd");
                    newRow["time"] = DateTime.Now.ToString("HH:mm:ss");
                    newRow["event"] = "Auto-increment reset";

                    // Add the new row to the dataset
                    dataSet.Tables["logs"].Rows.Add(newRow);

                    // Create an InsertCommand for the data adapter
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                    dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();

                    // Use the Update method to update the database
                    dataAdapter.Update(dataSet, "logs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void DeleteAllRecords()
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Create a MySqlCommand to delete all records except "Auto-increment reset" from the "logs" table
                using (MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM logs WHERE event <> 'Auto-increment reset'", connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }

                // Clear the dataset to remove all records from the DataGridView
                dataSet.Tables["logs"].Clear();

                // Display a message to indicate successful deletion
                MessageBox.Show("All records have been deleted from the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)//clear
        {
            // Clear the dataset to remove all records from the DataGridView
            dataSet.Tables["logs"].Clear();

            MessageBox.Show("Cleared");

        }

        private void button11_Click(object sender, EventArgs e)//delete all
        {
            DeleteAllRecords();


        }


    }
}