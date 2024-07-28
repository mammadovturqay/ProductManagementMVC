# ProductManagementMVC
# ProductManagementMVC

This project is an ASP.NET Core MVC application designed to manage a list of products. It allows users to create, read, update, and delete products (CRUD operations) without using a database or JSON files. Instead, the data is stored in a static list within the controller. The application features basic validation and user interactions are handled using JavaScript.

## Features

1. **Product Listing (Index)**
   - Displays a list of all products with their name, description, price, and discount.
   - Each product entry includes links to view details, edit, and delete the product.

2. **Product Details**
   - Shows detailed information about a specific product.

3. **Create Product**
   - Allows users to add a new product to the list.
   - The new product form includes fields for name, description, price, and discount.

4. **Edit Product**
   - Provides a form to update an existing product’s information.

5. **Delete Product**
   - Allows users to delete a product from the list.
   - Deletion is handled via JavaScript, which sends a POST request to the server to remove the product.

## How to Run the Project

1. Clone the repository or download the project files.
2. Open the project in Visual Studio or any preferred IDE.
3. Build the project to restore the dependencies.
4. Run the project (F5 or `dotnet run`).
5. Open a browser and navigate to `https://localhost:{port}/Products`.

