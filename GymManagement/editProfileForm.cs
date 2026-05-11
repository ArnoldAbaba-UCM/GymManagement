using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace GymManagement
{
    public partial class editProfileForm : Form
    {
        OleDbConnection con = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + @"\GymDB.accdb");

        public string LoggedInEmail { get; set; }

        public bool AccountDeleted { get; private set; }

        private byte[] selectedImageBytes = null;   // newly chosen image
        private byte[] originalImageBytes = null;   // existing image from DB

        public editProfileForm()
        {
            InitializeComponent();
            AccountDeleted = false;
            txt_Email.ReadOnly = true;
            txt_Email.BackColor = System.Drawing.SystemColors.ControlLight;
        }

        public void LoadProfile()
        {
            if (string.IsNullOrEmpty(LoggedInEmail))
            {
                MessageBox.Show("No member email provided.", "Error");
                return;
            }

            string sql = @"SELECT FirstName, LastName, Email, Phone, ProfilePic
                   FROM Members
                   WHERE Email = @Email AND Active = True";

            try
            {
                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_FirstName.Text = reader["FirstName"].ToString();
                            txt_LastName.Text = reader["LastName"].ToString();
                            txt_Email.Text = reader["Email"].ToString();
                            txt_PhoneNumber.Text = reader["Phone"].ToString();

                            // --- Load profile picture ---
                            if (reader["ProfilePic"] != DBNull.Value)
                            {
                                originalImageBytes = (byte[])reader["ProfilePic"];
                                using (MemoryStream ms = new MemoryStream(originalImageBytes))
                                {
                                    pb_ProfilePic.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                originalImageBytes = null;
                                pb_ProfilePic.Image = null;   // or a default placeholder
                            }
                        }
                        else
                        {
                            MessageBox.Show("Member not found or inactive.", "Error");
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string newFirst = txt_FirstName.Text.Trim();
            string newLast = txt_LastName.Text.Trim();
            string newPhone = txt_PhoneNumber.Text.Trim();
            string newPass = txt_NewPassword.Text;

            // Validations
            if (string.IsNullOrEmpty(newFirst) || string.IsNullOrEmpty(newLast) || string.IsNullOrEmpty(newPhone))
            {
                MessageBox.Show("First name, last name, and phone cannot be empty.");
                return;
            }
            if (!newPhone.StartsWith("09") || newPhone.Length != 11 || !newPhone.All(char.IsDigit))
            {
                MessageBox.Show("Phone must start with '09' and be exactly 11 digits.");
                return;
            }
            if (!string.IsNullOrEmpty(newPass) && newPass.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters.");
                return;
            }

            // Determine which image bytes to save
            byte[] finalImageBytes = selectedImageBytes ?? originalImageBytes;

            // Build SQL and parameters (correct order!)
            string sql;
            OleDbCommand cmd;

            if (!string.IsNullOrEmpty(newPass))
            {
                sql = @"UPDATE Members 
                SET FirstName = @First, LastName = @Last, Phone = @Phone, [Password] = @Pass, ProfilePic = @ProfilePic
                WHERE Email = @Email";
                cmd = new OleDbCommand(sql, con);
                // Order: @First, @Last, @Phone, @Pass, @ProfilePic, @Email
                cmd.Parameters.Add("@First", OleDbType.VarWChar).Value = newFirst;
                cmd.Parameters.Add("@Last", OleDbType.VarWChar).Value = newLast;
                cmd.Parameters.Add("@Phone", OleDbType.VarWChar).Value = newPhone;
                cmd.Parameters.Add("@Pass", OleDbType.VarWChar).Value = newPass;
                // Profile pic
                if (finalImageBytes != null)
                    cmd.Parameters.Add("@ProfilePic", OleDbType.LongVarBinary).Value = finalImageBytes;
                else
                    cmd.Parameters.Add("@ProfilePic", OleDbType.LongVarBinary).Value = DBNull.Value;
                cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;
            }
            else
            {
                sql = @"UPDATE Members 
                SET FirstName = @First, LastName = @Last, Phone = @Phone, ProfilePic = @ProfilePic
                WHERE Email = @Email";
                cmd = new OleDbCommand(sql, con);
                // Order: @First, @Last, @Phone, @ProfilePic, @Email
                cmd.Parameters.Add("@First", OleDbType.VarWChar).Value = newFirst;
                cmd.Parameters.Add("@Last", OleDbType.VarWChar).Value = newLast;
                cmd.Parameters.Add("@Phone", OleDbType.VarWChar).Value = newPhone;
                // Profile pic
                if (finalImageBytes != null)
                    cmd.Parameters.Add("@ProfilePic", OleDbType.LongVarBinary).Value = finalImageBytes;
                else
                    cmd.Parameters.Add("@ProfilePic", OleDbType.LongVarBinary).Value = DBNull.Value;
                cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;
            }

            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Profile updated successfully!", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed. Make sure your account is active.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to permanently delete your account? This cannot be undone.",
            "Confirm Permanent Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string sql = "DELETE FROM Members WHERE Email = @Email";

            try
            {
                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = LoggedInEmail;

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Your account has been permanently deleted.", "Account Deleted");
                        AccountDeleted = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed. Account not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting account: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Display the chosen image
                    pb_ProfilePic.Image = Image.FromFile(dlg.FileName);
                    // Convert to JPEG bytes and store
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pb_ProfilePic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        selectedImageBytes = ms.ToArray();
                    }
                }
            }
        }
    }
}
