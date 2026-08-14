#include <cstring>
#include <iomanip>
#include <iostream>
#include <string>

using namespace std;

const int MAX_PRODUCTS = 100;
const int MAX_ORDER_ITEMS = 20;
const int MAX_ORDERS = 50;

// ==================== Product Class ====================

class Product
{
private:
    string name;
    double price;
    int quantity;

public:
    Product()
        : name(""), price(0), quantity(0)
    {
    }

    Product(const string& n, double p, int q)
        : name(n), price(p), quantity(q)
    {
    }

    void Show() const
    {
        cout << "Name: " << name << endl;
        cout << "Price: " << price << endl;
        cout << "Quantity: " << quantity << endl;
    }

    bool increaseStock(int amount)
    {
        if (amount <= 0)
        {
            cout << "Error: Increase amount must be positive!" << endl;
            return false;
        }

        quantity += amount;
        return true;
    }

    bool decreaseStock(int amount)
    {
        if (amount <= 0)
        {
            cout << "Error: Decrease amount must be positive!" << endl;
            return false;
        }

        if (amount > quantity)
        {
            cout << "Not enough quantity!" << endl;
            cout << "Current Quantity: " << quantity
                 << " Requested Amount: " << amount << endl;

            return false;
        }

        quantity -= amount;
        return true;
    }

    string getName() const
    {
        return name;
    }

    double getPrice() const
    {
        return price;
    }

    int getQuantity() const
    {
        return quantity;
    }
};

// ==================== Order Class ====================

class Order
{
private:
    string itemNames[MAX_ORDER_ITEMS];
    int itemQuantities[MAX_ORDER_ITEMS];
    int itemCount;

public:
    Order()
        : itemCount(0)
    {
    }

    void addItem(const string& name, int quantity)
    {
        if (itemCount < MAX_ORDER_ITEMS)
        {
            itemNames[itemCount] = name;
            itemQuantities[itemCount] = quantity;
            itemCount++;
        }
        else
        {
            cout << "Error: Order limit reached!" << endl;
        }
    }

    void show() const
    {
        if (itemCount == 0)
        {
            cout << "Order is Empty!" << endl;
            return;
        }

        cout << endl << "--- Order Details ---" << endl;

        for (int i = 0; i < itemCount; i++)
        {
            cout << "Product: " << itemNames[i]
                 << " | Quantity: " << itemQuantities[i] << endl;
        }

        cout << "----------------------" << endl;
    }

    int getItemCount() const
    {
        return itemCount;
    }

    string getItemName(int index) const
    {
        return itemNames[index];
    }

    int getItemQuantity(int index) const
    {
        return itemQuantities[index];
    }
};

// ==================== Warehouse Class ====================

class Warehouse
{
private:
    Product products[MAX_PRODUCTS];
    int productCount;

    int findProductIndex(const string& name) const
    {
        for (int i = 0; i < productCount; i++)
        {
            if (products[i].getName() == name)
            {
                return i;
            }
        }

        return -1;
    }

public:
    Warehouse()
        : productCount(0)
    {
    }

    void addProduct(const string& name, double price, int quantity)
    {
        int index = findProductIndex(name);

        if (index != -1)
        {
            products[index].increaseStock(quantity);

            cout << "This product already exists. "
                 << "Stock increased." << endl;
        }
        else
        {
            if (productCount < MAX_PRODUCTS)
            {
                products[productCount] =
                    Product(name, price, quantity);

                productCount++;

                cout << "New product added successfully." << endl;
            }
            else
            {
                cout << "Error: Warehouse capacity is full!" << endl;
            }
        }
    }

    void addStockToProduct(const string& name, int amount)
    {
        int index = findProductIndex(name);

        if (index != -1)
        {
            products[index].increaseStock(amount);

            cout << "The quantity of product increased." << endl;
        }
        else
        {
            cout << "Error: The product doesn't exist!" << endl;
        }
    }

    void showAllProducts() const
    {
        if (productCount == 0)
        {
            cout << "The stock is empty." << endl;
            return;
        }

        cout << endl << "===== Warehouse Product List ====="
             << endl;

        for (int i = 0; i < productCount; i++)
        {
            products[i].Show();
        }

        cout << "===================================" << endl;
    }

    bool isAvailable(
        const string& name,
        int requestedQty
    ) const
    {
        int index = findProductIndex(name);

        if (index == -1)
        {
            return false;
        }

        return products[index].getQuantity() >= requestedQty;
    }

    bool reduceStock(
        const string& name,
        int requestedQty
    )
    {
        int index = findProductIndex(name);

        if (index == -1)
        {
            return false;
        }

        return products[index].decreaseStock(requestedQty);
    }

    double getProductPrice(const string& name) const
    {
        int index = findProductIndex(name);

        if (index != -1)
        {
            return products[index].getPrice();
        }

        return -1;
    }

    void showLowStockItems(int threshold = 5) const
    {
        bool found = false;

        cout << endl
             << "LOW STOCK PRODUCTS (less than "
             << threshold << "):" << endl;

        for (int i = 0; i < productCount; i++)
        {
            if (products[i].getQuantity() < threshold)
            {
                products[i].Show();
                found = true;
            }
        }

        if (!found)
        {
            cout << "No low stock products found." << endl;
        }
    }
};

// ==================== InventoryManager Class ====================

