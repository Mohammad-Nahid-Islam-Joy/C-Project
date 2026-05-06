# Food Ordering CRUD Application

## Project Overview
This project is a comprehensive desktop-based Food Ordering Management System developed as part of the Object-Oriented Programming 2 (OOP2) course. It provides users with a seamless experience from browsing menus to receiving meals, facilitating interactions between customers, restaurants, and system administrators. 

## Key Features
* **Role-based Access:** Secure login and registration system supporting Customers, Admins (Restaurant Managers), and SuperAdmins.
* **Customer Dashboard:** Allows users to browse food items, customize orders (ingredients, portion sizes), manage their cart, and submit reviews/ratings.
* **Restaurant Management:** Full CRUD (Create, Read, Update, Delete) operations for restaurant administrators to manage their menus, pricing, and stock availability.
* **Order Processing:** Seamless tracking of orders from placement to delivery, including total cost calculation and status updates.
* **System Administration:** Oversight of system integrity, user/restaurant management, and transaction monitoring.

## Tech Stack
* **Programming Language:** C#
* **User Interface:** Windows Forms (WinForms) for a desktop-based GUI
* **Database:** SQL (Relational Database System with structured queries and foreign key constraints)

## Database Schema
The backend relies on a normalized relational database containing the following tables:
* `Users`: Stores user credentials, contact info, and roles.
* `Restaurants`: Stores details of registered restaurants and links them to Admin users.
* `MenuItems`: Holds the catalog of food items, prices, and stock for each restaurant.
* `Orders` & `OrderDetails`: Manages transactional data, selected items, and delivery statuses.
* `Cart`: Temporarily holds user selections prior to checkout.
* `Reviews`: Captures customer feedback and ratings (1-5) for specific items.

## Academic Context
This project was developed for academic purposes at **American International University–Bangladesh (AIUB)**.
* **Course:** CSC2210: Object Oriented Programming 2 (Spring 2025-2026)
* **Section:** EE (Group 00)
* **Supervisor:** Dr. Md Iftekharul Mobin

### Development Team
| Name | ID |
| :--- | :--- |
| Mohammad Nahid Islam Joy | 24–58077–2 |
| Nurain Akter Rayma | 24–58080–2 |
| Aparajita Saha Ananna | 24–58018–2 |
| Sushree Haldar | 24–57427–2 |
