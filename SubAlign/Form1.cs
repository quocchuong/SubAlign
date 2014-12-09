using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SubAlign
{
    public partial class frmSubAlign : Form
    {
        string FolderPath;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public frmSubAlign()
        {
            InitializeComponent();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            //clean all the grid if leng is more than 1
            if (this.dgvMovies.DataSource != null)
            {
                this.dgvMovies.DataSource = null;
            }
            else
            {
                this.dgvMovies.Rows.Clear();
            }

            //clean all the grid if leng is more than 1
            if (this.dgvSubs.DataSource != null)
            {
                this.dgvSubs.DataSource = null;
            }
            else
            {
                this.dgvSubs.Rows.Clear();
            }

            //check the type
            if ((txtMovieFiles.Text.Length > 0) && (txtSubsFile.Text.Length > 0))
            {
                //ask for the folder
                fldDialog.ShowDialog();
                FolderPath = fldDialog.SelectedPath;

                if (FolderPath.Length > 0)
                {
                    //get the list of files movies
                    string[] movieFiles = Directory.GetFiles(FolderPath, "*." + txtMovieFiles.Text);                    

                    //list file movies to the left panel
                    for (int i = 0; i < movieFiles.Length; i++)
                    {
                        //add row to the 
                        int n = dgvMovies.Rows.Add();                        
                        dgvMovies.Rows[n].Cells[0].Value = movieFiles[i];                        
                    }

                    //get the list of files subs
                    string[] subFiles = Directory.GetFiles(FolderPath, "*." + txtSubsFile.Text);                    

                    //list file sub to the right panel
                    for (int i = 0; i < subFiles.Length; i++)
                    {
                        //add row to the 
                        int n = dgvSubs.Rows.Add();
                        dgvSubs.Rows[n].Cells[0].Value = subFiles[i];
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the movies extension and the subtitle extension");
            }
        }

        private void dgvMovies_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvMovies.DoDragDrop(
                    dgvMovies.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void dgvMovies_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dgvMovies.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvMovies_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvMovies_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgvMovies.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dgvMovies.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                dgvMovies.Rows.RemoveAt(rowIndexFromMouseDown);
                dgvMovies.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
        }

        private void dgvSubs_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvSubs.DoDragDrop(
                    dgvSubs.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void dgvSubs_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dgvSubs.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvSubs_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvSubs_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgvSubs.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dgvSubs.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                dgvSubs.Rows.RemoveAt(rowIndexFromMouseDown);
                dgvSubs.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
        }

        private void btnProcessSub_Click(object sender, EventArgs e)
        {
            //loop to get the file from the left to the right
            for (int i = 0; i < dgvSubs.Rows.Count - 1 ; i++)
            { 
                //get the name of the movies file
                string theMoviesFile = dgvMovies.Rows[i].Cells[0].Value.ToString();
                theMoviesFile = theMoviesFile.Substring(0, theMoviesFile.Length - 3);
                                
                //get the name of the file
                string theSubFileName = dgvSubs.Rows[i].Cells[0].Value.ToString();

                //MessageBox.Show("replace file : " + theSubFileName + " with " + theMoviesFile + "." + txtSubsFile.Text);

                try
                {
                    File.Move(@"" + theSubFileName + "", @"" + theMoviesFile + "en." + txtSubsFile.Text); // Try to move                    
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message); // Write error
                }

                //clean all the grid if leng is more than 1
                if (this.dgvMovies.DataSource != null)
                {
                    this.dgvMovies.DataSource = null;
                }
                else
                {
                    this.dgvMovies.Rows.Clear();
                }

                //clean all the grid if leng is more than 1
                if (this.dgvSubs.DataSource != null)
                {
                    this.dgvSubs.DataSource = null;
                }
                else
                {
                    this.dgvSubs.Rows.Clear();
                }

                //get the list of files movies
                string[] movieFiles = Directory.GetFiles(FolderPath, "*." + txtMovieFiles.Text);

                //list file movies to the left panel
                for (int j = 0; j < movieFiles.Length; j++)
                {
                    //add row to the 
                    int n = dgvMovies.Rows.Add();
                    dgvMovies.Rows[n].Cells[0].Value = movieFiles[j];
                }

                //get the list of files subs
                string[] subFiles = Directory.GetFiles(FolderPath, "*." + txtSubsFile.Text);

                //list file sub to the right panel
                for (int j = 0; j < subFiles.Length; j++)
                {
                    //add row to the 
                    int n = dgvSubs.Rows.Add();
                    dgvSubs.Rows[n].Cells[0].Value = subFiles[j];
                }
            }
        }
    }
}
