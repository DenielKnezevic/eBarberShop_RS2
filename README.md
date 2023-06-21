# eBarberShop_RS2

The eBarbershop project is a comprehensive software solution that caters to both clients and administrators in a barber shop setting. The project encompasses a mobile app for clients and a Windows forms application for administration.

## Mobile App (Client-side)
The mobile app offers an intuitive platform for clients to conveniently interact with the eBarbershop. Its key features include:

- Appointment Booking: Clients can easily schedule appointments with their preferred barbers through the app.
- Rating and Feedback: Clients have the ability to provide ratings and feedback for the services they receive.
- Shop Purchases: The app provides a seamless shopping experience, allowing clients to purchase products directly from the shop.

## Windows Forms App (Administration-side)
The Windows forms application serves as a robust administration tool for efficient management of the eBarbershop. Its key functionalities include:

- Appointment Management: Administrators can add new appointments, ensuring a streamlined scheduling process.
- Media and Employee Management: The app allows administrators to upload and manage pictures, employee details, and product information.
- Reservation and Purchase Tracking: Administrators can effortlessly manage reservations, keep track of bought products, and handle customer interactions.
- Reporting and Archiving: The app provides reporting capabilities for performance analysis and an organized archiving system for data management.
With its user-friendly interfaces and comprehensive feature set, the eBarbershop project enhances the overall barber shop experience for both clients and administrators.

## Login Credentials - Desktop App
- Administrator Login
```
Username: admin
Password: admin
```
- Employee Login
```
Username: uposlenik
Password: uposlenik

Username: uposlenik2
Password: uposlenik2
```
## Login Credentials - Mobile App
- User Login
```
Username: user
Password: user

Username: user2
Password: user2
```
- Payment Card Number
```
4242 4242 4242 4242
```
## Running the Applications
1. Clone the repository
  ```
  https://github.com/DenielKnezevic/eBarberShop_RS2.git
  ```
2. Open the cloned repository in the console
3. Start the Dockerized API and DB
  ```
  docker-compose build
  docker-compose up
  ```
5. Open the ebarbershop_mobile folder
  ```
  cd ebarbershop_mobile
  ```
6. Fetch dependencies
  ```
  flutter pub get
  ```
7. Run the mobile application
  ```
  flutter run
  ```
9. Run the desktop application
  ```
  1. Open the solution in Visual Studio
  2. Right-click on the solution
  3. Set Startup Projects
  4. Multiple startup projects
  5. eBarberShop.WinUI - Start
  6. OK
  7. CTRL + F5
  ```
