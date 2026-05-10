# GymManagement

 (4/26/2026)

> Design of the UI (Repaso)
> Feedback of the UI (Diaz)
> Creation of the project UI such as basic functions of the given instruction (Ababa & Magbanua)


 (4/27/2026)

> Checking of the Project
> Listening to Mr  Montecillo's advice (Alfonso)
   and relay's the advice of Mr Montecillo to Ababa

 (4/28/2026)

> Changed from admin view to now user input. added steps up to payment window.
changes made by Ababa as per Costanilla via Mr Montecillo's advice.

(5/4/2026)

> Implementation of registration logic and data validation for the registerForm by Ababa.

(5/5/2026)

> Code review and feedback on registerForm data validation by Costanilla; requested additional checks for membership type consistency with payment window. (Costanilla)

> UI/UX walkthrough of the registration flow by Diaz and Repaso; identified improvements for error message placement and input field grouping. (Diaz & Repaso)

> Preparation of dashboard wireframes and component specifications by Repaso; approved by Costanilla for Ababa's integration on 5/6. (Repaso, Costanilla)

> Backend support and validation logic review for registerForm by Magbanua; assisted Ababa in preparing data structures for dashboard integration. (Magbanua, Ababa)

(5/6/2026)

> Integration of the main dashboard interface and its primary system functionalities by Ababa.

(5/7/2026)

> UI improvements: refined error message placement and input field grouping per Diaz & Repaso feedback.

> Aligned dashboard component spacing and added responsive adjustments to payment window and registration flow.

> Implemented by Ababa, with backend validation support and UI logic review by Magbanua.

> Changes reviewed by Costanilla.

(5/10/2026)

> UI redesign planning for the GymManagement system was started by Diaz as the UI Manager. The goal was to improve the look of the system by changing the plain and simple design into a more colorful and attractive interface using bright colors, background pictures, and better panel layouts.

> The dashboard, login form, and registration form were redesigned using colors such as orange, yellow, peach, and white to create a consistent gym-themed design. Background images and character pictures were added to make the forms more appealing, while the panels were arranged properly to make the information easier to read and understand.

> Several UI improvements were also made, such as redesigning the buttons, fixing the spacing of components, and organizing labels, textboxes, and date pickers neatly inside each panel. Different panel background colors and images were used to separate sections clearly while still keeping the same overall style for the system.

> Repaso also gave feedback and suggestions during the redesign process by checking the consistency of colors, button placements, panel sizes, and overall user friendliness of the interface. Suggestions were made to keep the design simple, organized, and easy for users to navigate. 

(5/10/2026 – 10:00 PM → 5/11/2026 – 4:00 AM)

> Register Form (Register.cs)

> Removed broken nextCounter switch logic for panel navigation; replaced with if (pl_Personal.Visible) … else if (pl_Plan.Visible) … to advance through Personal → Plan → Payment panels.

> Created InsertMember method accepting (string firstName, string lastName, string email, string password, string phone, DateTime dateOfBirth, string planText, DateTime startDate, string creditText).

> Inside InsertMember: parses planText via string[] parts = planText.Split('₱'); string planName = parts[0].Trim('-', ' ').Trim(); decimal planPrice = decimal.Parse(parts[1].Trim());.

> Converts creditText to decimal with decimal.TryParse(creditText, out credit) (default 0).

> SQL: INSERT INTO Members (FirstName, LastName, Email, [Password], Phone, DateOfBirth, StartDate, Plan, Credit, Active) VALUES (@FirstName, @LastName, @Email, @Password, @Phone, @DateOfBirth, @StartDate, @Plan, @Credit, True).

> Parameters added with explicit types: OleDbType.VarWChar for text, OleDbType.Date for dates, OleDbType.Currency for credit.

> Handles connection: checks if (con.State == ConnectionState.Open) con.Close(); then con.Open(); cmd.ExecuteNonQuery(); con.Close(); wrapped in try-catch-finally.

