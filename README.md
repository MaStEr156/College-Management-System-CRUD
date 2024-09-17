# College Management System

This project is a simple **University Management System** developed as part of the ITI .NET Core Track. It demonstrates the basic CRUD (Create, Read, Update, Delete) operations using **ASP.NET MVC** with the **Entity Framework** (Code First approach).

## Features
- Manage **Departments**, **Students**, and **Courses** within a university.
- Perform basic CRUD operations:
  - **Add** new records for departments, students, and courses.
  - **View** existing records.
  - **Update** existing records.
  - **Delete** records (soft delete option available).
- Uses **Entity Framework** for database management and **MVC** architecture for web development.
  
## Project Structure
### Models
1. **Department**: Represents university departments.
2. **Student**: Represents students and their details.
3. **Course**: Represents courses offered by departments.

### Controllers
1. **DepartmentController**: Manages department-related operations.
2. **StudentController**: Manages student-related operations.
3. **CourseController**: Manages course-related operations.

### Views
Each controller has a set of views for interacting with the user, including forms for adding, updating, and displaying data.

## Technologies Used
- **C#**: Primary programming language.
- **ASP.NET MVC**: Web framework used for building the application.
- **Entity Framework**: Code First approach for database interactions.
- **SQL Server**: Database for storing information.
- **HTML5/CSS3**: Frontend for user interfaces.
- **Razor View Engine**: Used to generate dynamic content in MVC views.

## How to Run
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/university-management-system.git
    ```
2. Open the project in **Visual Studio**.
3. Restore the NuGet packages and build the solution.
4. Update the **connection string** in the `appsettings.json` file to match your local database setup.
5. Run the project using Visual Studio. The application will launch in your default web browser.

## Database Setup
1. The project uses **Entity Framework Code First**. To create the database, run the following command in the **Package Manager Console**:
    ```bash
    Update-Database
    ```
2. This will generate the required database schema for Departments, Students, and Courses.

## Future Improvements
- Implement **pagination** for data-heavy views.
- Add **student-course enrollment** functionality.
- Implement **authentication and authorization** for role-based access.

## Contributing
If you'd like to contribute, feel free to fork the repository, make your changes, and submit a pull request!

## License
This project is licensed under the MIT License – see the LICENSE file for details.
