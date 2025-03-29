<h1 align="center">CasePan</h1>

![Image](https://github.com/user-attachments/assets/ac7013f7-42a3-4d6e-837d-9a9db8690165)

<h2>Description:</h2>

This project was developed as part of the technical test for the Junior Software Engineer position at Banco Pan.

It is an API that implements CRUD (Create, Read, Update, Delete) operations and connects to a PostgreSQL database. The API offers endpoints to manage users, allowing for data creation, updating, deletion, and querying. The goal is to provide a robust and efficient framework for handling user data, with a focus on simplicity and scalability of operations.


<h2>Project structure</h2>

The project is organized in a way that ensures clarity and scalability. Below is a summary of the main folders and files:

- **`Controllers/`**: Responsible for managing HTTP requests and delegating actions to the corresponding services.  

- **`Services/`**: Contains the business logic, implementing CRUD methods and other operations related to users.  

- **`DTOs/`**: Defines data transfer objects used for communication between application layers.  

- **`Validators/`**: Contains the necessary validations to ensure that the provided data is consistent and valid before being processed.  

- **`Exceptions/`**: Defines custom exceptions and error handling for a clear and controlled response in case of failures.  

- **`Migrations/`**: Database migration files, managing changes to the schema structure.  

- **`Models/`**: Represents database entities, such as the User model.  

- **`Data/`**: Contains database access configuration and defines the data context, using Entity Framework to facilitate persistence operations.

<h2>API endpoints</h2>

The API exposes the following endpoints to manage users:

- **`GET /api/user/GetAllUsers`**  
  Returns all users registered in the system.

- **`GET /api/user/GetUserById/{idUser}`**  
  Returns the details of a specific user, identified by their ID.

- **`POST /api/user/SaveUser`**  
  Creates a new user based on the data provided in the request body.

- **`PUT /api/user/EditUser`**  
  Updates an existing user's data based on the provided information.

- **`DELETE /api/user/DeleteUser`**  
  Deletes a user from the system, identified by their ID.

<h2>Installation:</h2>

To install the project, you can download it as a .zip file or clone it directly from GitHub.

### Download as .zip

1. Access the repository on GitHub: [CasePan](https://github.com/YuriLopess/CasePan)  
2. Click on "Code" and select "Download ZIP".  
3. Extract the ZIP file to your preferred directory.  

### Clone with Git  

1. Open the terminal.  

2. Navigate to the directory where you want to clone the repository.  

3. Run the following command:  

   ```sh
   git clone https://github.com/YuriLopess/CasePan.git
<h2>Prerequisites:</h2>

Before running the project, it is necessary to have the following tools and technologies installed:

- .NET 8
- PostgreSQL
- Entity Framework Core
- Tools for database migration (Ex: EF Core CLI)


<h2>Running the Project Locally:</h2> 

1. Clone the repository to your local machine.

2. Navigate to the project folder in the terminal.

3. Configure the connection to the PostgreSQL database in the `appsettings.json` file.

4. Run the database migrations with the following command:


   ```sh
   dotnet ef database update
5. Start the project with the:

    ```sh
    dotnet run
<h2>Contact:</h2>

If you have any questions or want to discuss about the project, please feel free to contact me via this email: **[costalopesyuri@gmail.com](mailto:costalopesyuri@gmail.com)**