> In btn_CompleteRegistration_Click: added validation block (empty fields, email format using Contains("@") and dot after it, password ≥6 chars, phone must start with "09" and exactly 11 digits, date of birth ≤ today, plan selection must contain "₱").

> Parses plan price from combo; top‑up amount (txt_Amount.Text) validated with decimal.TryParse, must be ≥ plan price.

> Calculates remainingCredit = amount - planPrice and passes it as creditText to InsertMember.

> After InsertMember, inserts two transaction records into Transactions table using only form values:

> Top‑up: INSERT INTO Transactions (MemberName, Amount, Description, PaymentDate, PaymentMethod) VALUES (@mname, @amt, 'Initial top‑up', @payDate, @method) with @amt = positive amount, @method from cmb_Method.Text.

> Plan fee deduction: same SQL but @amt = -planPrice, @desc = "Initial plan fee – " + planText, @method = DBNull.Value.

> All transaction inserts use explicit OleDbType.Currency for @amt and OleDbType.Date for @payDate to avoid data type mismatch.

> Login Form (loginForm.cs)

> Added form-level OleDbConnection identical to other forms.

> btn_login_Click: validates empty fields, then executes SELECT COUNT(*) FROM Members WHERE Email = @Email AND [Password] = @Password AND Active = True.

> Uses cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = email; and same for @Password.

> Checks count > 0; on success sets dashboard.LoggedInEmail = email, calls dashboard.dashboardForm_LoadData(), shows dashboard, hides login.

> On failure, clears password and shows error.

> Connection safety: if (con.State == ConnectionState.Open) con.Close() before con.Open(), and finally { if (con.State == ConnectionState.Open) con.Close(); }.

> Dashboard Form (dashboardForm.cs)

> Added public string LoggedInEmail { get; set; } and private string memberFullName = "";.

> Created dashboardForm_LoadData() method:

> SQL: SELECT FirstName, LastName, Plan, Credit, StartDate, Phone FROM Members WHERE Email = @Email AND Active = True.

> Uses safe date parsing: DateTime startDate; if (!DateTime.TryParse(reader["StartDate"].ToString(), out startDate)) startDate = DateTime.Today; to prevent "String was not recognized as a valid DateTime" error.

> Reads reader, assigns lbl_WelcomeName.Text = "Welcome, " + firstName + "!";, lbl_Member.Text = "Member: " + firstName + " " + lastName;, lbl_Credit.Text = "Credit: " + credit;, lbl_JoinedDate.Text = "Joined: " + startDate;, lbl_Status.Text = "Status: Active";.

> Stores memberFullName = firstName + " " + lastName;.

> Added LoadRecentTransactions() method:

> SQL: SELECT Amount, Description, PaymentDate, PaymentMethod FROM Transactions WHERE MemberName = @Member ORDER BY PaymentDate DESC.

> Loads into DataTable via dt.Load(cmd.ExecuteReader()), sets dgv_RecentTransaction.DataSource = dt;.

> Sets dgv_RecentTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;, dgv_RecentTransaction.Columns["Amount"].DefaultCellStyle.Format = "₱#,##0.00";, grid read-only.

> Called LoadRecentTransactions() at end of LoadData().

> btn_RenewEditPlan_Click: hides dashboard, creates renewEditPlanForm, sets LoggedInEmail and MemberFullName, calls LoadCurrentPlan(), shows as dialog, then calls dashboardForm_LoadData() and this.Show().

> btn_EditProfile_Click: hides dashboard, creates editProfileForm, sets LoggedInEmail, calls LoadProfile(), shows dialog; checks edit.AccountDeleted – if true, closes dashboard and shows login; else reloads and shows.

> btn_TopUp_Click: hides dashboard, creates topUpForm, sets LoggedInEmail and MemberFullName, shows dialog, reloads and shows.

> Edit Profile Form (editProfileForm.cs)

> Added public string LoggedInEmail { get; set; } and public bool AccountDeleted { get; private set; } initialized to false in constructor.

> Email textbox read-only, gray background.

> LoadProfile(): SQL SELECT FirstName, LastName, Email, Phone FROM Members WHERE Email = @Email AND Active = True; fills textboxes.

