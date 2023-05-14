using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Books (Name, ReleaseDate, Description) VALUES ('Harry1', '9-7-1999', 'Huhuhu')");
            migrationBuilder.Sql($"INSERT INTO Books (Name, ReleaseDate, Description) VALUES ('Harry2', '9-7-1999', 'Huhuhu')");
            migrationBuilder.Sql($"INSERT INTO Books (Name, ReleaseDate, Description) VALUES ('Harry3', '9-7-1999', 'Huhuhu')");
            migrationBuilder.Sql($"INSERT INTO Books (Name, ReleaseDate, Description) VALUES ('Harry4', '9-7-1999', 'Huhuhu')");
            migrationBuilder.Sql($"INSERT INTO Books (Name, ReleaseDate, Description) VALUES ('Harry5', '9-7-1999', 'Huhuhu')");
            migrationBuilder.Sql($"INSERT INTO Books (Name, ReleaseDate, Description) VALUES ('Harry6', '9-7-1999', 'Huhuhu')");
            migrationBuilder.Sql($"INSERT INTO Books (Name, ReleaseDate, Description) VALUES ('Harry7', '9-7-1999', 'Huhuhu')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
