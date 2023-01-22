# eBarberShop_RS2

## Kredencijali za prijavu - Desktop app
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
## Kredencijali za prijavu - Mobile app
- User Login
```
Username: user
Password: user

Username: user2
Password: user2
```
- Broj kartice za placanje
```
4242 4242 4242 4242
```
## Pokretanje aplikacija
1. Kloniranje repozitorija
  ```
  https://github.com/DenielKnezevic/eBarberShop_RS2.git
  ```
2. Otvoriti klonirani repozitorij u konzoli
3. Pokretanje dokerizovanog API-ja i DB-a
  ```
  docker-compose build
  docker-compose up
  ```
5. Otvoriti ebarbershop_mobile folder
  ```
  cd ebarbershop_mobile
  ```
6. Dohvatanje dependecy-a
  ```
  flutter pub get
  ```
7. Pokretanje mobilne aplikacije
  ```
  flutter run
  ```
9. Pokretanje desktop aplikacije
  ```
  1. Otvoriti solution u Visual Studiu
  2. Desni klik na solution
  3. Set Startup Projects
  4. Multiple startup projects
  5. eBarberShop.WinUI - Start
  6. OK
  7. CTRL + F5
  ```