> btn_Save_Click:

> Validation: first/last name non‑empty, phone starts with "09" and 11 digits, new password ≥6 if provided.

> Dynamic SQL: If newPass not empty, UPDATE Members SET FirstName = @First, LastName = @Last, Phone = @Phone, [Password] = @Pass WHERE Email = @Email with parameters added in exact order: @First, @Last, @Phone, @Pass, @Email (all OleDbType.VarWChar). If no new password, omits @Pass.

> This fixed the parameter-order bug that previously mixed first name/password values.

> On success closes form.

> btn_Cancel: this.Close().

> lbl_Delete_Click: confirmation dialog; executes DELETE FROM Members WHERE Email = @Email with OleDbType.VarWChar; sets AccountDeleted = true and closes.

> Renew/Change Plan Form (renewEditPlanForm.cs)

> Added public string LoggedInEmail { get; set; } and public string MemberFullName { get; set; }.

> Constructor populates cmb_Plan with "Monthly - ₱800", "Quarterly - ₱1200", "Yearly - ₱1500"; selects index 0.

> LoadCurrentPlan(): fetches Plan, Credit, StartDate; uses DateTime.TryParse on StartDate (fallback DateTime.Today); computes expiry by parsing plan name (Monthly→1, Quarterly→3, Yearly→12 months) and startDate.AddMonths(months); sets lbl_Expiry.Text using string.Format (no $ interpolation for C# 5 compatibility).

> btn_Confirm_Click:

> Validates new plan selection, re‑reads credit from DB to avoid stale data.

> If credit < new plan price, shows message with string.Format("Insufficient credit. You need {0:C} but have {1:C}.", ...).

> Update SQL: UPDATE Members SET Plan = @Plan, StartDate = @StartDate, Credit = Credit - @Price WHERE Email = @Email AND Active = True with @StartDate = DateTime.Today (OleDbType.Date), @Plan (VarWChar), @Price (Currency), @Email (VarWChar) – parameters in order.

> On success, inserts transaction with negative amount: INSERT INTO Transactions (MemberName, Amount, Description, PaymentDate, PaymentMethod) VALUES (@mname, @amt, @desc, @payDate, @method) where @amt = -newPlanPrice, @desc = "Renewal / Plan change – " + newPlanText, @payDate = dtp_PaymentDate.Value, @method = DBNull.Value (all with correct OleDbType).

> btn_Cancel: closes form.

> Top‑Up Form (topUpForm.cs)

> Added public string LoggedInEmail { get; set; } and public string MemberFullName { get; set; }.

> btn_Confirm_Click:

> Validates txt_Amount.Text with decimal.TryParse, must be > 0.

> Updates credit: UPDATE Members SET Credit = Credit + @Amount WHERE Email = @Email AND Active = True (@Amount as OleDbType.Currency).

> Inserts transaction: INSERT INTO Transactions (MemberName, Amount, Description, PaymentDate, PaymentMethod) VALUES (@mname, @amt, 'Top‑up', @payDate, @method) with @amt positive, @payDate from dtp_PaymentDate.Value (OleDbType.Date), @method from cmb_Method.Text.

> Closes form.

> btn_Cancel: closes form.

> General Data Access & Bug Fixes

> All INSERT/UPDATE/DELETE commands use explicit OleDbType parameters to prevent “Data type mismatch in criteria expression.”

> Reserved word Password handled as [Password] in all SQL strings.

> Connection management: every database call follows the pattern if (con.State == ConnectionState.Open) con.Close(); before opening, and a finally block ensures closure.

> Form navigation standardized: parent form hides (this.Hide()) before opening child as modal dialog; after dialog closes, parent reloads data and shows again; for account deletion, a flag (AccountDeleted) signals parent to close and return to login.

> All date parsing uses DateTime.TryParse with fallback to DateTime.Today to avoid crashes.

> Grid formatting: dgv_RecentTransaction.AutoSizeColumnsMode = Fill for full‑width use; amount column formatted as currency.
