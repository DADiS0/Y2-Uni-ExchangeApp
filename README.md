# Y2-Uni-ExchangeApp

**University Project (2nd Year) | Simple Currency Exchange & Account Management**

A lightweight desktop/web application developed as a second-year university assignment. It provides basic account creation, deposits/withdrawals, transfers, and currency conversion—all with a minimal UI and no advanced security features.

## Features

* **User Accounts**

  * Create and manage simple customer accounts
  * Deposit and withdraw funds

* **Transfers & Remittances**

  * Send money between accounts
  * Modify or cancel pending transfers

* **Currency Conversion**

  * Convert balances between different currencies
  * Manual entry of buy/sell rates (no automated rate feeds)

* **Admin Panel**

  * Basic user management (view, add, delete accounts)

## Tech Stack

* **Backend:** *(Your chosen language/framework)*
* **Database:** *(e.g., SQLite / MySQL)*
* **Frontend:** Simple HTML/CSS/JS or basic GUI toolkit
* **Manual rate management—no external APIs**

## Installation & Usage

1. **Clone the repository**

   ```bash
   git clone https://github.com/YourUsername/Y2-Uni-ExchangeApp.git
   cd Y2-Uni-ExchangeApp
   ```

2. **Install dependencies**

   ```bash
   # Example for Python
   pip install -r requirements.txt
   ```

3. **Configure database**

   * Create and migrate your local database
   * (Optional) Edit the manual exchange rates file or settings

4. **Run the application**

   ```bash
   # Example for a web app
   python manage.py runserver
   ```

5. **Access the UI**

   * Open `http://localhost:8000/` in your browser
   * Use the admin panel at `/admin` to manage users (if enabled)

## Notes

* This is a **student-level** project with a **simple interface** and **no production-grade security**.
* Exchange rates must be entered and updated manually.
* Ideal for learning fundamentals of account management, basic CRUD operations, and simple currency logic.

---

> *Built as part of a 2nd-year Information Technology curriculum project.*
