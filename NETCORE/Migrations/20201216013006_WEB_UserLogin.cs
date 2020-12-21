using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCORE.Migrations
{
    public partial class WEB_UserLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            var sp = @"CREATE PROCEDURE[dbo].[WEB_UserLogin]
                        @username varchar(50),
	                    @password varchar(50)
                    AS
                    BEGIN
                        select empCode as id,nameEN as username,'123456' as password,position,department,section
                        from WEB_EmployeeList where Status = 1
                        and rtrim(nameEN) = @username
                        and @password = '123456'
                    END";



            migrationBuilder.Sql(sp);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
            
    }
}
