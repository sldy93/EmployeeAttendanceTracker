using System;
using Microsoft.EntityFrameworkCore.Migrations;
using EmployeeAttendanceTracker;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeAttendanceTracker.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Add1", "Add2", "City", "DeptCode", "FirstName", "HireDate", "JobCode", "LastName", "Phone", "State", "Zip" },
                values: new object[,]
                {
                    { 1, "543 Rosetta Avenue", "", "Florissant", "MK", "Paul", new DateTime(1986, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Plodder", "314-837-9610", "MO", "63031" },
                    { 2, "4652 Blue Willow", "", "Imperial", "CL", "George", new DateTime(1990, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Arfuss", "314-942-3153", "MO", "63052" },
                    { 3, "3229 Highland Ave.", "", "Oakland", "CL", "Tom", new DateTime(1989, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADM", "Turtle", "314-781-0402", "MO", "63139" },
                    { 4, "0520 Ashbrook Drive", "", "Oakland", "AC", "William", new DateTime(1987, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "SRA", "Jones", "314-868-4412", "MO", "63027" },
                    { 5, "32 Fenway", "", "Ferguson", "MK", "John", new DateTime(1991, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "MKM", "Jones", "314-522-0861", "MO", "63135" },
                    { 6, "1226 Rio Silva Place", "Apt. H", "Oakland", "CL", "Anthony", new DateTime(1988, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLE", "Jones", "314-431-1578", "MO", "63111" },
                    { 7, "442 Brotherton Lane", "", "Oakland", "CL", "Kyle", new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLE", "Jones", "314-522-3623", "MO", "63135" },
                    { 8, "3228 Edison Ave.", "", "Oakland", "MK", "Kelley", new DateTime(1987, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Berty", "314-781-8798", "MO", "63121" },
                    { 9, "6520 Lincoln Park West", "", "Chicago", "MK", "George", new DateTime(1986, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "MacElroy", "312-748-7817", "IL", "54614" },
                    { 10, "1234 Paule Drive", "", "Oakland", "AC", "James", new DateTime(1990, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "McDunnel", "314-831-6826", "MO", "63125" },
                    { 11, "5417 Lone Elm Drive.", "", "Oakland", "AC", "Thomas", new DateTime(1994, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ACM", "McDunnel", "314-467-6937", "MO", "63125" },
                    { 12, "1244 South Broadway", "", "Oakland", "MK", "Thomas", new DateTime(1988, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Smith", "314-354-1446", "MO", "63111" },
                    { 13, "8725 McKinley Road", "", "Joplin", "CL", "Martin", new DateTime(1987, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Jukes", "314-933-2903", "MO", "63119" },
                    { 14, "4340 A Watson Road", "", "Oakland", "SL", "August", new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Smith", "314-262-1105", "MO", "63119" },
                    { 15, "21318 Parsons Blvd.", "", "Flushing", "SL", "Richard", new DateTime(1990, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Arfuss", "618-922-0987", "IL", "54355" },
                    { 16, "12 Manson Avenue", "", "St. Peters", "AC", "Sean", new DateTime(1987, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "SRA", "Arfuss", "314-721-3338", "MO", "63376" },
                    { 17, "1530 Watson Road", "Lot #15", "Oakland", "MK", "Arthur", new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Mueller", "314-849-4515", "MO", "63127" },
                    { 18, "1201 Crestshire Lane", "", "St. Ann", "CL", "James", new DateTime(1993, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Miller", "314-427-3557", "MO", "63121" },
                    { 19, "4311 B. Alfred Ave.", "", "Oakland", "MK", "Daniel", new DateTime(1988, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Mueller", "314-773-4463", "MO", "63110" },
                    { 20, "431 Monteith Circle", "", "Oakland", "AC", "Michael", new DateTime(1989, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "Milkwagin", "314-867-1131", "MO", "63137" },
                    { 21, "8712 Oakland", "Apt 205", "Oakland", "SL", "Michael", new DateTime(1987, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "SMN", "Neuner", "314-645-7773", "MO", "63139" },
                    { 22, "5430 Queeney Ave.", "", "Sauget", "SL", "Kenn", new DateTime(1988, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Ortega", "314-386-5776", "IL", "54206" },
                    { 23, "4876 Gallant Fox Drive", "", "Florissant", "AC", "Phil", new DateTime(1989, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "Will", "314-831-4416", "MO", "63033" },
                    { 24, "341 Imperial Lane", "", "Fenton", "MK", "Sally", new DateTime(1989, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Sellum", "314-343-1992", "MO", "63026" },
                    { 25, "5447 Astoria Ave.", "", "Oakland", "MK", "Barney", new DateTime(1986, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Varfuss", "314-868-5218", "MO", "63137" },
                    { 26, "6515 Bischoff Ave.", "", "Oakland", "SL", "Joseph", new DateTime(1991, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Tummyfill", "314-865-3739", "Mo", "63110" },
                    { 27, "Box 33 Rt. #7", "", "New Douglas", "AC", "Steve", new DateTime(1991, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "SRA", "Rockford", "217-456-6376", "IL", "54074" },
                    { 28, "312 Bellerive Acres", "", "Oakland", "CL", "Daniel", new DateTime(1987, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLE", "Daly", "314-389-2339", "MO", "63121" },
                    { 29, "3214 Loughborough Ave.", "", "Oakland", "CL", "Salvatore", new DateTime(1989, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Malt", "314-352-3347", "MO", "63109" },
                    { 30, "2155 Ripple St.", "", "Oakland", "CL", "Thomas", new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLE", "Smith", "314-644-2765", "MO", "63139" },
                    { 31, "654 Albert Ave", "", "Oakland", "SL", "Richard", new DateTime(1988, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Smythe", "314-822-3561", "MO", "63122" },
                    { 32, "7864 Queeney Ave.", "", "Sauget", "SL", "Thomas", new DateTime(1986, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Smiley", "618-337-6451", "IL", "54206" },
                    { 33, "2312 Graham Street", "", "Oakland", "AC", "George", new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "Rockford", "314-644-5926", "MO", "63139" },
                    { 34, "657 Bella Lane", "", "Oakland", "MK", "Jeffrey", new DateTime(1989, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Fawlty", "314-867-4474", "MO", "63137" },
                    { 35, "3449 Arsenal St.", "", "Oakland", "SL", "Daniel", new DateTime(1986, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Steadman", "314-772-0772", "MO", "63118" },
                    { 36, "7837 Walsh Street", "", "Oakland", "SL", "Gregory", new DateTime(1991, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Jones", "314-351-0984", "MO", "63116" },
                    { 37, "1242 Meramec Street", "", "Oakland", "SL", "Gregory", new DateTime(1991, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Eliot", "314-752-0287", "MO", "63118" },
                    { 38, "5444 Walsh Street", "", "Oakland", "MK", "Jeffrey", new DateTime(1985, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Willow", "314-352-4678", "MO", "63116" },
                    { 39, "8938 Leona Street", "", "Oakland", "AC", "Robert", new DateTime(1988, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "Stiner", "314-752-1712", "MO", "63116" },
                    { 40, "3246 Buddie Drive", "", "Hazelwood", "CL", "Lawrence", new DateTime(1987, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLE", "Nessman", "314-524-3344", "MO", "63042" },
                    { 41, "148 Highland Ave.", "", "Kirkwood", "CL", "Robert", new DateTime(1988, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Sulley", "314-822-3468", "MO", "63122" },
                    { 42, "1641 Atmore Drive.", "", "Ferguson", "CL", "Leonard", new DateTime(1985, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Birdwall", "314-869-1243", "MO", "63136" },
                    { 43, "612 Berry Road", "P.O. Box 121", "Woodriver", "SL", "Terry", new DateTime(1986, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Kubick", "618-259-0855", "IL", "54095" },
                    { 44, "5643 Osceola Street", "", "Oakland", "MK", "James", new DateTime(1987, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Webster", "314-353-4335", "MO", "63111" },
                    { 45, "3250  Hiawatha Ave.", "", "St.Louis", "AC", "Arthur", new DateTime(1990, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "SRA", "Waffles", "314-781-1285", "MO", "63117" },
                    { 46, "8765 Tower Grove Place", "", "Oakland", "CL", "Merrell", new DateTime(1990, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLE", "Varfuss", "314-773-2917", "MO", "63110" },
                    { 47, "314 Porchester Drive", "", "Oakland", "CL", "James", new DateTime(1989, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Williams", "314-544-9268", "MO", "63125" },
                    { 48, "876 Mildred Ave.", "", "Oakland", "AC", "Robert", new DateTime(1988, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "Walleye", "314-962-4569", "MO", "63119" },
                    { 49, "438 Highland Drive", "", "Oakland", "CL", "Kenny", new DateTime(1985, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Feltz", "314-487-9555", "MO", "63129" },
                    { 50, "5430 Roxbury Drive", "", "Oakland", "MK", "Andrew", new DateTime(1985, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Varfuss", "314-487-2181", "MO", "63125" },
                    { 51, "8704 Edwards Road", "", "Oakland", "AC", "Terry", new DateTime(1990, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "Fitzgerald", "314-487-4933", "MO", "63125" },
                    { 52, "8122 Richman Place", "", "Oakland", "AC", "Lawrence", new DateTime(1989, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "SRA", "Winer", "314-647-6692", "MO", "63143" },
                    { 53, "Box 654 R.R.#1", "", "Millstadt", "SL", "Steve", new DateTime(1986, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Maverick", "618-476-3398", "IL", "54260" },
                    { 54, "3402 Davison", "", "Clayton", "SL", "Karl", new DateTime(1990, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SLS", "Kong", "314-721-2334", "MO", "63105" },
                    { 55, "7679 Schollmeyer Ave.", "", "Oakland", "AC", "Joseph", new DateTime(1990, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "JRA", "Wiliams", "314-481-7091", "MO", "63109" },
                    { 56, "654 Duchess Ct.", "", "Oakland", "MK", "Jules", new DateTime(1988, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Billiard", "314-838-1571", "MO", "63131" },
                    { 57, "143 Willowcreek", "", "Edwardsville", "MK", "Michael", new DateTime(1989, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "EDT", "Smith", "618-656-4444", "IL", "54026" },
                    { 58, "5321 Lloyd Ave.", "", "Oakland", "CL", "Joseph", new DateTime(1990, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLE", "Jones", "314-644-2278", "MO", "63139" },
                    { 59, "45 Main Street", "", "St. Peters", "CL", "James", new DateTime(1991, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Caline", "314-962-4344", "MO", "63376" },
                    { 60, "5655 Morganford Road", "", "Oakland", "CL", "Kevin", new DateTime(1985, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Plodder", "314-771-3377", "MO", "63116" },
                    { 61, "4000 Ashbrook", "", "St. Louis", "AC", "Kim", new DateTime(1987, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEC", "Taylor", "314-868-9876", "MO", "63137" }
                });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "AbsDate", "EmployeeId", "Excused", "Hours" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Y", 4f },
                    { 2, new DateTime(1998, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Y", 8f },
                    { 3, new DateTime(1998, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "N", 8f },
                    { 4, new DateTime(1998, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "N", 8f },
                    { 5, new DateTime(1998, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Y", 8f },
                    { 6, new DateTime(1998, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "N", 2f },
                    { 7, new DateTime(1999, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "N", 8f },
                    { 8, new DateTime(1999, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Y", 4f }
                });

            migrationBuilder.InsertData(
                table: "Dependents",
                columns: new[] { "Id", "Birthday", "DepName", "EmployeeId" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex", 3 },
                    { 2, new DateTime(1984, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", 3 },
                    { 3, new DateTime(1989, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biff", 8 },
                    { 4, new DateTime(1987, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billy", 8 },
                    { 5, new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Butch", 8 },
                    { 6, new DateTime(1986, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather", 22 },
                    { 7, new DateTime(1986, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holly", 22 },
                    { 8, new DateTime(1983, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mary", 27 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dependents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
