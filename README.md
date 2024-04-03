Capstone project~ This application was made specifically to simulate online payments (3rd party transactions), customer self-service of the order status, and the ability to cancel an order if the status is "Not Shipped"

To properly test the application you must have Visual Studio and SQL Server Management (SSMS).

Follow these steps:
Launch Visual Studio > Tools > NuGet Package Manager > Package Manager Console (PCM) > Run the following commands one at a time.

Install-Package Microsoft.EntityFrameworkCore.SqlServer/
Install-Package Microsoft.EntityFrameworkCore.Design/
Add-Migration InitialCreate/
Update-Database/

Finally, restart Visual Studios (might not be necessary, but I had to for it to work properly)
