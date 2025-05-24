# IndyaPay Dashboard

A full-stack ASP.NET Web Forms application to simulate mobile recharge operations and display transaction history, built as a developer assessment project.

---

## 🚀 Features

- 🔌 Recharge simulation using dummy API (`https://jsonplaceholder.typicode.com`)
- 🗃️ Logs all API requests and responses into the `APILogs` table via **ADO.NET**
- 📊 Recharge records stored in the `Recharge` table using **Entity Framework**
- 📈 Recharge History page with filtering by operator and date
- 🧭 Dashboard with simple navigation and modular structure
- 🎨 Clean UI with a green-white-midnight blue theme
- 🖼️ Custom branding with IndyaPay logo

---

## 📁 Project Structure

FinServices_Dashboard/
│
├── App_Data/ # Contains IndyaPayNewDB.mdf (LocalDB)
├── Models/ # EF model and DbContext (Recharge.cs, RechargeContext.cs)
├── Logs/ # ADO.NET logging class (APILogging.cs)
├── Pages/ # All main .aspx pages
│ ├── Dashboard.aspx
│ ├── RechargeAPI.aspx
│ └── RechargeHistory.aspx
├── Content/ # Custom CSS + logo
│ └── logo_indyapay.jpg
│ └── site.css
├── Site.Master # Master layout page
├── Web.config # Contains database connection string


---

Tech Stack

- ASP.NET Web Forms (.NET Framework 4.x)
- Entity Framework 6
- ADO.NET (SqlClient)
- Bootstrap (CSS framework)
- SQL Server LocalDB (`.mdf`)
- Visual Studio 2022

---

Setup Instructions

1. Clone the repository:
   ```bash
2. git clone https://github.com/Sai-prakash19/IndyaPay-Dashboard.git

3. Open the solution file FinServices_Dashboard.sln in Visual Studio 2022.

4. Make sure IndyaPayNewDB.mdf is present in App_Data.

Update the connection string in Web.config if needed:
<connectionStrings>
  <add name="RechargeDB1"
       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\IndyaPayNewDB.mdf;Integrated Security=True;MultipleActiveResultSets=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>

5. Run the project (F5) and navigate between:

/Pages/Dashboard.aspx

/Pages/RechargeAPI.aspx

/Pages/RechargeHistory.aspx
