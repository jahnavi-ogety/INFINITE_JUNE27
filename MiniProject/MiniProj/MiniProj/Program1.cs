using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Database
{

    private string connectionString = "data source=ICS-LT-CT2RQ73\\SQLEXPRESS;initial catalog=miniproj;User ID=sa;Password=123456789";

    public DataTable ExecuteQuery(string query)

    {
        try

        {

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;

            }

        }

        catch (Exception ex)

        {

            Console.WriteLine("An error occurred: " + ex.Message);

            return new DataTable(); 

        }

    }

    public void ExecuteNonQuery(string query)

    {

        try

        {

            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                cmd.ExecuteNonQuery();

            }

        }

        catch (Exception ex)

        {

            Console.WriteLine("An error occurred: " + ex.Message);

        }

    }

}

public class TrainException : Exception
{
    public TrainException(string message) : base(message)
    {
    }
}

public class BookingSystem
{
    private Database db = new Database();

    public void ListAvailableTrains()
    {
        string query = "SELECT tno, tname, seats_available FROM Trains WHERE train_status = 'active'";
        DataTable dt = db.ExecuteQuery(query);

        if (dt.Rows.Count == 0)
        {
            Console.WriteLine("No trains available.");
            return;
        }

        Console.WriteLine("Available Trains:");
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine($"Train Number: {row["tno"]}, Name: {row["tname"]}, Seats Available: {row["seats_available"]}");
        }
    }

    public void ListAllTrains()
    {
        string query = "SELECT tno, tname, seats_available, train_status FROM Trains";
        DataTable dt = db.ExecuteQuery(query);

        if (dt.Rows.Count == 0)
        {
            Console.WriteLine("No trains found.");
            return;
        }

        Console.WriteLine("All Trains:");
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine($"Train Number: {row["tno"]}, Name: {row["tname"]}, Seats Available: {row["seats_available"]}, Status: {row["train_status"]}");
        }
    }

    public void BookTickets(int tno, int userId, List<(string name, int age, string gender)> passengers)
    {
        if (passengers.Count > 3)
        {
            Console.WriteLine("You can only book up to 3 tickets.");
            return;
        }

        
        string query = $"SELECT seats_available, price FROM Trains WHERE tno = {tno} AND train_status = 'active'";
        DataTable dt = db.ExecuteQuery(query);
        if (dt.Rows.Count == 0)
        {
            Console.WriteLine("Train not available.");
            return;
        }

        int seatsAvailable = Convert.ToInt32(dt.Rows[0]["seats_available"]);
        int seatsToBook = passengers.Count;
        if (seatsAvailable < seatsToBook)
        {
            Console.WriteLine("Not enough seats available.");
            return;
        }

        decimal pricePerSeat = Convert.ToDecimal(dt.Rows[0]["price"]);
        decimal totalPrice = seatsToBook * pricePerSeat;

        // Insert booking
        string insertBooking = $"INSERT INTO Bookings (tno, user_id, seats_booked, booking_date, Total_Price) VALUES ({tno}, {userId}, {seatsToBook}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', {totalPrice})";
        db.ExecuteNonQuery(insertBooking);

        
        string getLastBooking= $"SELECT MAX(booking_id) FROM Bookings WHERE user_id = {userId}";
        DataTable lastBookingIdTable = db.ExecuteQuery(getLastBooking);
        int bookingId = Convert.ToInt32(lastBookingIdTable.Rows[0][0]);

        // For Inserting the passenger details
        foreach (var passenger in passengers)
        {
            string insertPassenger = $"INSERT INTO Passengers (booking_id, name, age, gender) VALUES ({bookingId}, '{passenger.name}', {passenger.age}, '{passenger.gender}')";
            db.ExecuteNonQuery(insertPassenger);
        }

        // Updating the seats available
        string updateSeats = $"UPDATE Trains SET seats_available = seats_available - {seatsToBook} WHERE tno = {tno}";
        db.ExecuteNonQuery(updateSeats);

        Console.WriteLine($" Thank you..Booking was successful. Total Price: ${totalPrice}");
    }

    public void ViewUserBookings(int userId)
    {
        string query = $"SELECT booking_id, tno, seats_booked, booking_date, Total_Price FROM Bookings WHERE user_id = {userId}";
        DataTable dt = db.ExecuteQuery(query);

        if (dt.Rows.Count == 0)
        {
            Console.WriteLine("No bookings found.");
            return;
        }

        Console.WriteLine("Your Bookings:");
        foreach (DataRow row in dt.Rows)
        {
            Console.WriteLine($"Booking ID: {row["booking_id"]}, Train Number: {row["tno"]}, Seats Booked: {row["seats_booked"]}, Booking Date: {row["booking_date"]}, Total Price: ${row["Total_Price"]}");
        }
    }

    public void AddTrain(int tno, string tname, string Source, string Destination, decimal price, string class_of_travel, string train_status, int seats_available, string Arrival_time, string Depature_time)
    {
        
        string checkQuery = $"SELECT COUNT(*) FROM Trains WHERE tno = {tno}";
        DataTable checkDt = db.ExecuteQuery(checkQuery);

        
        string insertTrain = $"INSERT INTO Trains (tno, tname, Source, Destination, price, class_of_travel, train_status, seats_available, Arrival_time, Depature_time) " +
                             $"VALUES ({tno}, '{tname}', '{Source}', '{Destination}', {price}, '{class_of_travel}', '{train_status}', {seats_available}, '{Arrival_time}', '{Depature_time}')";
        db.ExecuteNonQuery(insertTrain);

        Console.WriteLine("Train added successfully.");
    }

    

    public void DeleteTrain(int tno)
    {
        try
        {
            // Check if train number exists
            string checkQuery = $"SELECT COUNT(*) FROM Trains WHERE tno = {tno}";
            DataTable checkDt = db.ExecuteQuery(checkQuery);

            if (Convert.ToInt32(checkDt.Rows[0][0]) == 0)
            {
                Console.WriteLine("Train number does not exist.");
                return;
            }

            // Check if there are any bookings for this train
            string bookingQuery = $"SELECT COUNT(*) FROM Bookings WHERE tno = {tno}";
            DataTable bookingDt = db.ExecuteQuery(bookingQuery);

            if (Convert.ToInt32(bookingDt.Rows[0][0]) > 0)
            {
                throw new TrainException("This train cannot be deleted because there are existing bookings.");
            }

            // Delete train
            string deleteTrain = $"DELETE FROM Trains WHERE tno = {tno}";
            db.ExecuteNonQuery(deleteTrain);

            Console.WriteLine("Train deleted successfully.");
        }
        catch (TrainException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    public void ViewTicket(int bookingId)
    {
        string query = $@"SELECT b.tno, b.seats_booked, b.Total_Price, t.Source, t.Destination, t.class_of_travel, b.booking_date, p.name, p.age, p.gender,b.status 
                          FROM Bookings b
                          JOIN Trains t ON b.tno = t.tno 
                        left  JOIN Passengers p ON b.booking_id = p.booking_id
                          WHERE b.booking_id = {bookingId} ";
        DataTable dt = db.ExecuteQuery(query);

        if (dt.Rows.Count == 0)
        {
            Console.WriteLine("Booking not found.");
            return;
        }

        
        string status = dt.Rows[0]["status"].ToString();
        if
        (status =="Cancelled")
        {
            Console.WriteLine("This booking has been canceled and cannot be viewed.");
            return;
            
        }



        DataRow firstRow = dt.Rows[0];
        Console.WriteLine("****************************************");
        Console.WriteLine("------------Ticket Details:---------");
        Console.WriteLine($"Train Number: {firstRow["tno"]}");
        Console.WriteLine($"Seats Booked: {firstRow["seats_booked"]}");
        Console.WriteLine($"Source: {firstRow["Source"]}");
        Console.WriteLine($"Destination: {firstRow["Destination"]}");
        Console.WriteLine($"Booking Date: {firstRow["booking_date"]}");
        Console.WriteLine($"Class of Travel: {firstRow["class_of_travel"]}");
        Console.WriteLine($"Total Price: {firstRow["Total_Price"]}");
        Console.WriteLine("Passengers:");

        foreach (DataRow row in dt.Rows)
        {
            if (row["name"] != DBNull.Value)
            {
                Console.WriteLine($"  Name: {row["name"]}");
                Console.WriteLine($"  Age: {row["age"]}");
                Console.WriteLine($"  Gender: {row["gender"]}");
                Console.WriteLine();
            }
        }
        Console.WriteLine("----------------Happy Journey--------------------------");
        Console.WriteLine("*************************************************");
    }
}
public class CancellationSystem
{
    private Database db = new Database();

    public void CancelBooking(int bookingId, int seatsToCancel)
    {
        
        string query = $"SELECT tno, seats_booked, status FROM Bookings WHERE booking_id = {bookingId}";
        DataTable dt = db.ExecuteQuery(query);

        if (dt.Rows.Count == 0)
        {
            Console.WriteLine("Booking not found.");
            return;
        }

        int tno = Convert.ToInt32(dt.Rows[0]["tno"]);
        int seatsBooked = Convert.ToInt32(dt.Rows[0]["seats_booked"]);
        string status = dt.Rows[0]["status"].ToString();
        if (status == "Cancelled")
        {
            Console.WriteLine("Booking already cancelled.");
            return;
        }

        if (seatsToCancel > seatsBooked)
        {
            Console.WriteLine("Cannot cancel more seats than booked.");
            return;
        }

        
        string insertCancellation = $"INSERT INTO Cancellations (booking_id, seats_cancelled, cancellation_date) VALUES ({bookingId}, {seatsToCancel}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')";
        db.ExecuteNonQuery(insertCancellation);

        
        string updateSeats = $"UPDATE Trains Set seats_available = seats_available + {seatsToCancel} WHERE tno = {tno}";
        db.ExecuteNonQuery(updateSeats);

        int newseatsBooked = seatsBooked - seatsToCancel;
        string updateseatsBooked = $"update Bookings set seats_booked = {newseatsBooked} where booking_id = {bookingId}";
        db.ExecuteNonQuery(updateseatsBooked);

        

        if(seatsToCancel>0)
        {
            string deletepassengers = $"Delete from Passengers where booking_id= {bookingId} and passenger_id in (select top {seatsToCancel} passenger_id from passengers where booking_id = {bookingId})";

            db.ExecuteNonQuery(deletepassengers);
        }

        Console.WriteLine("Cancellation successful.");
        Console.WriteLine("Your amount will be refunded within 24 hours.");
    }
}

public class UserManager
{
    private Database db = new Database();

    public bool AuthenticateUser(string username, string password, out int userId, out string role, out string errorMessage)
    {
        string query = $"SELECT user_id, role FROM Users WHERE username = '{username}' AND password = '{password}'";
        DataTable dt = db.ExecuteQuery(query);

        if (dt.Rows.Count == 0)
        {
            userId = -1;
            role = null;
            errorMessage = "Incorrect username or password..";
            return false;
        }

        userId = Convert.ToInt32(dt.Rows[0]["user_id"]);
        role = dt.Rows[0]["role"].ToString();
        errorMessage = null;
        return true;
    }

    public bool RegisterUser(string username, string password, string role)
    {
        
        string checkQuery = $"SELECT COUNT(*) FROM Users WHERE username = '{username}'";
        DataTable checkDt = db.ExecuteQuery(checkQuery);

        if (Convert.ToInt32(checkDt.Rows[0][0]) > 0)
        {
            Console.WriteLine("Username already exists.");
            return false;
        }

        // Inserting the new user
        string insertUser = $"INSERT INTO Users (username, password, role) VALUES ('{username}', '{password}', '{role}')";
        db.ExecuteNonQuery(insertUser);

        Console.WriteLine("Registration successful.");
        return true;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        UserManager userManager = new UserManager();
        BookingSystem bookingSystem = new BookingSystem();
        CancellationSystem cancellationSystem = new CancellationSystem();

        Console.WriteLine("**********************************Welcome to Indian Railway Passenger Reservation*****************");
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
        Console.WriteLine("------------------------------------");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            if (choice == 1)
            {
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Username or password cannot be empty.");
                    return;
                }

                if (userManager.AuthenticateUser(username, password, out int userId, out string role, out string errorMessage))
                {
                    Console.WriteLine("Login successful. Role: " + role);

                    if (role == "admin")
                    {
                        // Admin Menu
                        while (true)
                        {
                            Console.WriteLine("Admin Menu:");
                            Console.WriteLine("1.Add New Train");
                            Console.WriteLine("2.Delete Train");
                            Console.WriteLine("3. View Trains");
                            Console.WriteLine("4.Exit");
                            if (int.TryParse(Console.ReadLine(), out int adminChoice))
                            {
                                if (adminChoice == 1)
                                {
                                    Console.WriteLine("Enter Train Number:");
                                    if (int.TryParse(Console.ReadLine(), out int tno))
                                    {
                                        Console.WriteLine("Enter Train Name:");
                                        string tname = Console.ReadLine();
                                        Console.WriteLine("Enter Source:");
                                        string Source = Console.ReadLine();
                                        Console.WriteLine("Enter Destination:");
                                        string Destination = Console.ReadLine();
                                        Console.WriteLine("Enter Price per Seat:");
                                        if (decimal.TryParse(Console.ReadLine(), out decimal price))
                                        {
                                            Console.WriteLine("Enter Class of Travel:");
                                            string classOfTravel = Console.ReadLine();
                                            Console.WriteLine("Enter Train Status:");
                                            string trainStatus = Console.ReadLine();
                                            Console.WriteLine("Enter Number of Seats Available:");
                                            if (int.TryParse(Console.ReadLine(), out int seatsAvailable))
                                            {
                                                Console.WriteLine("Enter Arrival Time:");
                                                string Arrival_time = Console.ReadLine();
                                                Console.WriteLine("Enter Depature Time:");
                                                string Depature_time = Console.ReadLine();
                                                bookingSystem.AddTrain(tno, tname, Source, Destination, price, classOfTravel, trainStatus, seatsAvailable, Arrival_time, Depature_time);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid number of seats.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid price.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid train number.");
                                    }
                                }
                                else if (adminChoice == 2)
                                {
                                    Console.Write("Enter Train Number to Delete: ");
                                    int tno = Convert.ToInt32(Console.ReadLine());
                                    bookingSystem.DeleteTrain(tno);
                                }
                                else if (adminChoice == 3)
                                {
                                    bookingSystem.ListAllTrains();
                                }
                                else if (adminChoice == 4)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice.");
                            }
                        }
                    }
                    else if (role == "user")
                    {
                        // User Menu
                        while (true)
                        {
                            Console.WriteLine("User Menu:");
                            Console.WriteLine(" 1.View Available Trains");
                            Console.WriteLine("2. Book Tickets");
                            Console.WriteLine("3. View My Bookings");
                            Console.WriteLine("4. Cancel Booking");
                            Console.WriteLine("5. View Ticket");
                            Console.WriteLine("6.Log Out");
                            Console.WriteLine("------------------------------------");
                            if (int.TryParse(Console.ReadLine(), out int userChoice))
                            {
                                if (userChoice == 1)
                                {
                                    bookingSystem.ListAvailableTrains();
                                }
                                else if (userChoice == 2)
                                {
                                    Console.WriteLine("Enter Train Number:");
                                    if (int.TryParse(Console.ReadLine(), out int tno))
                                    {
                                        Console.WriteLine("Enter Number of Seats to Book (up to 3):");
                                        if (int.TryParse(Console.ReadLine(), out int seatsToBook) && seatsToBook <= 3)
                                        {
                                            var passengers = new List<(string name, int age, string gender)>();

                                            for (int i = 0; i < seatsToBook; i++)
                                            {
                                                Console.WriteLine($"Enter details for passenger {i + 1}:");
                                                Console.WriteLine("Enter Name:");
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Enter Age:");
                                                if (int.TryParse(Console.ReadLine(), out int age))
                                                {
                                                    Console.WriteLine("Enter Gender:");
                                                    string gender = Console.ReadLine();
                                                    passengers.Add((name, age, gender));
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid age.");
                                                    return;
                                                }
                                            }

                                            bookingSystem.BookTickets(tno, userId, passengers);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid number of seats ,Maximum 3 can be Booked.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid train number.");
                                    }
                                }
                                else if (userChoice == 3)
                                {
                                    bookingSystem.ViewUserBookings(userId);
                                }
                                else if (userChoice == 4)
                                {
                                    Console.WriteLine("Enter Booking ID to Cancel:");
                                    if (int.TryParse(Console.ReadLine(), out int bookingId))
                                    {
                                        Console.WriteLine("Enter Number of Seats to Cancel:");
                                        if (int.TryParse(Console.ReadLine(), out int seatsToCancel))
                                        {
                                            cancellationSystem.CancelBooking(bookingId, seatsToCancel);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid number of seats.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid booking ID.");
                                    }
                                }
                                else if (userChoice == 5)
                                {
                                    Console.WriteLine("Enter Booking ID:");
                                    int bookingId = int.Parse(Console.ReadLine());
                                    bookingSystem.ViewTicket(bookingId);
                                }
                                else if (userChoice == 6)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
                Console.Read();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter new username:");
                string newUsername = Console.ReadLine();
                Console.WriteLine("Enter new password:");
                string newPassword = Console.ReadLine();
                Console.WriteLine("Enter role (user/admin):");
                string role = Console.ReadLine();

                if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(role))
                {
                    Console.WriteLine("Username, password, and role cannot be empty.");
                    return;
                }

                if (userManager.RegisterUser(newUsername, newPassword, role))
                {
                    Console.WriteLine("Thank you for registering. You can now log in.");
                }
                Console.Read();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

