# Nanoframework Hello World
The goal of this project is to meet the needs of the majority of IoT projects. The basic flow or set of features for this project are as follows: 
- If a WiFi is not configured (or preset) create our own AP
- Host a page that is accesable via the AP for configuration / settings
    - This includes application settings, as well as wifi settings that this device should normaly connect to.
- An API to match the HTML / web app for configuration changes
- Connect to the configured WiFi and Host configuration pages and api
- Minimum configuration: Start / Stop application loop. 
- Provide a place holder for the application to run (application loop)
- Feedback via onboard LED for current status - either based on color or flashing sequences.
- Stretch Goals:
    - Support set up via Bluetooth / mobile app
    - Basic Mobile App to interact with basic api

## Developement Goals / Milestones
[] Connect to WiFi
[] Host Web Application
[] Create self hosted AP
[] App Web App Functionality
    - Read / write config settings
    - start / stop app
[] Create API to access admin features (Config / Start-Stop / Etc)
[] Experiment: Would this work as a nuget package or nuget deployed .net template
[] Deploy as either nuget lib or template
[] Update GH Workflow to update nuget
