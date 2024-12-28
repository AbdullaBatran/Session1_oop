namespace Session1_oop
{
    internal class Program
    {
        // Define the WeekDays enum
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        // Define the Season enum
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        [Flags]
        enum Permissions
        {
            None = 0,       // No permission
            Read = 1 << 0,  // 1 (binary 0001)
            Write = 1 << 1, // 2 (binary 0010)
            Delete = 1 << 2, // 4 (binary 0100)
            Execute = 1 << 3 // 8 (binary 1000)
        }
        // Define the Colors enum
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        // Define the Point struct
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            // Constructor to initialize X and Y
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            // Method to calculate distance to another point
            public double DistanceTo(Point other)
            {
                return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
            }
        }
        static void Main(string[] args)
        {

            // ******************************************** Assignment_1_OOP **********************************************//
            #region  Question 1

            ////Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            ////Then, write a C# program that prints out all the days of the week using this enum.

            //// Iterate through all values of the WeekDays enum and print them
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Question 2
            ////Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            ////Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();

            //// Try to parse the input to a Season enum
            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    // Display the corresponding month range
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season.");
            //}


            #endregion

            #region Question 3

            ////Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            ////Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //// Create a variable to store permissions
            //Permissions userPermissions = Permissions.None;

            //// Add permissions
            //userPermissions |= Permissions.Read;  // Add Read
            //userPermissions |= Permissions.Write; // Add Write
            //Console.WriteLine($"Permissions after adding Read and Write: {userPermissions}");

            //// Check if a specific permission exists
            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("Read permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission does not exist.");
            //}

            //// Remove a permission
            //userPermissions &= ~Permissions.Read; // Remove Read
            //Console.WriteLine($"Permissions after removing Read: {userPermissions}");

            //// Check if a specific permission exists again
            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("Read permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission does not exist.");
            //}

            #endregion

            #region Question 4
            //// Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user
            //// and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color name (Red, Green, Blue): ");
            //string input = Console.ReadLine();

            //// Try to parse the input to a Colors enum
            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    // Check if the color is a primary color
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid color name.");
            //}


            #endregion

            #region Question 5

            ////Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            ////Write a C# program that takes two points as input from the user and calculates the distance between them.


            //// Input for the first point
            //Console.WriteLine("Enter the X coordinate of the first point:");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the first point:");
            //double y1 = double.Parse(Console.ReadLine());

            //// Input for the second point
            //Console.WriteLine("Enter the X coordinate of the second point:");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate of the second point:");
            //double y2 = double.Parse(Console.ReadLine());

            //// Create Point instances
            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //// Calculate the distance
            //double distance = point1.DistanceTo(point2);

            //// Output the result
            //Console.WriteLine($"The distance between the two points is: {distance:F2}");


            #endregion 
        }
    }
}
