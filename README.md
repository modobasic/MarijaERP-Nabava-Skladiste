# MarijaERP

An ERP prototype for procurement and warehouse management, developed using C# WinForms with a Microsoft SQL Server database.

## Running the Project

1. Create a database named `MarijaERP` in Microsoft SQL Server.
2. Run the SQL script: `SQLMarijaERP.sql`.
3. Open `MarijaERP.sln` in Visual Studio.
4. Check the connection string in `Database.cs`.
5. Run the application.

## Features

* Inventory overview
* Items and suppliers
* Purchase orders
* LOT-based goods receipt
* FIFO inventory issuing
* Business reports
* LOT traceability

## Modules

### Dashboard

Monitoring of total inventory value, quantities, LOT layers, and alerts.

### Items

Overview of items, minimum and safety stock levels, and suppliers.

### Purchase Orders

Creation and tracking of open purchase orders.

### Goods Receipt

LOT-based receipt of goods, including warehouse, delivery note, and expiration-date records.

### Inventory

FIFO issuing of goods from LOT layers.

### Reports

Overview of open items and inventory value.

### LOT Traceability

Tracking the complete movement of a LOT through the system.

## Technologies

* C#
* WinForms
* Microsoft SQL Server
* ADO.NET
* GitHub

## Author

Marija Odobašić
