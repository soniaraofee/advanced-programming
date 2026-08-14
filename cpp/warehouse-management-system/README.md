# Warehouse Management System

A simple **Warehouse Management System** implemented in **C++** using Object-Oriented Programming (OOP) concepts.

The program allows users to manage warehouse products, control stock quantities, register customer orders, and view warehouse and order information through a console-based menu.

## Features

* Add new products to the warehouse
* Increase the stock of existing products
* Display all available products
* Register new orders
* Check product availability before processing an order
* Automatically decrease stock after a successful order
* Calculate the total price of an order
* Display all registered orders
* Display low-stock products
* Validate user input
* Limit the number of products, orders, and items per order

## Classes

### `Product`

Represents a product stored in the warehouse.

**Attributes:**

* Product name
* Price
* Quantity

**Main methods:**

* `Show()`
* `increaseStock()`
* `decreaseStock()`
* `getName()`
* `getPrice()`
* `getQuantity()`

### `Order`

Represents a customer order containing multiple products.

**Main methods:**

* `addItem()`
* `show()`
* `getItemCount()`
* `getItemName()`
* `getItemQuantity()`

### `Warehouse`

Manages all products and their stock.

**Main responsibilities:**

* Add products
* Increase product stock
* Search for products
* Check product availability
* Reduce stock
* Get product prices
* Display warehouse products
* Display low-stock products

### `InventoryManager`

Acts as the main manager of the system.

It connects the warehouse and orders and handles:

* Creating products
* Adding stock
* Registering orders
* Checking whether an order can be fulfilled
* Processing orders
* Calculating order totals
* Storing order history
* Displaying warehouse status

## Program Menu

After running the program, the following menu is displayed:

```text
========== WAREHOUSE MANAGEMENT SYSTEM MENU ==========
1. Add product to warehouse
2. Increase stock of existing product
3. Show available products
4. Register new order
5. Show list of orders
6. Exit
========================================================
Your choice:
```

### 1. Add Product

Allows the user to add a new product by entering:

* Product name
* Price
* Quantity

If the product already exists, its stock is increased.

### 2. Increase Stock

Allows the user to increase the quantity of an existing product.

The requested amount must be positive.

### 3. Show Available Products

Displays all products currently stored in the warehouse, including:

* Name
* Price
* Quantity

It also displays products whose quantity is below the low-stock threshold.

### 4. Register New Order

The user specifies the number of items and enters the product name and requested quantity for each item.

Before processing the order, the system checks whether enough stock is available.

If the order can be fulfilled:

1. Stock is reduced.
2. The total order price is calculated.
3. The order is added to the order history.

If there is insufficient stock, the order is rejected and no stock is changed.

### 5. Show List of Orders

Displays all successfully registered orders and their items and quantities.

### 6. Exit

Terminates the program.

## Constants

The program uses the following limits:

```cpp
const int MAX_PRODUCTS = 100;
const int MAX_ORDER_ITEMS = 20;
const int MAX_ORDERS = 50;
```

| Constant          | Description                | Limit |
| ----------------- | -------------------------- | ----: |
| `MAX_PRODUCTS`    | Maximum number of products |   100 |
| `MAX_ORDER_ITEMS` | Maximum items in one order |    20 |
| `MAX_ORDERS`      | Maximum stored orders      |    50 |

## Object-Oriented Programming Concepts

This project demonstrates several important C++ OOP concepts:

* **Classes and Objects**
* **Encapsulation**
* **Private and Public Members**
* **Constructors**
* **Member Functions**
* **Arrays of Objects**
* **Composition**
* **Const Member Functions**
* **Access Control**
* **Basic Input Validation**

The relationship between the main classes can be summarized as:

```text
InventoryManager
       |
       +------ Warehouse
       |          |
       |          +------ Product
       |
       +------ Order
```

## Example

A successful order may produce output similar to:

```text
Order placed successfully!
Total order amount: 1500
```

After processing the order, the warehouse status is displayed and the updated stock quantities can be checked.

## Limitations

This is a console-based educational project, so it currently has some limitations:

* Data is stored only in memory.
* Products and orders are lost when the program exits.
* Product names are currently read as single words.
* There is no database or file storage.
* The system does not include user authentication.
* The number of products and orders is limited by fixed-size arrays.

## Future Improvements

Possible improvements include:

* Use `vector` instead of fixed-size arrays
* Store data in files
* Add database support
* Support product names containing spaces
* Add product IDs
* Add order IDs
* Add product removal and editing
* Add customer information
* Improve input validation
* Add a graphical user interface
* Separate classes into `.h` and `.cpp` files

## Project Purpose

This project was created as a practice project for learning and applying **C++ Object-Oriented Programming** concepts in a practical scenario.

It demonstrates how multiple classes can work together to build a small but functional inventory and order management system.
