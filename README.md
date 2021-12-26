# Forza Horizon 5 Artemis Plugin
 Forza Horizon 5 Plugin for getting data from game to [Artemis](https://artemis-rgb.com/).
 
### Compatibility
| Game | Compatibility |
| ------ | ------ |
| Forza Horizon 5 | Tested - It works |
| Forza Horizon 4 | Not tested - It should work |
| Other Forza Games | Not tested - It shouldn't work  |

### Features
- Plugin can get data from Forza Horizon 5's Data-Out feature.
- It works over the UDP protocol.
- The UDP port is fixed, you need to change it through the code. There are no settings for now.

### Changing UDP Port
You can set different UDP Port by changing "port" variable from "ForzaHorizon5Module.cs" file.

### Installation
- You can use latest release or compile it yourself.
- Just import zip file in Artemis from Settings->Plugin page. If you compile yourself it will be installed automatically.
- In Forza Horizon 5 you need to change Settings->HUD and Gameplay->Data-Out's IP and PORT to "127.0.0.1" and "8001". And don't forget to set Data-Out feature as "Open".
- If you want to use it with different applications you need to use [SIM Dashboard](http://www.stryder-it.de/simdashboard/index.php). [This guide](https://www.stryder-it.de/simdashboard/help/en/For_PC_Gamers/Advanced/Forward_UDP_Telemetry_to_other_applications_or_Devices) will help you.

### Example Usage
https://user-images.githubusercontent.com/24853725/147422096-89ae13d0-b320-482b-85fb-901b61a873bd.mp4

### Thanks
Big thanks to [Geoffrey Vancoetsem](https://github.com/geeooff), I benefited a lot from [his project](https://github.com/geeooff/forza-data-web).
