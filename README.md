# SmartHome-features
Small project developed in .NET showcasing the application of OOP principles in the topic of 'Smart Homes'.  

App consists of 4 classes and 1 interface:

smartDevice (abstract class) -base class for all devices
Podesavanja (interface) -defines methods for condiguring devices
smartLighting -inherits smartDevice 
smartTermostat -inherits smartDevice and implements 'Podesavanja'
Program -main class that starts the app

Applied OOP Principles:

Inheritance - smartLighting and smartTermostat inherit smartDevice
Abstraction - smartDevice defines methods Ukljuci() and Iskljuci()
Polymorphism - a list was used smartDevice for device control
Interfaces - smartTermostat implements Podesavanja for increasing/decreasing of temperature

Running the project:
Install .NET SDK
Open the terminal
Run the command : dotnet run

