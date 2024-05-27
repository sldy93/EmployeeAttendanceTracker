using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendanceTracker
{
    public class SeedData
    {
        public static List<Employee> Employees = new List<Employee>
        {

            new Employee {Id = 1, LastName = "Plodder", FirstName = "Paul", Add1 = "543 Rosetta Avenue", Add2 = "", City = "Florissant", State = "MO", Zip = "63031", Phone = "314-837-9610", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Apr 19 1986 12:00AM") },
            new Employee {Id = 2, LastName = "Arfuss", FirstName = "George", Add1 = "4652 Blue Willow", Add2 = "", City = "Imperial", State = "MO", Zip = "63052", Phone = "314-942-3153", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Jan 12 1990 12:00AM") },
            new Employee {Id = 3, LastName = "Turtle", FirstName = "Tom", Add1 = "3229 Highland Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63139", Phone = "314-781-0402", DeptCode = "CL", JobCode = "ADM", HireDate = DateTime.Parse("Dec 10 1989 12:00AM") },
            new Employee {Id = 4, LastName = "Jones", FirstName = "William", Add1 = "0520 Ashbrook Drive", Add2 = "", City = "Oakland", State = "MO", Zip = "63027", Phone = "314-868-4412", DeptCode = "AC", JobCode = "SRA", HireDate = DateTime.Parse("Jun 12 1987 12:00AM") },
            new Employee {Id = 5, LastName = "Jones", FirstName = "John", Add1 = "32 Fenway", Add2 = "", City = "Ferguson", State = "MO", Zip = "63135", Phone = "314-522-0861", DeptCode = "MK", JobCode = "MKM", HireDate = DateTime.Parse("Jan 14 1991 12:00AM") },
            new Employee {Id = 6, LastName = "Jones", FirstName = "Anthony", Add1 = "1226 Rio Silva Place", Add2 = "Apt. H", City = "Oakland", State = "MO", Zip = "63111", Phone = "314-431-1578", DeptCode = "CL", JobCode = "CLE", HireDate = DateTime.Parse("Feb  3 1988 12:00AM") },
            new Employee {Id = 7, LastName = "Jones", FirstName = "Kyle", Add1 = "442 Brotherton Lane", Add2 = "", City = "Oakland", State = "MO", Zip = "63135", Phone = "314-522-3623", DeptCode = "CL", JobCode = "CLE", HireDate = DateTime.Parse("Sep 22 1992 12:00AM") },
            new Employee {Id = 8, LastName = "Berty", FirstName = "Kelley", Add1 = "3228 Edison Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63121", Phone = "314-781-8798", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Aug 17 1987 12:00AM") },
            new Employee {Id = 9, LastName = "MacElroy", FirstName = "George", Add1 = "6520 Lincoln Park West", Add2 = "", City = "Chicago", State = "IL", Zip = "54614", Phone = "312-748-7817", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Mar  7 1986 12:00AM") },
            new Employee {Id = 10, LastName = "McDunnel", FirstName = "James", Add1 = "1234 Paule Drive", Add2 = "", City = "Oakland", State = "MO", Zip = "63125", Phone = "314-831-6826", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("Dec 11 1990 12:00AM") },
            new Employee {Id = 11, LastName = "McDunnel", FirstName = "Thomas", Add1 = "5417 Lone Elm Drive.", Add2 = "", City = "Oakland", State = "MO", Zip = "63125", Phone = "314-467-6937", DeptCode = "AC", JobCode = "ACM", HireDate = DateTime.Parse("Sep 15 1994 12:00AM") },
            new Employee {Id = 12, LastName = "Smith", FirstName = "Thomas", Add1 = "1244 South Broadway", Add2 = "", City = "Oakland", State = "MO", Zip = "63111", Phone = "314-354-1446", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Aug 19 1988 12:00AM") },
            new Employee {Id = 13, LastName = "Jukes", FirstName = "Martin", Add1 = "8725 McKinley Road", Add2 = "", City = "Joplin", State = "MO", Zip = "63119", Phone = "314-933-2903", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Apr 29 1987 12:00AM") },
            new Employee {Id = 14, LastName = "Smith", FirstName = "August", Add1 = "4340 A Watson Road", Add2 = "", City = "Oakland", State = "MO", Zip = "63119", Phone = "314-262-1105", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Apr 21 1990 12:00AM") },
            new Employee {Id = 15, LastName = "Arfuss", FirstName = "Richard", Add1 = "21318 Parsons Blvd.", Add2 = "", City = "Flushing", State = "IL", Zip = "54355", Phone = "618-922-0987", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Feb 28 1990 12:00AM") },
            new Employee {Id = 16, LastName = "Arfuss", FirstName = "Sean", Add1 = "12 Manson Avenue", Add2 = "", City = "St. Peters", State = "MO", Zip = "63376", Phone = "314-721-3338", DeptCode = "AC", JobCode = "SRA", HireDate = DateTime.Parse("Oct 19 1987 12:00AM") },
            new Employee {Id = 17, LastName = "Mueller", FirstName = "Arthur", Add1 = "1530 Watson Road", Add2 = "Lot #15", City = "Oakland", State = "MO", Zip = "63127", Phone = "314-849-4515", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Sep  1 1986 12:00AM") },
            new Employee {Id = 18, LastName = "Miller", FirstName = "James", Add1 = "1201 Crestshire Lane", Add2 = "", City = "St. Ann", State = "MO", Zip = "63121", Phone = "314-427-3557", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Aug  1 1993 12:00AM") },
            new Employee {Id = 19, LastName = "Mueller", FirstName = "Daniel", Add1 = "4311 B. Alfred Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63110", Phone = "314-773-4463", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("May  3 1988 12:00AM") },
            new Employee {Id = 20, LastName = "Milkwagin", FirstName = "Michael", Add1 = "431 Monteith Circle", Add2 = "", City = "Oakland", State = "MO", Zip = "63137", Phone = "314-867-1131", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("Jul  5 1989 12:00AM") },
            new Employee {Id = 21, LastName = "Neuner", FirstName = "Michael", Add1 = "8712 Oakland", Add2 = "Apt 205", City = "Oakland", State = "MO", Zip = "63139", Phone = "314-645-7773", DeptCode = "SL", JobCode = "SMN", HireDate = DateTime.Parse("Jul 27 1987 12:00AM") },
            new Employee {Id = 22, LastName = "Ortega", FirstName = "Kenn", Add1 = "5430 Queeney Ave.", Add2 = "", City = "Sauget", State = "IL", Zip = "54206", Phone = "314-386-5776", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Mar 17 1988 12:00AM") },
            new Employee {Id = 23, LastName = "Will", FirstName = "Phil", Add1 = "4876 Gallant Fox Drive", Add2 = "", City = "Florissant", State = "MO", Zip = "63033", Phone = "314-831-4416", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("Nov  9 1989 12:00AM") },
            new Employee {Id = 24, LastName = "Sellum", FirstName = "Sally", Add1 = "341 Imperial Lane", Add2 = "", City = "Fenton", State = "MO", Zip = "63026", Phone = "314-343-1992", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Jun 12 1989 12:00AM") },
            new Employee {Id = 25, LastName = "Varfuss", FirstName = "Barney", Add1 = "5447 Astoria Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63137", Phone = "314-868-5218", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Aug  6 1986 12:00AM") },
            new Employee {Id = 26, LastName = "Tummyfill", FirstName = "Joseph", Add1 = "6515 Bischoff Ave.", Add2 = "", City = "Oakland", State = "Mo", Zip = "63110", Phone = "314-865-3739", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Apr 23 1991 12:00AM") },
            new Employee {Id = 27, LastName = "Rockford", FirstName = "Steve", Add1 = "Box 33 Rt. #7", Add2 = "", City = "New Douglas", State = "IL", Zip = "54074", Phone = "217-456-6376", DeptCode = "AC", JobCode = "SRA", HireDate = DateTime.Parse("May 14 1991 12:00AM") },
            new Employee {Id = 28, LastName = "Daly", FirstName = "Daniel", Add1 = "312 Bellerive Acres", Add2 = "", City = "Oakland", State = "MO", Zip = "63121", Phone = "314-389-2339", DeptCode = "CL", JobCode = "CLE", HireDate = DateTime.Parse("Aug 19 1987 12:00AM") },
            new Employee {Id = 29, LastName = "Malt", FirstName = "Salvatore", Add1 = "3214 Loughborough Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63109", Phone = "314-352-3347", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Nov 22 1989 12:00AM") },
            new Employee {Id = 30, LastName = "Smith", FirstName = "Thomas", Add1 = "2155 Ripple St.", Add2 = "", City = "Oakland", State = "MO", Zip = "63139", Phone = "314-644-2765", DeptCode = "CL", JobCode = "CLE", HireDate = DateTime.Parse("Nov  1 1991 12:00AM") },
            new Employee {Id = 31, LastName = "Smythe", FirstName = "Richard", Add1 = "654 Albert Ave", Add2 = "", City = "Oakland", State = "MO", Zip = "63122", Phone = "314-822-3561", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Apr 16 1988 12:00AM") },
            new Employee {Id = 32, LastName = "Smiley", FirstName = "Thomas", Add1 = "7864 Queeney Ave.", Add2 = "", City = "Sauget", State = "IL", Zip = "54206", Phone = "618-337-6451", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Nov  9 1986 12:00AM") },
            new Employee {Id = 33, LastName = "Rockford", FirstName = "George", Add1 = "2312 Graham Street", Add2 = "", City = "Oakland", State = "MO", Zip = "63139", Phone = "314-644-5926", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("Dec  1 1990 12:00AM") },
            new Employee {Id = 34, LastName = "Fawlty", FirstName = "Jeffrey", Add1 = "657 Bella Lane", Add2 = "", City = "Oakland", State = "MO", Zip = "63137", Phone = "314-867-4474", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Feb 14 1989 12:00AM") },
            new Employee {Id = 35, LastName = "Steadman", FirstName = "Daniel", Add1 = "3449 Arsenal St.", Add2 = "", City = "Oakland", State = "MO", Zip = "63118", Phone = "314-772-0772", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Jul 23 1986 12:00AM") },
            new Employee {Id = 36, LastName = "Jones", FirstName = "Gregory", Add1 = "7837 Walsh Street", Add2 = "", City = "Oakland", State = "MO", Zip = "63116", Phone = "314-351-0984", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Aug 17 1991 12:00AM") },
            new Employee {Id = 37, LastName = "Eliot", FirstName = "Gregory", Add1 = "1242 Meramec Street", Add2 = "", City = "Oakland", State = "MO", Zip = "63118", Phone = "314-752-0287", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Aug 22 1991 12:00AM") },
            new Employee {Id = 38, LastName = "Willow", FirstName = "Jeffrey", Add1 = "5444 Walsh Street", Add2 = "", City = "Oakland", State = "MO", Zip = "63116", Phone = "314-352-4678", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Mar 18 1985 12:00AM") },
            new Employee {Id = 39, LastName = "Stiner", FirstName = "Robert", Add1 = "8938 Leona Street", Add2 = "", City = "Oakland", State = "MO", Zip = "63116", Phone = "314-752-1712", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("May 17 1988 12:00AM") },
            new Employee {Id = 40, LastName = "Nessman", FirstName = "Lawrence", Add1 = "3246 Buddie Drive", Add2 = "", City = "Hazelwood", State = "MO", Zip = "63042", Phone = "314-524-3344", DeptCode = "CL", JobCode = "CLE", HireDate = DateTime.Parse("Jan 18 1987 12:00AM") },
            new Employee {Id = 41, LastName = "Sulley", FirstName = "Robert", Add1 = "148 Highland Ave.", Add2 = "", City = "Kirkwood", State = "MO", Zip = "63122", Phone = "314-822-3468", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Nov 25 1988 12:00AM") },
            new Employee {Id = 42, LastName = "Birdwall", FirstName = "Leonard", Add1 = "1641 Atmore Drive.", Add2 = "", City = "Ferguson", State = "MO", Zip = "63136", Phone = "314-869-1243", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Oct  2 1985 12:00AM") },
            new Employee {Id = 43, LastName = "Kubick", FirstName = "Terry", Add1 = "612 Berry Road", Add2 = "P.O. Box 121", City = "Woodriver", State = "IL", Zip = "54095", Phone = "618-259-0855", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Dec  1 1986 12:00AM") },
            new Employee {Id = 44, LastName = "Webster", FirstName = "James", Add1 = "5643 Osceola Street", Add2 = "", City = "Oakland", State = "MO", Zip = "63111", Phone = "314-353-4335", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Sep 27 1987 12:00AM") },
            new Employee {Id = 45, LastName = "Waffles", FirstName = "Arthur", Add1 = "3250  Hiawatha Ave.", Add2 = "", City = "St.Louis", State = "MO", Zip = "63117", Phone = "314-781-1285", DeptCode = "AC", JobCode = "SRA", HireDate = DateTime.Parse("Jul 24 1990 12:00AM") },
            new Employee {Id = 46, LastName = "Varfuss", FirstName = "Merrell", Add1 = "8765 Tower Grove Place", Add2 = "", City = "Oakland", State = "MO", Zip = "63110", Phone = "314-773-2917", DeptCode = "CL", JobCode = "CLE", HireDate = DateTime.Parse("Feb 27 1990 12:00AM") },
            new Employee {Id = 47, LastName = "Williams", FirstName = "James", Add1 = "314 Porchester Drive", Add2 = "", City = "Oakland", State = "MO", Zip = "63125", Phone = "314-544-9268", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("May 12 1989 12:00AM") },
            new Employee {Id = 48, LastName = "Walleye", FirstName = "Robert", Add1 = "876 Mildred Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63119", Phone = "314-962-4569", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("Sep 14 1988 12:00AM") },
            new Employee {Id = 49, LastName = "Feltz", FirstName = "Kenny", Add1 = "438 Highland Drive", Add2 = "", City = "Oakland", State = "MO", Zip = "63129", Phone = "314-487-9555", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Dec  5 1985 12:00AM") },
            new Employee {Id = 50, LastName = "Varfuss", FirstName = "Andrew", Add1 = "5430 Roxbury Drive", Add2 = "", City = "Oakland", State = "MO", Zip = "63125", Phone = "314-487-2181", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Mar  5 1985 12:00AM") },
            new Employee {Id = 51, LastName = "Fitzgerald", FirstName = "Terry", Add1 = "8704 Edwards Road", Add2 = "", City = "Oakland", State = "MO", Zip = "63125", Phone = "314-487-4933", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("Mar  1 1990 12:00AM") },
            new Employee {Id = 52, LastName = "Winer", FirstName = "Lawrence", Add1 = "8122 Richman Place", Add2 = "", City = "Oakland", State = "MO", Zip = "63143", Phone = "314-647-6692", DeptCode = "AC", JobCode = "SRA", HireDate = DateTime.Parse("Aug 18 1989 12:00AM") },
            new Employee {Id = 53, LastName = "Maverick", FirstName = "Steve", Add1 = "Box 654 R.R.#1", Add2 = "", City = "Millstadt", State = "IL", Zip = "54260", Phone = "618-476-3398", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Jul  7 1986 12:00AM") },
            new Employee {Id = 54, LastName = "Kong", FirstName = "Karl", Add1 = "3402 Davison", Add2 = "", City = "Clayton", State = "MO", Zip = "63105", Phone = "314-721-2334", DeptCode = "SL", JobCode = "SLS", HireDate = DateTime.Parse("Jul 15 1990 12:00AM") },
            new Employee {Id = 55, LastName = "Wiliams", FirstName = "Joseph", Add1 = "7679 Schollmeyer Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63109", Phone = "314-481-7091", DeptCode = "AC", JobCode = "JRA", HireDate = DateTime.Parse("Feb 24 1990 12:00AM") },
            new Employee {Id = 56, LastName = "Billiard", FirstName = "Jules", Add1 = "654 Duchess Ct.", Add2 = "", City = "Oakland", State = "MO", Zip = "63131", Phone = "314-838-1571", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Oct 18 1988 12:00AM") },
            new Employee {Id = 57, LastName = "Smith", FirstName = "Michael", Add1 = "143 Willowcreek", Add2 = "", City = "Edwardsville", State = "IL", Zip = "54026", Phone = "618-656-4444", DeptCode = "MK", JobCode = "EDT", HireDate = DateTime.Parse("Dec  3 1989 12:00AM") },
            new Employee {Id = 58, LastName = "Jones", FirstName = "Joseph", Add1 = "5321 Lloyd Ave.", Add2 = "", City = "Oakland", State = "MO", Zip = "63139", Phone = "314-644-2278", DeptCode = "CL", JobCode = "CLE", HireDate = DateTime.Parse("Jan  6 1990 12:00AM") },
            new Employee {Id = 59, LastName = "Caline", FirstName = "James", Add1 = "45 Main Street", Add2 = "", City = "St. Peters", State = "MO", Zip = "63376", Phone = "314-962-4344", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Jan 22 1991 12:00AM") },
            new Employee {Id = 60, LastName = "Plodder", FirstName = "Kevin", Add1 = "5655 Morganford Road", Add2 = "", City = "Oakland", State = "MO", Zip = "63116", Phone = "314-771-3377", DeptCode = "CL", JobCode = "SEC", HireDate = DateTime.Parse("Apr 15 1985 12:00AM") },
            new Employee {Id = 61, LastName = "Taylor", FirstName = "Kim", Add1 = "4000 Ashbrook", Add2 = "", City = "St. Louis", State = "MO", Zip = "63137", Phone = "314-868-9876", DeptCode = "AC", JobCode = "SEC", HireDate = DateTime.Parse("Aug 17 1987 12:00AM") },
        };

        public static List<Absence> Absences = new List<Absence>
        {
            new Absence {Id = 1, EmployeeId=1, AbsDate = DateTime.Parse("Sep 15 1998 12:00AM"), Hours = 4, Excused = "Y", },
            new Absence {Id = 2, EmployeeId=1,AbsDate = DateTime.Parse("Sep 26 1998 12:00AM"), Hours = 8, Excused = "Y", },
            new Absence {Id = 3, EmployeeId=3,AbsDate = DateTime.Parse("Aug 12 1998 12:00AM"), Hours = 8, Excused = "N", },
            new Absence {Id = 4, EmployeeId=3,AbsDate = DateTime.Parse("Sep 27 1998 12:00AM"), Hours = 8, Excused = "N", },
            new Absence {Id = 5, EmployeeId=8,AbsDate = DateTime.Parse("Aug 26 1998 12:00AM"), Hours = 8, Excused = "Y", },
            new Absence {Id = 6, EmployeeId=9,AbsDate = DateTime.Parse("Sep 27 1998 12:00AM"), Hours = 2, Excused = "N", },
            new Absence {Id = 7, EmployeeId=12,AbsDate = DateTime.Parse("Jan  8 1999 12:00AM"), Hours = 8, Excused = "N", },
            new Absence {Id = 8, EmployeeId=20,AbsDate = DateTime.Parse("Jan  6 1999 12:00AM"), Hours = 4, Excused = "Y", },

        };


        public static List<Dependent> Dependents = new List<Dependent>
        {
            new Dependent {Id = 1, EmployeeId = 3, DepName = "Alex", Birthday = DateTime.Parse("Oct 31 1980 12:00AM"), },
            new Dependent {Id = 2, EmployeeId = 3, DepName = "Alice", Birthday = DateTime.Parse("Feb 27 1984 12:00AM"), },
            new Dependent {Id = 3, EmployeeId = 8, DepName = "Biff", Birthday = DateTime.Parse("Nov  1 1989 12:00AM"), },
            new Dependent {Id = 4, EmployeeId = 8, DepName = "Billy", Birthday = DateTime.Parse("Apr  3 1987 12:00AM"), },
            new Dependent {Id = 5, EmployeeId = 8, DepName = "Butch", Birthday = DateTime.Parse("May 31 1985 12:00AM"), },
            new Dependent {Id = 6, EmployeeId = 22, DepName = "Heather", Birthday = DateTime.Parse("Dec  1 1986 12:00AM"), },
            new Dependent {Id = 7, EmployeeId = 22, DepName = "Holly", Birthday = DateTime.Parse("Dec  1 1986 12:00AM"), },
            new Dependent {Id = 8, EmployeeId = 27, DepName = "Mary", Birthday = DateTime.Parse("Aug 15 1983 12:00AM"), },
        };
    }
    }
