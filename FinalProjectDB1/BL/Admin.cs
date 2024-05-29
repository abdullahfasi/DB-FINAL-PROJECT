using DBMidProject;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace FinalProjectDB1.BL
{
    internal class Admin : User
    {
        public int UserID;
        public int Status;
        public Admin()
        {
        }
        public Admin(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, int status)
            : base(firstName, lastName, email, password, contact, cnic, city, usertype)
        {
            Status = status;
        }
        public Admin(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, int status, int id)
            : base(firstName, lastName, email, password, contact, cnic, city, usertype)
        {
            Status = status;
            UserID = id;
        }
        public void AddAuthor(string fname, string lname, int userId, DateTime dateofbirth, string nationality, int status,long cnic)
        {

            BL.Author author = new BL.Author(fname, lname, userId, dateofbirth, nationality, status,cnic);
            author.addAuthorInDatabase();
        }

        public void AddCategory(string name, int userid)
        {
            BL.Category category = new BL.Category(name, userid);
            category.addCategoryInDatabase();
        }
        public void AddPublisher(string name, string type, string language, int userid, string address,string email, int status)
        {
            BL.Publisher category = new BL.Publisher(name, type, language, userid, address,email, status);
            category.addPublisherInDatabase();
        }

        public void AddLocation(int shelfNo, int capacity, int userid)
        {
            BL.Location location = new Location(shelfNo, capacity, userid);
            location.addLocationInDatabase();
        }

        public void AddBook(string title, string isbn, int categoryID, int publisherID, int publicationYear, int edition, int totalCopies, int availableCopies, int locationID, int adminid, int authorid,int status)
        {
            BL.Book book = new BL.Book(title, isbn, categoryID, publisherID, publicationYear, edition, totalCopies, availableCopies, locationID, adminid, authorid,status);
            book.addBookToDatabase();
        }

        public void UpdateBook(string title, string isbn, int categoryID, int publisherID, int publicationYear, int edition, int totalCopies, int availableCopies, int locationID, int id, int authorid, int status)
        {
            BL.Book book = new BL.Book(title, isbn, categoryID, publisherID, publicationYear, edition, totalCopies, availableCopies, locationID, id, authorid, status);
            book.UpdateBookinDatabase();
        }
        public void UpdateAuthor(string fname, string lname, int id, DateTime dateofbirth, string nationality, int status,long cnic)
        {
            BL.Author author = new BL.Author(fname, lname, id, dateofbirth, nationality, status,cnic);
            author.UpdateAuthorInDatabase();
        }

        public void DeleteAuthor(string fname, string lname, int id, DateTime dateofbirth, string nationality, int status,long cnic)
        {
            BL.Author author = new BL.Author(fname, lname, id, dateofbirth, nationality, status, cnic);
            author.DeleteAuthorInDatabase();
        }

        public void DeleteCategory(int id, string name)
        {
            BL.Category category = new BL.Category(name, id);
            category.removeCategoryInDatabase();

        }

        public void updatePublisher(string publisherName, string publicationType, string publicationLanguage, int userid, string publisherAddress,string email, int status)
        {
            BL.Publisher pub = new Publisher(publisherName, publicationType, publicationLanguage, userid, publisherAddress,email, status);
            pub.UpdatePublisher();
        }
        public void DeletePublisher(string publisherName, string publicationType, string publicationLanguage, int userid, string publisherAddress,string email, int status)
        {
            BL.Publisher pub = new Publisher(publisherName, publicationType, publicationLanguage, userid, publisherAddress,email, status);
            pub.DeletePublisher();
        }
        public void UpdateLocation(int shelfNo, int capacity, int id)
        {
            BL.Location location = new Location(shelfNo, capacity, id);
            location.DeleteLocationInDatabase();
        }

        public void AddStudent(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate)
        {
            BL.Student student = new BL.Student(firstName, lastName, email, password, contact, cnic, city, usertype, registrationNo, department, semester, status, studentShip_StartDate);
            student.AddStudentInDatabase();
        }

        public void UpdateStudent(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate, int id)
        {
            BL.Student student = new BL.Student(firstName, lastName, email, password, contact, cnic, city, usertype, registrationNo, department, semester, status, studentShip_StartDate, id);
            student.UpdateStudentInDatabase();
        }
        public void DeleteStudent(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string registrationNo, string department, int semester, int status, DateTime studentShip_StartDate, int id)
        {
            BL.Student student = new BL.Student(firstName, lastName, email, password, contact, cnic, city, usertype, registrationNo, department, semester, status, studentShip_StartDate, id);
            student.RemoveStudentFromDatabase();
        }

        public void AddStaff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary, int status)
        {
            BL.Staff staff = new BL.Staff(firstName, lastName, email, password, contact, cnic, city, usertype, designation, salary, status);
            staff.AddStaffInDataBase();
        }
        public void UpdateStaff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary, int id, int status)
        {
            BL.Staff staff = new BL.Staff(firstName, lastName, email, password, contact, cnic, city, usertype, designation, salary, id, status);
            staff.UpdateStaffInDataBase();
        }
        public void DeleteStaff(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string usertype, string designation, float salary, int id, int status)
        {
            BL.Staff staff = new BL.Staff(firstName, lastName, email, password, contact, cnic, city, usertype, designation, salary, id, status);
            staff.RemoveStaffFromDataBase();
        }
        public void DeleteBook(string title, string isbn, int categoryID, int publisherID, int publicationYear, int edition, int totalCopies, int availableCopies, int locationID, int adminid, int authorid, int status)
        {
            BL.Book book = new BL.Book(title, isbn, categoryID, publisherID, publicationYear, edition, totalCopies, availableCopies, locationID, adminid, authorid, status);
            book.DeleteBookFromBase();
        }

        public void AddAdmin()
        {
            SqlTransaction transaction = null;

            try
            {

                var con = Configuration.getInstance().getConnection();
                transaction = con.BeginTransaction();
                string userInsertQuery = "INSERT INTO [User] (FirstName, LastName, Contact, CNIC, City, UserType) " +
                             "VALUES (@FirstName, @LastName, @Contact, @CNIC, @City, @UserType); SELECT SCOPE_IDENTITY()";
                SqlCommand userCommand = new SqlCommand(userInsertQuery, con,transaction);
                userCommand.Parameters.AddWithValue("@FirstName", FirstName);
                userCommand.Parameters.AddWithValue("@LastName", LastName);
                userCommand.Parameters.AddWithValue("@Contact", Contact);
                userCommand.Parameters.AddWithValue("@CNIC", CNIC);
                userCommand.Parameters.AddWithValue("@City", City);
                userCommand.Parameters.AddWithValue("@UserType", UserType);
                int userId = Convert.ToInt32(userCommand.ExecuteScalar());

                string auth = "Insert into Authentication (UserID,Email,Password) Values (@UserID,@Email,@Password)";
                SqlCommand cmd2 = new SqlCommand(auth, con, transaction);
                cmd2.Parameters.AddWithValue("@UserID", userId);
                cmd2.Parameters.AddWithValue("@Email", Email);
                cmd2.Parameters.AddWithValue("@Password", Password);
                cmd2.ExecuteNonQuery();
                string studentInsertQuery = "INSERT INTO Admin (UserID, Status) " + // Specify the columns here
                                "VALUES (@UserID, @Status)";
                SqlCommand adminCommand = new SqlCommand(studentInsertQuery, con, transaction);
                adminCommand.Parameters.AddWithValue("@UserID", userId);
                adminCommand.Parameters.AddWithValue("@Status", Status);
                adminCommand.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Admin Added Successfully");

            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void UpdateAdmin()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                string userInsertQuery = "UPDATE [User] SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, CNIC = @CNIC, City = @City, UserType = @UserType WHERE UserID = @UserID;";
                SqlCommand userCommand = new SqlCommand(userInsertQuery, con);
                userCommand.Parameters.AddWithValue("@FirstName", FirstName);
                userCommand.Parameters.AddWithValue("@LastName", LastName);
                userCommand.Parameters.AddWithValue("@Contact", Contact);
                userCommand.Parameters.AddWithValue("@CNIC", CNIC);
                userCommand.Parameters.AddWithValue("@City", City);
                userCommand.Parameters.AddWithValue("@UserType", UserType);
                userCommand.Parameters.AddWithValue("@UserID", UserID);
                userCommand.ExecuteNonQuery();

                string auth = "UPDATE Authentication SET Email = @Email, Password = @Password WHERE UserID = @UserID;";
                SqlCommand cmd2 = new SqlCommand(auth, con);
                cmd2.Parameters.AddWithValue("@UserID", UserID);
                cmd2.Parameters.AddWithValue("@Email", Email);
                cmd2.Parameters.AddWithValue("@Password", Password);
                cmd2.ExecuteNonQuery();
                string studentInsertQuery = "UPDATE Admin SET Status = @Status Where UserID = @UserID";
                SqlCommand adminCommand = new SqlCommand(studentInsertQuery, con);
                adminCommand.Parameters.AddWithValue("@UserID", UserID);
                adminCommand.Parameters.AddWithValue("@Status", Status);
                adminCommand.ExecuteNonQuery();
                MessageBox.Show("Admin Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void DeleteAdmin()
        {
            try
            {

                var con = Configuration.getInstance().getConnection();
                string studentInsertQuery = "UPDATE Admin SET Status = @Status Where UserID = @UserID";
                SqlCommand adminCommand = new SqlCommand(studentInsertQuery, con);
                adminCommand.Parameters.AddWithValue("@UserID", UserID);
                adminCommand.Parameters.AddWithValue("@Status", Status);
                adminCommand.ExecuteNonQuery();
                MessageBox.Show("Admin Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


    }
}

