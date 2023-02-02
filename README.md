# MQTT Client CanSat Competition

## Introduction

This repository contains the code for an MQTT client that was developed for a CanSat competition in C#. CanSat is a competition where students design, build and launch a simulation of a satellite that fits into a soft drink can.

## Requirements

The code in this repository has been tested on Microsoft .NET Framework 4.x and later versions. To run the code, you'll need to have the following packages installed:
- M2Mqtt
- Microsoft.Win32.TaskScheduler (if using Windows Task Scheduler for MQTT client start up)

## Usage

To run the code, simply clone the repository and open the solution in Visual Studio. Build the solution and run the application.

## Configuration

The code uses MQTT to communicate with a broker. The broker URL and other configuration settings can be found in the `Form1.cs` file.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributions

Contributions are welcome! If you'd like to make changes to the code or add new features, feel free to create a pull request.