class InventoryManager
{
private:
    Warehouse warehouse;
    Order ordersHistory[MAX_ORDERS];
    int ordersCount;

    bool canFulfillOrder(const Order& order) const
    {
        for (int i = 0; i < order.getItemCount(); i++)
        {
            if (!warehouse.isAvailable(
                    order.getItemName(i),
                    order.getItemQuantity(i)))
            {
                return false;
            }
        }

        return true;
    }

    void processOrder(const Order& order)
    {
        for (int i = 0; i < order.getItemCount(); i++)
        {
            warehouse.reduceStock(
                order.getItemName(i),
                order.getItemQuantity(i)
            );
        }
    }

    double calculateTotalPrice(const Order& order) const
    {
        double total = 0;

        for (int i = 0; i < order.getItemCount(); i++)
        {
            double price =
                warehouse.getProductPrice(
                    order.getItemName(i)
                );

            if (price > 0)
            {
                total += price * order.getItemQuantity(i);
            }
        }

        return total;
    }

public:
    InventoryManager()
        : ordersCount(0)
    {
    }

    void addProductToWarehouse()
    {
        string name;
        double price;
        int quantity;

        cout << "Product name: ";
        cin >> name;

        cout << "Price: ";
        cin >> price;

        cout << "Quantity: ";
        cin >> quantity;

        if (price < 0 || quantity < 0)
        {
            cout << "Error: Price and quantity cannot be negative."
                 << endl;
            return;
        }

        warehouse.addProduct(name, price, quantity);
    }

    void addStockToProduct()
    {
        string name;
        int amount;

        cout << "Product Name: ";
        cin >> name;

        cout << "Increase Amount: ";
        cin >> amount;

        if (amount <= 0)
        {
            cout << "Error: Increase amount must be positive!"
                 << endl;
            return;
        }

        warehouse.addStockToProduct(name, amount);
    }

    void registerNewOrder()
    {
        Order newOrder;
        int itemCount;

        cout << "Number of order items: ";
        cin >> itemCount;

        if (itemCount <= 0 ||
            itemCount > MAX_ORDER_ITEMS)
        {
            cout << "Error: Number of items must be between 1 and "
                 << MAX_ORDER_ITEMS << endl;
            return;
        }

        for (int i = 0; i < itemCount; i++)
        {
            string name;
            int quantity;

            cout << "Product name " << i + 1 << ": ";
            cin >> name;

            cout << "Requested quantity: ";
            cin >> quantity;

            if (quantity <= 0)
            {
                cout << "Error: Quantity must be positive. "
                     << "This item was ignored." << endl;
                continue;
            }

            newOrder.addItem(name, quantity);
        }

        if (canFulfillOrder(newOrder))
        {
            processOrder(newOrder);

            double totalPrice =
                calculateTotalPrice(newOrder);

            if (ordersCount < MAX_ORDERS)
            {
                ordersHistory[ordersCount] = newOrder;
                ordersCount++;
            }

            cout << endl
                 << "Order placed successfully!" << endl;

            cout << "Total order amount: "
                 << fixed
                 << setprecision(0)
                 << totalPrice
                 << endl;
        }
        else
        {
            cout << endl
                 << "Order rejected! Insufficient stock "
                 << "for some items." << endl;

            cout << "No changes were made to the warehouse."
                 << endl;
        }

        cout << endl
             << "--- Warehouse Status After This Request ---"
             << endl;

        warehouse.showAllProducts();
        warehouse.showLowStockItems(5);
    }

    void showAllOrders() const
    {
        if (ordersCount == 0)
        {
            cout << "No orders have been placed." << endl;
            return;
        }

        cout << endl
             << "========== LIST OF REGISTERED ORDERS =========="
             << endl;

        for (int i = 0; i < ordersCount; i++)
        {
            cout << endl
                 << "Order #" << i + 1 << ":" << endl;

            ordersHistory[i].show();
        }

        cout << "================================================"
             << endl;
    }

    void showWarehouseStatus() const
    {
        warehouse.showAllProducts();
        warehouse.showLowStockItems(5);
    }
};

// ==================== Menu ====================

void showMenu()
{
    cout << endl
         << "========== WAREHOUSE MANAGEMENT SYSTEM MENU =========="
         << endl;

    cout << "1. Add product to warehouse" << endl;
    cout << "2. Increase stock of existing product" << endl;
    cout << "3. Show available products" << endl;
    cout << "4. Register new order" << endl;
    cout << "5. Show list of orders" << endl;
    cout << "6. Exit" << endl;

    cout << "========================================================"
         << endl;

    cout << "Your choice: ";
}

// ==================== Main ====================

int main()
{
    InventoryManager manager;
    int choice;

    do
    {
        showMenu();
        cin >> choice;

        if (cin.fail())
        {
            cin.clear();
            cin.ignore(10000, '\n');

            cout << "Invalid input! Please enter a number."
                 << endl;

            continue;
        }

        switch (choice)
        {
        case 1:
            manager.addProductToWarehouse();
            break;

        case 2:
            manager.addStockToProduct();
            break;

        case 3:
            manager.showWarehouseStatus();
            break;

        case 4:
            manager.registerNewOrder();
            break;

        case 5:
            manager.showAllOrders();
            break;

        case 6:
            cout << "Exiting program..." << endl;
            break;

        default:
            cout << "Invalid option! "
                 << "Please choose 1 to 6." << endl;
        }

    } while (choice != 6);

    return 0;
}