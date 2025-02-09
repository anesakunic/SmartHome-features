# SmartHome-features
Small project developed in .NET showcasing the application of OOP principles in the topic of 'Smart Homes'.  

# 🏠 Smart Home – .NET Console App  



## 📌 Project Structure: 

App consists of 4 classes and 1 interface:  
🔹 **`smartDevice`** – (abstract class) -base class for all devices
🔹 **`Podesavanja`** – defines methods for configuring devices
🔹 **`smartLighting`** – inherits smartDevice 
🔹 **`smartTermostat`** – inherits smartDevice and implements 'Podesavanja'
🔹 **`Program`** – main class that starts the app
---

## 🛠️ Tech: 

✅ **PL**: C#  
✅ **Framework**: .NET 9.0.102
-

## 🔹 Running the app:

1️⃣ Install **.NET SDK**  
2️⃣ Open the terminal
3️⃣ Run the command: 
   
   dotnet run


## You should get the following output:

Svjetlo Dnevni Boravak je sada ON
Termostat Dječija soba je sada ON
Temperatura Dječija soba je sada povećana na 25°C
Temperatura Dječija soba je sada smanjena na 24°C
Svjetlo Dnevni Boravak je sada OFF
Termostat Dječija soba je sada OFF
