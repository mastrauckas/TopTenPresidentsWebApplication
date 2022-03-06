using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopTenPresidents.Data.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
{
               migrationBuilder.Sql
                    (@"
                         INSERT INTO Names(FirstName, MiddleName, LastName, DateOfBirth, DateOfDeath)
                         VALUES
                         ('George', NULL, 'Washington', '02/22/1732', '12/14/1799'),
                         ('John', NULL, 'Adams', '10/30/1735', '07/04/1826'),
                         ('Thomas', NULL, 'Jefferson', '04/13/1743', '07/04/1826'),
                         ('James', NULL, 'Madison', '03/16/1751', '06/28/1836'),
                         ('James', NULL, 'Monroe', '04/28/1758', '07/04/1831'), 
                         ('John', 'Quincy', 'Adams', '07/11/1767', '02/23/1848'),
                         ('Andrew', NULL, 'Jackson', '03/15/1767', '06/08/1845'), 
                         ('Martin', 'Van', 'Buren', '12/05/1782', '07/24/1862'),
                         ('William', 'Henry', 'Harrison', '02/09/1773', '04/04/1841'),
                         ('John', NULL, 'Tyler', '03/29/1790', '01/18/1862'),
                         ('James', 'K', 'Polk', '11/02/1795', '06/15/1849'), 
                         ('Zachary', 'K', 'Taylor', '11/24/1784', '07/09/1850'),
                         ('Millard', NULL, 'Fillmore', '01/07/1800', '03/08/1874'),
                         ('Franklin', NULL, 'Pierce', '11/23/1804', '10/08/1869'),
                         ('James', NULL, 'Buchanan', '04/23/1791', '06/01/1868'),
                         ('Abraham', NULL, 'Lincoln', '02/12/1809', '04/15/1865'),
                         ('Andrew', NULL, 'Johnson', '12/29/1808', '07/31/1875'),
                         ('Ulysses', 'S.', 'Grant', '04/27/1822', '07/23/1885'),
                         ('Rutherford', 'B.', 'Hayes', '10/04/1822', '01/17/1893'),
                         ('James', 'A.', 'Garfield', '11/19/1831', '09/19/1881'),
                         ('Chester', 'A.', 'Arthur', '10/05/1829', '11/18/1886'),
                         ('Grover', NULL, 'Cleveland', '03/18/1837', '06/24/1908'), --Elected twice.
                         ('Benjamin', NULL, 'Harrison', '08/20/1833', '03/13/1901'), 
                         ('William', NULL, 'McKinley', '01/29/1843', '09/14/1901'),
                         ('Theodore', NULL, 'Roosevelt', '10/27/1858', '01/06/1919'),
                         ('William', 'Howard', 'Taft', '09/15/1857', '03/08/1930'),
                         ('Woodrow', NULL, 'Wilson', '12/28/1856', '02/03/1924'),
                         ('Warren', 'G.', 'Harding', '11/02/1865', '08/02/1923'), 
                         ('Calvin', NULL, 'Coolidge', '07/04/1872', '01/05/1933'),
                         ('Herbert', NULL, 'Hoover', '08/10/1874', '10/20/1964'), 
                         ('Franklin', 'D.', 'Roosevelt', '01/30/1882', '04/12/1945'),
                         ('Harry', 'S.', 'Truman', '05/08/1884', '12/26/1972'), 
                         ('Dwight', 'D.', 'Eisenhower', '10/14/1890', '03/28/1969'),
                         ('John', 'F.', 'Kennedy', '04/29/1917', '11/22/1963'), 
                         ('Lyndon', 'B.', 'Johnson', '08/27/1908', '01/22/1973'), 
                         ('Richard', NULL, 'Nixon', '01/09/1913', '04/22/1994'), 
                         ('Gerald', NULL, 'Ford', '07/14/1913', '12/26/2006'),
                         ('Jimmy', NULL, 'Carter', '10/01/1924', NULL),
                         ('Ronald', NULL, 'Reagan', '02/06/1911', '06/05/2004'),
                         ('George', 'H. W.', 'Bush', '06/12/1924', '11/30/2018'), 
                         ('Bill', NULL, 'Clinton', '08/19/1946', NULL), 
                         ('George', 'W.', 'Bush', '07/06/1946', NULL), 
                         ('Barack', NULL, 'Obama', '08/04/1961', NULL),
                         ('Donald', 'J.', 'Trump', '06/14/1946', NULL),
                         ('Joe', NULL, 'Biden', '11/20/1942', NULL); 
                    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
